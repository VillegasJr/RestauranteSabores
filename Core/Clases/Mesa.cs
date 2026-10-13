using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    public enum EstadoMesa
    {
        Disponible,
        Reservada,
        Ocupada,
        FueraDeServicio
    }

    public class Mesa
    {
        public int IdMesa { get; private set; }
        public int NumeroMesa { get; private set; }
        public int Capacidad { get; private set; }
        public EstadoMesa Estado { get; private set; }

        public Mesa(
            int idMesa,
            int numeroMesa,
            int capacidad)
        {
            if (idMesa <= 0)
                throw new ArgumentException(
                    "El ID de la mesa debe ser mayor que cero.");

            if (numeroMesa <= 0)
                throw new ArgumentException(
                    "El número de mesa debe ser mayor que cero.");

            if (capacidad <= 0)
                throw new ArgumentException(
                    "La capacidad debe ser mayor que cero.");

            IdMesa = idMesa;
            NumeroMesa = numeroMesa;
            Capacidad = capacidad;
            Estado = EstadoMesa.Disponible;
        }

        public void CambiarEstado(EstadoMesa nuevoEstado)
        {
            Estado = nuevoEstado;
        }

        public bool EstaDisponible()
        {
            return Estado == EstadoMesa.Disponible;
        }

        public void CambiarCapacidad(int nuevaCapacidad)
        {
            if (nuevaCapacidad <= 0)
                throw new ArgumentException(
                    "La capacidad debe ser mayor que cero.");

            Capacidad = nuevaCapacidad;
        }

        public string ObtenerInformacion()
        {
            return $"Mesa: {NumeroMesa} | " +
                   $"Capacidad: {Capacidad} personas | " +
                   $"Estado: {Estado}";
        }
    }
}

