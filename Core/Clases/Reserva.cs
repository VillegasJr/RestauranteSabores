using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    public class Reserva
    {
        public int ID_Reserva { get; set; }
        public string Codigo_Reserva { get; set; }
        public int ID_Cliente { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public int Num_Personas { get; set; }
        public string Nota { get; set; }
        public bool Estado { get; set; }
        public string Fecha_Creacion { get; set; }
    }
}
