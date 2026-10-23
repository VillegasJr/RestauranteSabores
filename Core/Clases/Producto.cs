using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    /// Representa un producto que se ofrece en el menú.
    public class Producto
    {
        public int IdProducto { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public decimal Precio { get; private set; }
        public Categoria Categoria { get; private set; }
        public bool Activo { get; private set; }

        /// Crea un producto y valida sus datos.
        public Producto(int idProducto,string nombre,string descripcion,decimal precio,Categoria categoria)
        {
            // Validamos el identificador.
            if (idProducto <= 0)
                throw new ArgumentException("El ID del producto debe ser mayor que cero.");

            // El nombre es obligatorio.
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del producto es obligatorio.");

            // El precio debe ser positivo.
            if (precio <= 0)
                throw new ArgumentException("El precio debe ser mayor que cero.");

            // Todo producto debe pertenecer a una categoría válida.
            if (categoria == null)
                throw new ArgumentException("El producto debe tener una categoría.");

            if (!categoria.Activo)
                throw new ArgumentException("No se puede asignar una categoría inactiva.");

            // Guardamos la información del producto.
            IdProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion ?? string.Empty;
            Precio = precio;
            Categoria = categoria;

            // Un producto nuevo comienza activo.
            Activo = true;
        }

        /// Cambia el precio del producto.
        public void CambiarPrecio(decimal nuevoPrecio)
        {
            if (nuevoPrecio <= 0)
                throw new ArgumentException(
                    "El precio debe ser mayor que cero.");

            Precio = nuevoPrecio;
        }

        /// Asigna una nueva categoría al producto.
        public void CambiarCategoria(Categoria nuevaCategoria)
        {
            if (nuevaCategoria == null)
                throw new ArgumentException("La categoría no puede estar vacía.");

            if (!nuevaCategoria.Activo)
                throw new ArgumentException("No se puede asignar una categoría inactiva.");

            Categoria = nuevaCategoria;
        }

        /// Actualiza el nombre y la descripción.
        public void ActualizarInformacion(
            string nombre,
            string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del producto es obligatorio.");

            Nombre = nombre;
            Descripcion = descripcion ?? string.Empty;
        }

        /// Activa el producto si su categoría está activa.
        public void Activar()
        {
            if (!Categoria.Activo)
                throw new InvalidOperationException("No se puede activar un producto cuya categoría está inactiva.");

            Activo = true;
        }

        /// Desactiva el producto sin eliminarlo.
        public void Desactivar()
        {
            Activo = false;
        }
    }
}

