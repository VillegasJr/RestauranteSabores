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
    public class RepositorioInventario : IInventario<Inventarioo>
    {
        public bool AgregarInventario(Inventarioo inventario)
        {
            MySqlConnection conexion = Conexion.CrearConexion();
            string query = "INSERT INTO inventario (nombre, categoria, stock, unidad, minimo) " +
                "VALUES (@nombre, @categoria, @stock, @unidad, @minimo)";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@nombre", inventario.Nombre);
            comando.Parameters.AddWithValue("@categoria", inventario.Categoria);
            comando.Parameters.AddWithValue("@stock", inventario.Stock);
            comando.Parameters.AddWithValue("@unidad", inventario.Unidad);
            comando.Parameters.AddWithValue("@minimo", inventario.Minimo);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                Console.WriteLine("Producto nuevo en el inventario.\n¡Registrado Correctamente!");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ¡Registar! el Producto.\n" +
                    $"{ex.Message} | {ex.StackTrace}");
            }
            finally
            {
                conexion.Close();
            }
            return true;
        }

        public bool ActualizarInventario(Inventarioo inventario)
        {
            MySqlConnection conexion = Conexion.CrearConexion();
            string query = "UPDATE inventario SET nombre = @nombre, categoria = @categoria, " +
                               "stock = @stock, unidad = @unidad, minimo = @minimo " +
                               "WHERE id = @id";
            MySqlCommand comando = new MySqlCommand(query, conexion);

            comando.Parameters.AddWithValue("@nombre", inventario.Nombre);
            comando.Parameters.AddWithValue("@categoria", inventario.Categoria);
            comando.Parameters.AddWithValue("@stock", inventario.Stock);
            comando.Parameters.AddWithValue("@unidad", inventario.Unidad);
            comando.Parameters.AddWithValue("@minimo", inventario.Minimo);
            comando.Parameters.AddWithValue("@id", inventario.ID);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                Console.WriteLine($"Producto {inventario.Nombre}.\n¡Actualizado Correctamente!");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ¡Actualizar! el Producto.\n" +
                    $"{ex.Message} | {ex.StackTrace}");
            }
            finally
            {
                conexion.Close();
            }
            return true;
        }

        public bool ElimiarProducto(Inventarioo inteventario)
        {
            MySqlConnection conexion = Conexion.CrearConexion();
            // La consulta correcta para eliminar por ID
            string query = "DELETE FROM inventario WHERE id = @id";

            MySqlCommand comando = new MySqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@id", inteventario.ID);

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                Console.WriteLine("Producto eliminado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el producto.\n" + $"{ex.Message} | {ex.StackTrace}");
            }
            finally
            {
                conexion.Close();
            }
            return true;
        }

        public DataTable InventarioInfo()
        {
            // El DataTable es una Instancia para
            DataTable tablaVenta = new DataTable();

            MySqlConnection conexion = Conexion.CrearConexion();
            string query = "SELECT id, nombre AS 'Nombre', categoria AS 'Categoria', stock AS 'Stock', " +
                "unidad AS 'Unidad', minimo AS 'Minimo'" +
                "FROM inventario;";

            using (MySqlCommand comando = new MySqlCommand(query, conexion))
            {
                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                {
                    adaptador.Fill(tablaVenta);
                }
            }
            return tablaVenta;
        }

        public int StockBajo()
        {
            int cantidad = 0;
            MySqlConnection conexion = Conexion.CrearConexion();
            // Productos cuyo stock está en o por debajo del mínimo, pero mayor al nivel crítico (ej. la mitad del mínimo)
            string query = "SELECT COUNT(*) FROM inventario WHERE stock <= minimo AND stock > (minimo / 2)";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            try
            {
                conexion.Open();
                cantidad = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return cantidad;
        }

        public int StockCritico()
        {
            int cantidad = 0;
            MySqlConnection conexion = Conexion.CrearConexion();
            // Productos cuyo stock ya sobrepasó críticamente el límite (la mitad o menos del mínimo)
            string query = "SELECT COUNT(*) FROM inventario WHERE stock <= (minimo / 2)";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            try
            {
                conexion.Open();
                cantidad = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return cantidad;
        }

        public int TotalInventario()
        {
            int total = 0;
            MySqlConnection conexion = Conexion.CrearConexion();
            string query = "SELECT COUNT(*) FROM inventario";
            MySqlCommand comando = new MySqlCommand(query, conexion);
            try
            {
                conexion.Open();
                total = Convert.ToInt32(comando.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return total;
        }
    }
}
