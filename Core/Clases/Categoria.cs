using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    /// <summary>
    /// Representa una categoría del menú del restaurante.
    /// </summary>
    public class Categoria
    {
        public int IdCategoria { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public bool Activo { get; private set; }

        /// <summary>
        /// Crea una categoría con su nombre y descripción.
        /// </summary>
        public Categoria(int idCategoria, string nombre, string descripcion)
        {
            // Validamos el identificador.
            if (idCategoria <= 0)
                throw new ArgumentException("El ID de la categoría debe ser mayor que cero.");

            // El nombre es obligatorio.
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la categoría es obligatorio.");

            // Guardamos la información recibida.
            IdCategoria = idCategoria;
            Nombre = nombre;
            Descripcion = descripcion ?? string.Empty;

            // Una categoría nueva comienza activa.
            Activo = true;
        }

        /// <summary>
        /// Permite actualizar el nombre y la descripción.
        /// </summary>
        public void ActualizarInformacion(
            string nombre,
            string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la categoría es obligatorio.");

            Nombre = nombre;
            Descripcion = descripcion ?? string.Empty;
        }

        /// <summary>
        /// Activa la categoría.
        /// </summary>
        public void Activar()
        {
            Activo = true;
        }

        /// <summary>
        /// Desactiva la categoría sin eliminarla.
        /// </summary>
        public void Desactivar()
        {
            Activo = false;
        }
    }
}
