using Core.Clases;
using Core.Data;
using Core.Interfaz;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.repositorio
{
    public class RepositorioReservacion : IReservacion<Reserva>
    {
        public DataTable BuscarClave(string codigo)
        {
            DataTable tablaVenta = new DataTable();
            MySqlConnection conexion = Conexion.CrearConexion();

            string query = "SELECT r.id_reserva, r.codigo_reserva AS 'Codigo de Reservación', c.nombre AS 'Cliente', r.fecha_hora AS 'Día de Reservación', " +
                           "r.numero_personas AS 'No. de Personas', r.nota_especial AS 'Nota', r.estado AS 'Estado', r.fecha_creacion " +
                           "FROM reservas r " +
                           "INNER JOIN clientes c ON r.id_cliente = c.id " +
                           "WHERE r.codigo_reserva LIKE @codigo;";

            using (MySqlCommand comando = new MySqlCommand(query, conexion))
            {
                // Usamos parámetros para mayor seguridad (permite buscar coincidencias parciales o exactas)
                comando.Parameters.AddWithValue("@codigo", "%" + codigo + "%");

                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                {
                    adaptador.Fill(tablaVenta);
                }
            }
            return tablaVenta;
        }

        public bool CambiarEstadoReserva(string codigoReserva, string nuevoEstado)
        {
            bool actualizado = false;

            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                string query = "UPDATE reservas SET estado = @estado WHERE codigo_reserva = @codigo;";

                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@estado", nuevoEstado);
                    comando.Parameters.AddWithValue("@codigo", codigoReserva);

                    conexion.Open();
                    int filas = comando.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        actualizado = true;
                    }
                }
            }
            return actualizado;
        }

        public bool ModificarReserva(Reserva reserva)
        {
            bool actualizado = false;

            // Usamos 'using' tanto para la conexión como para el comando para garantizar que se cierren y se liberen correctamente
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                string query = "UPDATE reservas SET fecha_hora = @fecha, numero_personas = @personas, nota_especial = @nota " +
                               "WHERE codigo_reserva = @codigo;";

                using (MySqlCommand comando = new MySqlCommand(query, conexion))
                {
                    // Asignamos los valores a los parámetros
                    comando.Parameters.AddWithValue("@fecha", reserva.Fecha_Hora);
                    comando.Parameters.AddWithValue("@personas", reserva.Num_Personas);
                    comando.Parameters.AddWithValue("@nota", reserva.Nota);
                    comando.Parameters.AddWithValue("@codigo", reserva.Codigo_Reserva);

                    conexion.Open();

                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        actualizado = true;
                    }
                }
            }
            return actualizado;
        }

        public DataTable MostrarReservas()
        {
            // El DataTable es una Instancia para
            DataTable tablaVenta = new DataTable();

            MySqlConnection conexion = Conexion.CrearConexion();
            string query = "SELECT r.id_reserva, r.codigo_reserva AS 'Codigo de Reservación', c.nombre AS 'Cliente', r.fecha_hora AS 'Día de Reservación', " +
                           "r.numero_personas AS 'No. de Personas', r.nota_especial AS 'Nota', r.estado AS 'Estado', r.fecha_creacion " +
                           "FROM reservas r " +
                           "INNER JOIN clientes c ON r.id_cliente = c.id;";

            using (MySqlCommand comando = new MySqlCommand(query, conexion))
            {
                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                {
                    adaptador.Fill(tablaVenta);
                }
            }
            return tablaVenta;
        }
    }
}
