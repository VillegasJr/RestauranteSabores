using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    public abstract class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;                
        public string Rol { get; set; } = string.Empty;
        public bool Activo { get; set; } = true;
    }
}

