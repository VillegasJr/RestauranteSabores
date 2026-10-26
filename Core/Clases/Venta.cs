using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Clases
{
    internal class Venta
    {
        public int IDVenta { get; set; }
        public int Mesa { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public string MetodoPago { get; set; }
        public Empleado IDCajero  { get; set; }
    }
}
