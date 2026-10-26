using Core.Clases;
using Core.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaz
{
    internal interface IVenta
    {
        public DataTable VentaDelDia()
        {
            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();

                string sql = "SELECT mesa AS 'Mesa', fecha AS 'Fecha', subtotal AS 'Subtotal', " +
                "iva AS 'IVA', total AS 'Total', metodo_pago AS 'Metodo De Pago'" +
                "FROM ventas WHERE DATE(fecha) = CURDATE(); ";

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


        public decimal VentaTotalDia();
    }
}
