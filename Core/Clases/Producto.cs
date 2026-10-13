using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    public class Producto
    {
        public int IdProducto { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public decimal Precio { get; private set; }
        public Categoria Categoria { get; private set; }
        public bool Activo { get; private set; }

        public Producto(
            int idProducto,
            string nombre,
            string descripcion,
            decimal precio,
            Categoria categoria)
        {
            if (idProducto <= 0)
                throw new ArgumentException(
                    "El ID del producto debe ser mayor que cero.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException(
                    "El nombre del producto es obligatorio.");

            if (precio <= 0)
                throw new ArgumentException(
                    "El precio debe ser mayor que cero.");

            if (categoria == null)
                throw new ArgumentNullException(
                    nameof(categoria),
                    "El producto debe tener una categoría.");

            if (!categoria.Activo)
                throw new ArgumentException(
                    "No se puede asignar una categoría inactiva.");

            IdProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion ?? string.Empty;
            Precio = precio;
            Categoria = categoria;
            Activo = true;
        }

        public void CambiarPrecio(decimal nuevoPrecio)
        {
            if (nuevoPrecio <= 0)
                throw new ArgumentException(
                    "El precio debe ser mayor que cero.");

            Precio = nuevoPrecio;
        }

        public void CambiarCategoria(Categoria nuevaCategoria)
        {
            if (nuevaCategoria == null)
                throw new ArgumentNullException(
                    nameof(nuevaCategoria));

            if (!nuevaCategoria.Activo)
                throw new ArgumentException(
                    "La categoría debe estar activa.");

            Categoria = nuevaCategoria;
        }

        public void ActualizarInformacion(
            string nombre,
            string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException(
                    "El nombre del producto es obligatorio.");

            Nombre = nombre;
            Descripcion = descripcion ?? string.Empty;
        }

        public void Activar()
        {
            if (!Categoria.Activo)
                throw new InvalidOperationException(
                    "No se puede activar un producto con categoría inactiva.");

            Activo = true;
        }

        public void Desactivar()
        {
            Activo = false;
        }
    }
}

