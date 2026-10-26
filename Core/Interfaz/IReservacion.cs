using Core.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaz
{
    public interface IReservacion<T>
    {
        public DataTable MostrarReservas();
        public DataTable BuscarClave(string codigo);
        public bool ModificarReserva(Reserva reserva);
        public bool CambiarEstadoReserva(string codigoReserva, string nuevoEstado);
    }
}
