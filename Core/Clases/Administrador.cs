using System;
using System.Collections.Generic;
using System.Text;


namespace Core.Clases
{
    public class Administrador : Empleado
    {
        public Administrador(
            int idUsuario,
            string nombre,
            string usuarioAcceso,
            string telefono)
            : base(
                idUsuario,
                nombre,
                usuarioAcceso,
                "Administrador",
                telefono)
        {
        }

        public override string ObtenerTipoUsuario()
        {
            return "Administrador";
        }

        public override string ObtenerInformacion()
        {
            return base.ObtenerInformacion()
                + " | Acceso administrativo";
        }
    }
}
