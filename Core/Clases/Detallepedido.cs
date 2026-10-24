using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    /// <summary>
    /// Representa una línea o detalle de un pedido.
    /// Cada detalle relaciona un pedido con un producto,
    /// su cantidad y el precio aplicado.
    /// </summary>
    public class DetallePedido
    {
        public int IdDetalle { get; private set; }
        public Pedido Pedido { get; private set; }
        public Producto Producto { get; private set; }
        public int Cantidad { get; private set; }
        public decimal PrecioUnitario { get; private set; }

        // Importe del detalle: cantidad multiplicada por precio.
        public decimal Subtotal
        {
            get { return Cantidad * PrecioUnitario; }
        }

        /// <summary>
        /// Crea un detalle y valida sus datos.
        /// </summary>
        public DetallePedido(int idDetalle, Pedido pedido, Producto producto, int cantidad)
        {
            // Validamos que el identificador sea positivo.
            if (idDetalle <= 0)
                throw new ArgumentException("El ID del detalle debe ser mayor que cero.");

            // El detalle debe pertenecer a un pedido.
            if (pedido == null)
                throw new ArgumentException("El detalle debe estar relacionado con un pedido.");

            // El producto es obligatorio.
            if (producto == null)
                throw new ArgumentException("Debes seleccionar un producto.");

            // Solo permitimos cantidades positivas.
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero.");

            // No permitimos agregar productos inactivos.
            if (!producto.Activo)
                throw new InvalidOperationException("No se puede agregar un producto inactivo.");

            // Guardamos los datos del detalle.
            IdDetalle = idDetalle;
            Pedido = pedido;
            Producto = producto;
            Cantidad = cantidad;

            // Conservamos el precio vigente al crear el detalle.
            // Así, un cambio futuro en el precio del producto
            // no modifica el importe histórico de este detalle.
            PrecioUnitario = producto.Precio;
        }

        /// <summary>
        /// Modifica la cantidad solicitada.
        /// </summary>
        public void CambiarCantidad(int nuevaCantidad)
        {
            // La cantidad debe ser positiva.
            if (nuevaCantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que cero.");

            Cantidad = nuevaCantidad;
        }

        /// <summary>
        /// Calcula el subtotal de este detalle.
        /// </summary>
        public decimal CalcularSubtotal()
        {
            return Subtotal;
        }

        /// <summary>
        /// Devuelve la información del detalle.
        /// </summary>
        public string ObtenerInformacion()
        {
            return $"Producto: {Producto.Nombre} | " +
                   $"Cantidad: {Cantidad} | " +
                   $"Precio unitario: {PrecioUnitario:C} | " +
                   $"Subtotal: {Subtotal:C}";
        }
    }
}
