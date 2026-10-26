
using Core.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Core.Repositorio
{
    public class RepositorioVentas
    {
        // Registra una venta y sus platillos en una transacción.
        public int RegistrarVenta(
            int pedidoId,
            string mesa,
            int cajeroId,
            string metodoPago,
            decimal subtotal,
            decimal iva,
            decimal total)
        {
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();

                using (MySqlTransaction transaccion =
                    conexion.BeginTransaction())
                {
                    try
                    {
                        // Verificar que el pedido exista y no esté cobrado.
                        string verificar = @"
                            SELECT COUNT(*)
                            FROM pedidos p
                            WHERE p.id = @pedidoId
                              AND NOT EXISTS (
                                  SELECT 1
                                  FROM ventas v
                                  WHERE v.pedido_id = p.id
                              );";

                        using (MySqlCommand comando =
                            new MySqlCommand(
                                verificar, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue(
                                "@pedidoId", pedidoId);

                            int existe = Convert.ToInt32(
                                comando.ExecuteScalar());

                            if (existe == 0)
                            {
                                throw new InvalidOperationException(
                                    "El pedido no existe o ya fue cobrado.");
                            }
                        }

                        // Insertar los datos generales de la venta.
                        string insertarVenta = @"
                            INSERT INTO ventas
                            (pedido_id, mesa, fecha, subtotal,
                             iva, total, metodo_pago, cajero_id)
                            VALUES
                            (@pedidoId, @mesa, NOW(), @subtotal,
                             @iva, @total, @metodoPago, @cajeroId);";

                        int ventaId;

                        using (MySqlCommand comando =
                            new MySqlCommand(
                                insertarVenta, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue(
                                "@pedidoId", pedidoId);
                            comando.Parameters.AddWithValue(
                                "@mesa", mesa);
                            comando.Parameters.AddWithValue(
                                "@subtotal", subtotal);
                            comando.Parameters.AddWithValue(
                                "@iva", iva);
                            comando.Parameters.AddWithValue(
                                "@total", total);
                            comando.Parameters.AddWithValue(
                                "@metodoPago", metodoPago);
                            comando.Parameters.AddWithValue(
                                "@cajeroId", cajeroId);

                            comando.ExecuteNonQuery();

                            // Recuperar el ID generado para esta venta.
                            ventaId = Convert.ToInt32(
                                comando.LastInsertedId);
                        }

                        // Copiar los platillos del pedido a detalle_venta.
                        string insertarDetalles = @"
                            INSERT INTO detalle_venta
                            (venta_id, menu_id, cantidad, precio, subtotal)
                            SELECT
                                @ventaId,
                                dp.menu_id,
                                dp.cantidad,
                                m.precio,
                                dp.cantidad * m.precio
                            FROM detalle_pedido dp
                            INNER JOIN menu m ON m.id = dp.menu_id
                            WHERE dp.pedido_id = @pedidoId;";

                        using (MySqlCommand comando =
                            new MySqlCommand(
                                insertarDetalles, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue(
                                "@ventaId", ventaId);
                            comando.Parameters.AddWithValue(
                                "@pedidoId", pedidoId);

                            int detalles = comando.ExecuteNonQuery();

                            // Evitar confirmar una venta sin detalles válidos.
                            if (detalles == 0)
                            {
                                throw new InvalidOperationException(
                                    "El pedido no contiene platillos válidos.");
                            }
                        }

                        // Cambiar el estado del pedido después del cobro.
                        string actualizarPedido = @"
                            UPDATE pedidos
                            SET estado = 'Cobrado'
                            WHERE id = @pedidoId;";

                        using (MySqlCommand comando =
                            new MySqlCommand(
                                actualizarPedido, conexion, transaccion))
                        {
                            comando.Parameters.AddWithValue(
                                "@pedidoId", pedidoId);

                            comando.ExecuteNonQuery();
                        }

                        // Confirmar todos los cambios de la transacción.
                        transaccion.Commit();

                        return ventaId;
                    }
                    catch
                    {
                        // Deshacer los cambios si ocurre un error.
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }

        // Consulta todas las ventas registradas durante el día actual.
        public DataTable VentaDelDia()
        {
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT
                        id AS Folio,
                        pedido_id AS Pedido,
                        mesa AS Mesa,
                        fecha AS Fecha,
                        subtotal AS Subtotal,
                        iva AS IVA,
                        total AS Total,
                        metodo_pago AS MetodoPago
                    FROM ventas
                    WHERE fecha >= CURDATE()
                      AND fecha < CURDATE() + INTERVAL 1 DAY
                    ORDER BY fecha DESC;";

                using (MySqlCommand comando =
                    new MySqlCommand(sql, conexion))
                using (MySqlDataAdapter adaptador =
                    new MySqlDataAdapter(comando))
                {
                    // Crear una tabla en memoria para guardar los resultados.
                    DataTable tabla = new DataTable();

                    // Ejecutar la consulta y llenar la tabla.
                    adaptador.Fill(tabla);

                    // Devolver las ventas al formulario.
                    return tabla;
                }
            }
        }

        // Calcula el importe total de las ventas del día actual.
        public decimal VentaTotalDia()
        {
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT COALESCE(SUM(total), 0)
                    FROM ventas
                    WHERE fecha >= CURDATE()
                      AND fecha < CURDATE() + INTERVAL 1 DAY;";

                using (MySqlCommand comando =
                    new MySqlCommand(sql, conexion))
                {
                    // Obtener un único resultado: la suma de las ventas.
                    object resultado = comando.ExecuteScalar();

                    // Convertir el resultado al tipo decimal y devolverlo.
                    return Convert.ToDecimal(resultado);
                }
            }
        }
    }
}
