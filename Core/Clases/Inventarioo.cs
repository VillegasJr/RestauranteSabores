using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Clases
{
    public class Inventarioo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Stock { get; set; }
        public string Unidad { get; set; }
        public decimal Minimo { get; set; }
    }
}
