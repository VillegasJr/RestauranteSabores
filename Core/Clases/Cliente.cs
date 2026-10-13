using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    public class Cliente
    {
        public int IdCliente { get; private set; }
        public string Nombre { get; private set; }
        public string Telefono { get; private set; }
        public string Correo { get; private set; }
        public bool Activo { get; private set; }

        public Cliente(
            int idCliente,
            string nombre,
            string telefono,
            string correo)
        {
            if (idCliente <= 0)
                throw new ArgumentException(
                    "El ID del cliente debe ser mayor que cero.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException(
                    "El nombre del cliente es obligatorio.");

            IdCliente = idCliente;
            Nombre = nombre;
            Telefono = telefono ?? string.Empty;
            Correo = correo ?? string.Empty;
            Activo = true;
        }

        public void ActualizarInformacion(
            string nombre,
            string telefono,
            string correo)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException(
                    "El nombre del cliente es obligatorio.");

            Nombre = nombre;
            Telefono = telefono ?? string.Empty;
            Correo = correo ?? string.Empty;
        }

        public void Activar()
        {
            Activo = true;
        }

        public void Desactivar()
        {
            Activo = false;
        }

        public string ObtenerInformacion()
        {
            return $"ID: {IdCliente} | Nombre: {Nombre} | " +
                   $"Teléfono: {Telefono} | Correo: {Correo} | " +
                   $"Estado: {(Activo ? "Activo" : "Inactivo")}";
        }
    }
}
