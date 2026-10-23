using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    /// Representa a un cliente del restaurante.
    /// Permite guardar sus datos y controlar si está activo.
    public class Cliente
    {
        public int IdCliente { get; private set; }
        public string Nombre { get; private set; }
        public string Telefono { get; private set; }
        public string Correo { get; private set; }
        public bool Activo { get; private set; }

        /// Constructor que permite registrar un cliente.
        public Cliente(int idCliente,string nombre,string telefono,string correo)
        {
            // El identificador debe ser mayor que cero.
            if (idCliente <= 0)
                throw new ArgumentException("El ID del cliente debe ser mayor que cero.");

            // El nombre es un dato obligatorio.
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del cliente es obligatorio.");

            // Guardamos la información recibida.
            IdCliente = idCliente;
            Nombre = nombre;
            Telefono = telefono ?? string.Empty;
            Correo = correo ?? string.Empty;

            // Un cliente nuevo comienza activo.
            Activo = true;
        }

        /// Actualiza los datos de contacto del cliente.
        public void ActualizarInformacion(string nombre,string telefono,string correo)
        {
            // Validamos que el nombre siga siendo obligatorio.
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del cliente es obligatorio.");

            Nombre = nombre;
            Telefono = telefono ?? string.Empty;
            Correo = correo ?? string.Empty;
        }

         /// Activa al cliente.
        public void Activar()
        {
            Activo = true;
        }

        /// Desactiva al cliente sin eliminar su registro.
        public void Desactivar()
        {
            Activo = false;
        }

        /// Devuelve los datos principales del cliente.
        public string ObtenerInformacion()
        {
            return $"ID: {IdCliente} | " +
                   $"Nombre: {Nombre} | " +
                   $"Teléfono: {Telefono} | " +
                   $"Correo: {Correo} | " +
                   $"Estado: {(Activo ? "Activo" : "Inactivo")}";
        }
    }
}
