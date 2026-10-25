using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Repositorios;

namespace ScreenRestaurante
{
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPedido.Text, out int pedidoId))
            {
                MessageBox.Show("Por favor, ingresa un número de pedido válido.");
                txtPedido.Focus();
                return;
            }
            try
            {
                RepositorioPedidos repositorio = new RepositorioPedidos();

                DataTable detalle = repositorio.ObtenerDetalleParaCobro(pedidoId);

                if (detalle.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "El pedido no existe o todavía no tiene platillos.");

                    dgvDetallePedido.DataSource = null;
                    lblTotal.Text = "$0.00";
                    return;
                }

                dgvDetallePedido.DataSource = detalle;

                decimal total = 0;

                foreach (DataRow fila in detalle.Rows)
                {
                    total += Convert.ToDecimal(fila["Subtotal"]);
                }

                lblTotal.Text = total.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo consultar el pedido: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
    
}
