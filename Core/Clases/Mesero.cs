using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    public class Mesero : Empleado
    {
        public string ZonaAtencion { get; private set; }

        public Mesero(
            int idUsuario,
            string nombre,
            string usuarioAcceso,
            string telefono,
            string zonaAtencion)
            : base(
                idUsuario,
                nombre,
                usuarioAcceso,
                "Mesero",
                telefono)
        {
            if (string.IsNullOrWhiteSpace(zonaAtencion))
                throw new ArgumentException(
                    "La zona de atención es obligatoria.");

            ZonaAtencion = zonaAtencion;
        }

        public override string ObtenerTipoUsuario()
        {
            return "Mesero";
        }

        public override string ObtenerInformacion()
        {
            return base.ObtenerInformacion()
                + $" | Zona de atención: {ZonaAtencion}";
        }
    }
}

