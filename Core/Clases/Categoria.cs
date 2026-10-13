using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    public class Categoria
    {
        public int IdCategoria { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public bool Activo { get; private set; }

        public Categoria(
            int idCategoria,
            string nombre,
            string descripcion)
        {
            if (idCategoria <= 0)
                throw new ArgumentException(
                    "El ID de la categoría debe ser mayor que cero.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException(
                    "El nombre de la categoría es obligatorio.");

            IdCategoria = idCategoria;
            Nombre = nombre;
            Descripcion = descripcion ?? string.Empty;
            Activo = true;
        }

        public void ActualizarInformacion(
            string nombre,
            string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException(
                    "El nombre de la categoría es obligatorio.");

            Nombre = nombre;
            Descripcion = descripcion ?? string.Empty;
        }

        public void Activar()
        {
            Activo = true;
        }

        public void Desactivar()
        {
            Activo = false;
        }
    }
}

