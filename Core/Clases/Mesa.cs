using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    /// Define los estados posibles de una mesa.
    public enum EstadoMesa
    {
        Disponible,
        Reservada,
        Ocupada,
        FueraDeServicio
    }

    /// Representa una mesa física del restaurante.
    public class Mesa
    {
        public int IdMesa { get; private set; }
        public int NumeroMesa { get; private set; }
        public int Capacidad { get; private set; }
        public EstadoMesa Estado { get; private set; }

        /// Crea una mesa con su número y capacidad.
        public Mesa(int idMesa,int numeroMesa,int capacidad)
        {
            // El ID debe ser positivo.
            if (idMesa <= 0)
                throw new ArgumentException("El ID de la mesa debe ser mayor que cero.");

            // El número de mesa debe ser positivo.
            if (numeroMesa <= 0)
                throw new ArgumentException("El número de mesa debe ser mayor que cero.");

            // La capacidad debe ser de al menos una persona.
            if (capacidad <= 0)
                throw new ArgumentException("La capacidad debe ser mayor que cero.");

            // Guardamos los datos de la mesa.
            IdMesa = idMesa;
            NumeroMesa = numeroMesa;
            Capacidad = capacidad;

            // Toda mesa nueva comienza disponible.
            Estado = EstadoMesa.Disponible;
        }

        /// Cambia el estado actual de la mesa.
        public void CambiarEstado(EstadoMesa nuevoEstado)
        {
            // Evitamos aceptar valores de estado no definidos.
            if (!Enum.IsDefined(typeof(EstadoMesa), nuevoEstado))
                throw new ArgumentException("El estado indicado no es válido.");

            Estado = nuevoEstado;
        }

        /// Indica si la mesa puede recibir clientes.
        public bool EstaDisponible()
        {
            return Estado == EstadoMesa.Disponible;
        }

        /// Modifica la capacidad de la mesa.
        public void CambiarCapacidad(int nuevaCapacidad)
        {
            if (nuevaCapacidad <= 0)
                throw new ArgumentException("La capacidad debe ser mayor que cero.");

            Capacidad = nuevaCapacidad;
        }

        /// Devuelve los datos principales de la mesa.
        public string ObtenerInformacion()
        {
            return $"Mesa: {NumeroMesa} | " +
                   $"Capacidad: {Capacidad} personas | " +
                   $"Estado: {Estado}";
        }
    }
}
