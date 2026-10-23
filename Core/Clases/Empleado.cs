using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    public class Empleado : Usuario
    {
        public string Puesto { get; private set; }
        public string Telefono { get; private set; }

        public Empleado(
            int idUsuario,
            string nombre,
            string usuarioAcceso,
            string puesto,
            string telefono)
            : base(idUsuario, nombre, usuarioAcceso)
        {
            if (string.IsNullOrWhiteSpace(puesto))
                throw new ArgumentException("El puesto es obligatorio.");

            Puesto = puesto;
            Telefono = telefono;
        }

        public void ActualizarTelefono(string telefono)
        {
            Telefono = telefono;
        }

        public override string ObtenerTipoUsuario()
        {
            return "Empleado";
        }

        public virtual string ObtenerInformacion()
        {
            return $"ID: {IdUsuario} | Nombre: {Nombre} | " +
                   $"Puesto: {Puesto} | Teléfono: {Telefono} | " +
                   $"Estado: {(Activo ? "Activo" : "Inactivo")}";
        }
    }
}