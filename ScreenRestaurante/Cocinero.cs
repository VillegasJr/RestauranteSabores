using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenRestaurante
{
    public partial class Cocinero : Form
    {
        public Cocinero()
        {
            InitializeComponent();
            ConfigurarPaneles();
        } 

        private void ConfigurarPaneles()
        {
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;

            panel2.AutoScroll = true;
            panel2.BorderStyle = BorderStyle.FixedSingle;

            panel3.AutoScroll = true;
            panel3.BorderStyle = BorderStyle.FixedSingle;
        }
        private void Mostrarpedido(Panel panel, int idPedido, int numeroMesa, string producto, string estado)
        {
            Panel tarjeta = new Panel();
            tarjeta.Width = panel.ClientSize.Width - 25;
            tarjeta.Height = 100;
            tarjeta.BorderStyle = BorderStyle.FixedSingle;
            tarjeta.BackColor = Color.White;
            tarjeta.Margin = new Padding(5);
        }
    }

    
}

