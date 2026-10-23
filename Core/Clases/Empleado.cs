using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    /// <summary>
    /// Representa a un empleado del restaurante que también es un usuario del sistema.
    /// </summary>
    public class Empleado : Usuario
    {
        public string Puesto { get; private set; }
        public string Telefono { get; private set; }
        public bool Activo { get; private set; }

        /// <summary>
        /// Crea un empleado y valida sus datos obligatorios.
        /// </summary>
        public Empleado(
            int idUsuario,
            string nombre,
            string usuarioAcceso,
            string puesto,
            string telefono)
            : base(idUsuario, nombre, usuarioAcceso)
        {
            if (string.IsNullOrWhiteSpace(puesto))
                throw new ArgumentException("El puesto del empleado es obligatorio.");

            Puesto = puesto;
            Telefono = telefono ?? string.Empty;
            Activo = true;
        }

        /// <summary>
        /// Permite actualizar el teléfono del empleado.
        /// </summary>
        public void ActualizarTelefono(string telefono)
        {
            Telefono = telefono ?? string.Empty;
        }

        /// <summary>
        /// Permite cambiar el puesto del empleado.
        /// </summary>
        public void CambiarPuesto(string nuevoPuesto)
        {
            if (string.IsNullOrWhiteSpace(nuevoPuesto))
                throw new ArgumentException("El puesto del empleado es obligatorio.");

            Puesto = nuevoPuesto;
        }

        /// <summary>
        /// Activa nuevamente al empleado.
        /// </summary>
        public void Activar()
        {
            Activo = true;
        }

        /// <summary>
        /// Desactiva al empleado sin eliminar su registro.
        /// </summary>
        public void Desactivar()
        {
            Activo = false;
        }

        public override string ObtenerTipoUsuario()
        {
            return "Empleado";
        }

        /// <summary>
        /// Devuelve los datos principales del empleado.
        /// </summary>
        public virtual string ObtenerInformacion()
        {
            return $"ID: {IdUsuario} | " +
                   $"Nombre: {Nombre} | " +
                   $"Puesto: {Puesto} | " +
                   $"Teléfono: {Telefono} | " +
                   $"Estado: {(Activo ? "Activo" : "Inactivo")}";
        }
    }
}