using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Core.Data;

namespace Core.Repositorio
{
    /// Contiene las operaciones de base de datos
    /// relacionadas con las reservaciones.
    public class RepositorioReservas
    {
        /// Registra una reservación y devuelve su código.
        /// Si el cliente ya existe, actualiza sus datos.
        /// Si no existe, primero lo registra.
        /// 

        public string ConsultarReserva(string codigo)
        {
            using MySqlConnection con = Conexion.CrearConexion();
            con.Open();

            const string consulta = @"
                SELECT
                r.codigo_reserva, 
                c.nombre, 
                c.correo, 
                c.telefono, 
                r.fecha_hora,
                r.numero_personas,
                r.nota_especial,
                r.estado
                FROM reservas r
                INNER JOIN clientes c ON
                r.id_cliente = c.id
                WHERE r.codigo_reserva = @codigo LIMIT 1;";

            using MySqlCommand comando = new MySqlCommand(consulta, con);

            comando.Parameters.AddWithValue("@codigo", codigo.Trim());

            using MySqlDataReader lector = comando.ExecuteReader();
            if (!lector.Read())
            {
                  return null; // No se encontró la reserva.
            }
            string nota = lector["nota_especial"] == DBNull.Value ? "Sin nota" : lector["nota_especial"].ToString();    

            return "CODIGO DE RESERVACION: " +
                lector["codigo_reserva"] +
                "\r\n\r\nNombre: " +
                lector["nombre"] +
                "\r\nCorreo: " +
                lector["correo"] +
                "\r\nTelefono: " +
                lector["telefono"] + 
                "\r\nFecha y hora: " +

                Convert.ToDateTime(lector["fecha_hora"]).ToString("dd/mm/yyyy HH:mm") +
                "\r\nNumero de personas: " +
                lector["numero_personas"] +
                "\r\nNota: " + nota +
                "\r\nEstado: " + lector["estado"];
              
        }

        public string RegistrarReserva(string nombre,string correo,string telefono,DateTime fechaHora,int numeroPersonas,string notaEspecial)
        {
            // Validamos los datos obligatorios antes de consultar MySQL.
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del cliente es obligatorio.");

            if (string.IsNullOrWhiteSpace(correo))
                throw new ArgumentException("El correo electrónico es obligatorio.");

            if (string.IsNullOrWhiteSpace(telefono))
                throw new ArgumentException("El teléfono es obligatorio.");
            if (fechaHora <= DateTime.Now)
                throw new ArgumentException("La fecha y hora deben ser futuras.");

            if (numeroPersonas <= 0)
                throw new ArgumentException("El número de personas debe ser mayor que cero.");
            // Generamos un código único para consultar la reserva.
            string codigoReserva =
                "RS-" + Guid.NewGuid().ToString("N")
                    .Substring(0, 10).ToUpperInvariant();

            // Abrimos la conexión con la base de datos.
            using MySqlConnection conexion = Conexion.CrearConexion();
            conexion.Open();

            // Usamos una transacción para guardar cliente y reserva
            // como una sola operación.
            using MySqlTransaction transaccion =
                conexion.BeginTransaction();

            try
            {
                int idCliente;

                // Buscamos al cliente por su correo.
                const string consultaCliente = @"
                    SELECT id
                    FROM clientes
                    WHERE correo = @correo
                    LIMIT 1;";

                using (MySqlCommand comando = new MySqlCommand(consultaCliente, conexion, transaccion))
                {
                    comando.Parameters.AddWithValue("@correo", correo.Trim());

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        // El cliente ya existe: recuperamos su ID.
                        idCliente = Convert.ToInt32(resultado);

                        // Actualizamos sus datos de contacto.
                        const string actualizarCliente = @"
                            UPDATE clientes
                            SET nombre = @nombre,
                                telefono = @telefono
                            WHERE id = @id;";

                        using MySqlCommand actualizar =
                            new MySqlCommand(actualizarCliente, conexion, transaccion);

                        actualizar.Parameters.AddWithValue("@nombre", nombre.Trim());

                        actualizar.Parameters.AddWithValue("@telefono", telefono.Trim());

                        actualizar.Parameters.AddWithValue("@id", idCliente);

                        actualizar.ExecuteNonQuery();
                    }
                    else
                    {
                        // El cliente no existe: registramos sus datos.
                        const string insertarCliente = @"
                            INSERT INTO clientes
                                (nombre, telefono, correo)
                            VALUES
                                (@nombre, @telefono, @correo);";

                        using MySqlCommand insertar =
                            new MySqlCommand(insertarCliente, conexion, transaccion);

                        insertar.Parameters.AddWithValue("@nombre", nombre.Trim());

                        insertar.Parameters.AddWithValue("@telefono", telefono.Trim());

                        insertar.Parameters.AddWithValue("@correo", correo.Trim());

                        insertar.ExecuteNonQuery();

                        // Recuperamos el ID generado por MySQL.
                        idCliente = Convert.ToInt32(insertar.LastInsertedId);
                    }
                }

                // Guardamos la reservación asociada al cliente.
                const string insertarReserva = @"
                    INSERT INTO reservas
                    (
                        codigo_reserva,
                        id_cliente,
                        fecha_hora,
                        numero_personas,
                        nota_especial,
                        estado
                    )
                    VALUES
                    (
                        @codigo,
                        @idCliente,
                        @fechaHora,
                        @personas,
                        @nota,
                        'CONFIRMADA'
                    );";

                using (MySqlCommand comandoReserva =
                    new MySqlCommand(insertarReserva, conexion, transaccion))
                {
                    comandoReserva.Parameters.AddWithValue("@codigo", codigoReserva);

                    comandoReserva.Parameters.AddWithValue("@idCliente", idCliente);

                    comandoReserva.Parameters.AddWithValue("@fechaHora", fechaHora);

                    comandoReserva.Parameters.AddWithValue("@personas", numeroPersonas);

                    comandoReserva.Parameters.AddWithValue(
                        "@nota",
                        string.IsNullOrWhiteSpace(notaEspecial)
                            ? DBNull.Value
                            : notaEspecial.Trim());

                    comandoReserva.ExecuteNonQuery();
                }

                // Confirmamos los cambios en la base de datos.
                transaccion.Commit();

                // Devolvemos el código para mostrárselo al usuario.
                return codigoReserva;
            }
            catch
            {
                // Si algo falla, deshacemos los cambios pendientes.
                transaccion.Rollback();

                // Dejamos que el formulario gestione el error.
                throw;
            }
        }
    }
}

