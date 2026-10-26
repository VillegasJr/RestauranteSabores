using Core.Clases;
using Core.Data;
using Core.Interfaz;
using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Core.repositorio
{
    public class RepositorioVentas : IVenta
    {
        public DataTable VentaDelDia()
        {
            // El DataTable es una Instancia para 
            DataTable tablaVenta = new DataTable();

            MySqlConnection conexion = Conexion.CrearConexion();
            string query = "SELECT mesa AS 'Mesa', fecha AS 'Fecha', subtotal AS 'Subtotal', " +
                "iva AS 'IVA', total AS 'Total', metodo_pago AS 'Metodo De Pago'" +
                "FROM ventas WHERE DATE(fecha) = CURDATE(); ";

            using (MySqlCommand comando = new MySqlCommand(query, conexion))
            {
                using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                { 
                    adaptador.Fill(tablaVenta);
                }
            }
            return tablaVenta;
        }

        public decimal VentaTotalDia()
        {
            decimal totalDia = 0;
            string query = "SELECT SUM(total) FROM ventas WHERE DATE(fecha) = CURDATE();";

            // Creamos la conexión localmente con tu método CrearConexion()
            using (MySqlConnection conexionLocal = Conexion.CrearConexion())
            {
                conexionLocal.Open(); // Nos aseguramos de abrirla

                using (MySqlCommand comando = new MySqlCommand(query, conexionLocal))
                {
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        totalDia = Convert.ToDecimal(resultado);
                    }
                }
            }

            return totalDia;
        }
    }
}
