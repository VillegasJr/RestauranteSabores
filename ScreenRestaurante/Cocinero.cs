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
            tarjeta.Height = 115;
            tarjeta.BorderStyle = BorderStyle.FixedSingle;
            tarjeta.BackColor = Color.White;
            tarjeta.Margin = new Padding(5);

            Label lblPedido = new Label();
            lblPedido.Text = $"Pedido #{idPedido} - Mesa {numeroMesa}";
            lblPedido.Location = new Point(10, 10);
            lblPedido.AutoSize = true;
            lblPedido.Font = new Font("Arial", 10, FontStyle.Bold);

            Label lblProducto = new Label();
            lblProducto.Text = producto;
            lblProducto.Location = new Point(10, 35);
            lblProducto.AutoSize = true;

            Label lblEstado = new Label();
            lblEstado.Text = estado;
            lblEstado.Location = new Point(10, 60);
            lblEstado.AutoSize = true;

            tarjeta.Controls.Add(lblPedido);
            tarjeta.Controls.Add(lblProducto);
            tarjeta.Controls.Add(lblEstado);

            Button btnCambiarEstado = new Button();
            btnCambiarEstado.Width = 125;
            btnCambiarEstado.Height = 28;
            btnCambiarEstado.Location = new Point(10, 75);
            btnCambiarEstado.Font = new Font("Arial", 8, FontStyle.Bold);

            if (estado == "Pendiente")
            {
                btnCambiarEstado.Text = "Comenzar";
            }
            else if (estado == "En preparación")
            {
                btnCambiarEstado.Text = "Marcar como listo";
            }
            else
            {
                btnCambiarEstado.Text = "Terminado";
                btnCambiarEstado.Enabled = false;
            }

            btnCambiarEstado.Click += (sender, e) =>
            {
                string nuevoEstado = "";

                if (estado == "Pendiente")
                    nuevoEstado = "En preparación";
                else if (estado == "En preparación")
                    nuevoEstado = "Listo";
                else
                    return;

                try
                {
                    RepositorioCocina repositorio = new RepositorioCocina();

                    bool actualizado = repositorio.CambiarEstado(
                        idPedido, nuevoEstado);

                    if (actualizado)
                    {
                        MessageBox.Show(
                            $"Pedido #{idPedido}: {nuevoEstado}");

                        CargarPedidos();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se encontró el pedido para actualizar.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "No se pudo cambiar el estado: " + ex.Message);
                }
            };

            tarjeta.Controls.Add(btnCambiarEstado);
            tarjeta.Margin = new Padding(5);
            tarjeta.Dock = DockStyle.Top;

            panel.Controls.Add(tarjeta);
            tarjeta.BringToFront();
        }

        private void CargarPedidos()
        {
            try
            {
                // Limpiar las tarjetas anteriores.
                panel1.Controls.Clear();
                panel2.Controls.Clear();
                panel3.Controls.Clear();

                RepositorioCocina repositorio = new RepositorioCocina();

                // Cargar pedidos según su estado.
                CargarPanel(panel1, repositorio, "Pendiente");
                CargarPanel(panel2, repositorio, "En preparación");
                CargarPanel(panel3, repositorio, "Listo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los pedidos: " + ex.Message,
                    "Error de cocina",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarPanel(
            Panel panel,
            RepositorioCocina repositorio,
            string estado)
        {
            DataTable pedidos = repositorio.ObtenerPedidosPorEstado(estado);

            foreach (DataRow fila in pedidos.Rows)
            {
                int idPedido = Convert.ToInt32(fila["IdPedido"]);

                string mesaTexto = fila["Mesa"].ToString();
                string producto = fila["Platillos"].ToString();

                // Extraer el número de la mesa si está guardado como "Mesa 2".
                string numeroTexto = mesaTexto.Replace("Mesa", "").Trim();

                int numeroMesa = 0;
                int.TryParse(numeroTexto, out numeroMesa);

                Mostrarpedido(
                    panel,
                    idPedido,
                    numeroMesa,
                    producto,
                    estado);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarPedidos();
        }
    }
}