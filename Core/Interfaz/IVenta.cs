using Core.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaz
{
    internal interface IVenta
    {
        public DataTable VentaDelDia();

        public decimal VentaTotalDia();
    }
}
