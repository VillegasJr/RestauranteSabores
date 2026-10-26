using Core.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaz
{
    public interface IInventario<T>
    {
        public bool AgregarInventario(Inventarioo inventario);
        public bool ActualizarInventario(Inventarioo inventario);
        public bool ElimiarProducto(Inventarioo inteventario);
        public DataTable InventarioInfo();
        public int TotalInventario();
        public int StockBajo();
        public int StockCritico();
    }
}
