
using System.Data;
using MySql.Data.MySqlClient;
using Core.Data;

namespace Core.Repositorios
{
    public class RepositorioPedidos
    {
        public int Registrar(string mesa, int meseroId, string estado)
        {
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();
                string sql = "INSERT INTO pedidos (mesa, mesero_id, estado, fecha) VALUES (@mesa, @mesero, @estado, NOW())";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@mesa", mesa);
                comando.Parameters.AddWithValue("@mesero", meseroId);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.ExecuteNonQuery();
                return (int)comando.LastInsertedId;
            }
        }

        public void RegistrarPlatillo(int pedidoId, int menuId, int cantidad, string notas)
        {
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();
                string sql = "INSERT INTO detalle_pedido (pedido_id, menu_id, cantidad, notas) VALUES (@pedido, @menu, @cantidad, @notas)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@pedido", pedidoId);
                comando.Parameters.AddWithValue("@menu", menuId);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
                comando.Parameters.AddWithValue("@notas", notas);
                comando.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerTodos()
        {
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();
                string sql = "SELECT p.id, p.mesa, e.nombre AS mesero, p.estado, p.fecha FROM pedidos p INNER JOIN empleados e ON p.mesero_id = e.id ORDER BY p.fecha DESC";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        public void CambiarEstado(int id, string estado)
        {
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();
                string sql = "UPDATE pedidos SET estado = @estado WHERE id = @id";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerPlatillos(string categoria)
        {
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();
                string sql = "SELECT id, nombre, precio FROM menu WHERE disponible = 1 AND categoria = @categoria ORDER BY nombre";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@categoria", categoria);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        // Obtiene los platillos de un pedido para calcular su cobro.
        public DataTable ObtenerDetalleParaCobro(int pedidoId)
        {
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();

                string sql = @"
            SELECT
                m.nombre AS Platillo,
                dp.cantidad AS Cantidad,
                m.precio AS Precio,
                (dp.cantidad * m.precio) AS Subtotal
            FROM detalle_pedido dp
            INNER JOIN menu m ON dp.menu_id = m.id
            WHERE dp.pedido_id = @pedidoId";

                using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@pedidoId", pedidoId);

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

    }
}



