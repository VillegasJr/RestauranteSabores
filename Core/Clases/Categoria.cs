using System;
using System.Collections.Generic;
using System.Text;


namespace Core.Clases
{
    /// Representa una categoría del menú del restaurante.
    public class Categoria
    {
        public int IdCategoria { get; private set; }
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public bool Activo { get; private set; }

        /// Crea una categoría con su nombre y descripción.
        public Categoria(int idCategoria,string nombre,string descripcion)
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

       
        /// Permite actualizar el nombre y la descripción.
        
        public void ActualizarInformacion(
            string nombre,
            string descripcion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la categoría es obligatorio.");

            Nombre = nombre;
            Descripcion = descripcion ?? string.Empty;
        }

        /// Activa la categoría.
        public void Activar()
        {
            Activo = true;
        }

        /// Desactiva la categoría sin eliminarla.
        public void Desactivar()
        {
            Activo = false;
        }
    }
}
