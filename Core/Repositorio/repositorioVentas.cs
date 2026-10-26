using Core.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                        // Registrar la venta.
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
                            ventaId = (int)comando.LastInsertedId;
                        }

                        // Copiar los platillos del pedido a la venta.
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

                            if (detalles == 0)
                            {
                                throw new InvalidOperationException(
                                    "El pedido no contiene platillos válidos.");
                            }
                        }

                        // Marcar el pedido como cobrado.
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

                        transaccion.Commit();
                        return ventaId;
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
