using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    /// <summary>
    /// Define los estados posibles de un pedido.
    /// </summary>
    public enum EstadoPedido
    {
        Pendiente,
        EnPreparacion,
        Listo,
        Entregado,
        Cancelado
    }

    /// <summary>
    /// Representa un pedido realizado en el restaurante.
    /// </summary>
    public class Pedido
    {
        public int IdPedido { get; private set; }
        public DateTime FechaHora { get; private set; }
        public Mesa Mesa { get; private set; }
        public Empleado Empleado { get; private set; }
        public EstadoPedido Estado { get; private set; }

        /// <summary>
        /// Crea un pedido y valida los datos principales.
        /// </summary>
        public Pedido(int idPedido, Mesa mesa, Empleado empleado)
        {
            // Validamos que el identificador sea positivo.
            if (idPedido <= 0)
                throw new ArgumentException("El ID del pedido debe ser mayor que cero.");

            // El pedido debe estar asociado a una mesa.
            if (mesa == null)
                throw new ArgumentException("El pedido debe tener una mesa asignada.");

            // El pedido debe tener un empleado responsable.
            if (empleado == null)
                throw new ArgumentException("El pedido debe tener un empleado asignado.");

            // No permitimos registrar pedidos en mesas no disponibles.
            if (!mesa.EstaDisponible())
                throw new InvalidOperationException("La mesa no está disponible para un nuevo pedido.");

            // Guardamos los datos del pedido.
            IdPedido = idPedido;
            Mesa = mesa;
            Empleado = empleado;
            FechaHora = DateTime.Now;

            // Todo pedido nuevo comienza pendiente.
            Estado = EstadoPedido.Pendiente;

            // La mesa queda ocupada al registrar el pedido.
            Mesa.CambiarEstado(EstadoMesa.Ocupada);
        }

        /// <summary>
        /// Cambia el estado actual del pedido.
        /// </summary>
        public void CambiarEstado(EstadoPedido nuevoEstado)
        {
            // Comprobamos que el estado exista.
            if (!Enum.IsDefined(typeof(EstadoPedido), nuevoEstado))
                throw new ArgumentException("El estado indicado no es válido.");

            // No permitimos modificar un pedido cancelado.
            if (Estado == EstadoPedido.Cancelado)
                throw new InvalidOperationException("No se puede modificar un pedido cancelado.");

            // Un pedido entregado o cancelado es un estado final.
            if (Estado == EstadoPedido.Entregado)
                throw new InvalidOperationException("El pedido ya fue entregado.");

            Estado = nuevoEstado;

            // Si se cancela el pedido, liberamos la mesa.
            if (nuevoEstado == EstadoPedido.Cancelado)
                Mesa.CambiarEstado(EstadoMesa.Disponible);
        }

        /// <summary>
        /// Devuelve la información principal del pedido.
        /// </summary>
        public string ObtenerInformacion()
        {
            return $"Pedido: {IdPedido} | " +
                   $"Fecha: {FechaHora:dd/MM/yyyy HH:mm} | " +
                   $"Mesa: {Mesa.NumeroMesa} | " +
                   $"Empleado: {Empleado.Nombre} | " +
                   $"Estado: {Estado}";
        }
    }
}