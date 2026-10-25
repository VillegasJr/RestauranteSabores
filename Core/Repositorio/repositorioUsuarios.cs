using Core.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Core.Repositorio
{
    
    public class RepositorioUsuarios
    {
        public bool ValidarUsuario(
            string nombreUsuario,
            string contrasena,
            out string rol)
        {
            rol = string.Empty;

            string sql = @"
                SELECT rol
                FROM usuarios
                WHERE nombre_usuario = @usuario
                  AND password_hash = @contrasena
                  AND activo = 1
                LIMIT 1;";

            using (MySqlConnection conexion = Conexion.CrearConexion())
            {
                conexion.Open();

                using (MySqlCommand comando =
                    new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@usuario", nombreUsuario);

                    comando.Parameters.AddWithValue(
                        "@contrasena", contrasena);

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            rol = lector["rol"].ToString();
                            return true;
                        }

                        return false;
                    }
                }
            }
        }
    }
}
