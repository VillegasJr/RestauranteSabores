using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    public class Cocinero : Empleado
    {
        public string Especialidad { get; private set; }

        public Cocinero(
            int idUsuario,
            string nombre,
            string usuarioAcceso,
            string telefono,
            string especialidad)
            : base(
                idUsuario,
                nombre,
                usuarioAcceso,
                "Cocinero",
                telefono)
        {
            if (string.IsNullOrWhiteSpace(especialidad))
                throw new ArgumentException(
                    "La especialidad es obligatoria.");

            Especialidad = especialidad;
        }

        public override string ObtenerTipoUsuario()
        {
            return "Cocinero";
        }

        public override string ObtenerInformacion()
        {
            return base.ObtenerInformacion()
                + $" | Especialidad: {Especialidad}";
        }
    }
}

