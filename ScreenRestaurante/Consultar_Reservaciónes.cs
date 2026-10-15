using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenRestaurante
{
    public partial class Consultar_Reservaciónes : Form
    {
        public Consultar_Reservaciónes()
        {
            InitializeComponent();
        }

        private void btnConsultarReserva_Click(object sender, EventArgs e)
        {
           string codigo = txtCodigoReserva.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Por favor, ingresa el codigo de reservacion.", "campo vacio",MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCodigoReserva.Focus();
                return;
            }
            
        
        }


    }
}

