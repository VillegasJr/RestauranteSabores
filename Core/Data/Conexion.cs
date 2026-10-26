using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Core.Data
{
    /// Centraliza la configuración para conectarse
    /// a la base de datos del restaurante.
    public static class Conexion
    {
       
        private const string Servidor = "127.0.0.1";
      
        private const string Puerto = "3306";
       
        private const string BaseDatos = "restaurante_sabores";
     
        private const string Usuario = "root";

        private const string Contrasena = "1102";

     
        /// Construye y devuelve la cadena de conexión.
     
        public static string ObtenerCadenaConexion()
        {
            MySqlConnectionStringBuilder constructor =
                new MySqlConnectionStringBuilder();

            constructor.Server = Servidor;
            constructor.Port = uint.Parse(Puerto);
            constructor.Database = BaseDatos;
            constructor.UserID = Usuario;
            constructor.Password = Contrasena;

            return constructor.ConnectionString;
        }

   
        /// Crea una conexión nueva para que un repositorio
        /// pueda abrirla y ejecutar sus consultas.
     
        public static MySqlConnection CrearConexion()
        {
            return new MySqlConnection(
                ObtenerCadenaConexion());
        }
    }
}

