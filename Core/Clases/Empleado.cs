using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    /// Representa a un empleado del restaurante.
    /// El puesto permite identificar si trabaja como mesero,
    /// cocinero, administrador u otro tipo de empleado.
    public class Empleado
    {
       public int IdEmpleado { get; private set; }
        public string Nombre { get; private set; }
        public string Puesto { get; private set; }
        public string Telefono { get; private set; }
        public bool Activo { get; private set; }

        /// Crea un empleado y valida sus datos obligatorios.
        public Empleado(int idEmpleado,string nombre,string puesto,string telefono)
        {
            // El identificador debe ser positivo.
            if (idEmpleado <= 0)
                throw new ArgumentException("El ID del empleado debe ser mayor que cero.");

            // El nombre no puede estar vacío.
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del empleado es obligatorio.");

            // El puesto es necesario para identificar su función.
            if (string.IsNullOrWhiteSpace(puesto))
                throw new ArgumentException("El puesto del empleado es obligatorio.");

            // Guardamos los datos recibidos.
            IdEmpleado = idEmpleado;
            Nombre = nombre;
            Puesto = puesto;
            Telefono = telefono ?? string.Empty;

            // Todo empleado nuevo comienza activo.
            Activo = true;
        }

        /// Permite actualizar el teléfono del empleado.
        public void ActualizarTelefono(string telefono)
        {
            Telefono = telefono ?? string.Empty;
        }

        /// Permite cambiar el puesto del empleado.
        public void CambiarPuesto(string nuevoPuesto)
        {
            if (string.IsNullOrWhiteSpace(nuevoPuesto))
                throw new ArgumentException("El puesto del empleado es obligatorio.");

            Puesto = nuevoPuesto;
        }

        /// Activa nuevamente al empleado.
        public void Activar()
        {
            Activo = true;
        }

        /// Desactiva al empleado sin eliminar su registro.
        public void Desactivar()
        {
            Activo = false;
        }

        /// Devuelve los datos principales del empleado.
        public string ObtenerInformacion()
        {
            return $"ID: {IdEmpleado} | " +
                   $"Nombre: {Nombre} | " +
                   $"Puesto: {Puesto} | " +
                   $"Teléfono: {Telefono} | " +
                   $"Estado: {(Activo ? "Activo" : "Inactivo")}";
        }
    }
}
