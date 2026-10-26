
using System.Data;
using MySql.Data.MySqlClient;
using Core.Data;

namespace ScreenRestaurante
{
    public class RepositorioCocina
    {
        // Obtiene los pedidos de un estado y sus platillos,
        // cantidades, fecha y notas especiales.
        public DataTable ObtenerPedidosPorEstado(string estado)
        {
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();

                string sql = @"
                    SELECT
                        p.id AS IdPedido,
                        p.mesa AS Mesa,
                        p.estado AS Estado,
                        p.fecha AS Fecha,

                        COALESCE(
                            GROUP_CONCAT(
                                CONCAT(
                                    m.nombre,
                                    ' x',
                                    dp.cantidad
                                )
                                ORDER BY m.nombre
                                SEPARATOR ', '
                            ),
                            'Sin platillos'
                        ) AS Platillos,

                        COALESCE(
                            GROUP_CONCAT(
                                CASE
                                    WHEN dp.notas IS NOT NULL
                                         AND TRIM(dp.notas) <> ''
                                    THEN CONCAT(
                                        m.nombre,
                                        ': ',
                                        dp.notas
                                    )
                                    ELSE NULL
                                END
                                SEPARATOR ' | '
                            ),
                            'Sin notas especiales'
                        ) AS Notas

                    FROM pedidos p

                    LEFT JOIN detalle_pedido dp
                        ON p.id = dp.pedido_id

                    LEFT JOIN menu m
                        ON dp.menu_id = m.id

                    WHERE p.estado = @estado

                    GROUP BY
                        p.id,
                        p.mesa,
                        p.estado,
                        p.fecha

                    ORDER BY p.fecha ASC;";

                using (MySqlCommand comando =
                    new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@estado", estado);

                    using (MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);

                        return tabla;
                    }
                }
            }
        }

        // Cambia el estado de un pedido existente.
        public bool CambiarEstado(
            int idPedido,
            string nuevoEstado)
        {
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();

                string sql = @"
                    UPDATE pedidos
                    SET estado = @estado
                    WHERE id = @id;";

                using (MySqlCommand comando =
                    new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@estado", nuevoEstado);

                    comando.Parameters.AddWithValue(
                        "@id", idPedido);

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
