using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    public abstract class Usuario
    {
        public int IdUsuario { get; protected set; }
        public string Nombre { get; protected set; }
        public string UsuarioAcceso { get; protected set; }
        public bool Activo { get; protected set; }

        protected Usuario(int idUsuario, string nombre, string usuarioAcceso)
        {
            if (idUsuario <= 0)
                throw new ArgumentException("El ID debe ser mayor que cero.");

            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(usuarioAcceso))
                throw new ArgumentException("El usuario de acceso es obligatorio.");

            IdUsuario = idUsuario;
            Nombre = nombre;
            UsuarioAcceso = usuarioAcceso;
            Activo = true;
        }

        public void Activar()
        {
            Activo = true;
        }

        public void Desactivar()
        {
            Activo = false;
        }

        public abstract string ObtenerTipoUsuario();
    }
}
