
using System;
using System.Data;
using System.Windows.Forms;
using Core.Repositorios;

namespace ScreenRestaurante
{
    public partial class Pedidos : Form
    {
        private RepositorioPedidos repositorio = new RepositorioPedidos();
        private int idMesero = 1;
        private string categoriaActual = "Platillos";

        public Pedidos()
        {
            InitializeComponent();

            cb_mesas.Items.Clear();
            cb_mesas.Items.AddRange(new object[] { "Mesa 1", "Mesa 2", "Mesa 3", "Mesa 4" });
            cb_mesas.SelectedIndex = 0;

            dgv_platillos.AllowUserToAddRows = false;

            bt_platillos.Click += bt_platillos_Click;
            bt_entradas.Click += bt_entradas_Click;
            bt_bebidas.Click += bt_bebidas_Click;
            bt_postres.Click += bt_postres_Click;
            bt_enviarcocina.Click += bt_enviarcocina_Click;

            CargarProductos(categoriaActual);
        }

        private void bt_platillos_Click(object sender, EventArgs e)
        {
            CargarProductos("Platillos");
        }

        private void bt_entradas_Click(object sender, EventArgs e)
        {
            CargarProductos("Entradas");
        }

        private void bt_bebidas_Click(object sender, EventArgs e)
        {
            CargarProductos("Bebidas");
        }

        private void bt_postres_Click(object sender, EventArgs e)
        {
            CargarProductos("Postres");
        }

        private void CargarProductos(string categoria)
        {
            try
            {
                categoriaActual = categoria;
                flp_productos.Controls.Clear();

                DataTable tabla = repositorio.ObtenerPlatillos(categoria);

                foreach (DataRow fila in tabla.Rows)
                {
                    Button boton = new Button();
                    boton.Width = 250;
                    boton.Height = 45;
                    boton.Text = fila["nombre"].ToString() + "   $" +
                        Convert.ToDecimal(fila["precio"]).ToString("0.00");

                    boton.Tag = new object[]
                    {
                        Convert.ToInt32(fila["id"]),
                        fila["nombre"].ToString(),
                        Convert.ToDecimal(fila["precio"])
                    };

                    boton.Click += producto_Click;
                    flp_productos.Controls.Add(boton);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void producto_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            object[] datos = (object[])boton.Tag;

            dgv_platillos.Rows.Add(
                datos[0],
                datos[1],
                1,
                datos[2],
                tb_comentarios.Text.Trim()
            );

            tb_comentarios.Clear();
        }

        private void bt_enviarcocina_Click(object sender, EventArgs e)
        {
            if (dgv_platillos.Rows.Count == 0)
            {
                MessageBox.Show("Agrega productos al pedido.");
                return;
            }

            if (cb_mesas.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una mesa.");
                return;
            }

            try
            {
                int idPedido = repositorio.Registrar(cb_mesas.Text, idMesero, "Pendiente");

                foreach (DataGridViewRow fila in dgv_platillos.Rows)
                {
                    repositorio.RegistrarPlatillo(
                        idPedido,
                        Convert.ToInt32(fila.Cells["menu_id"].Value),
                        Convert.ToInt32(fila.Cells["cantidad"].Value),
                        Convert.ToString(fila.Cells["comentario"].Value)
                    );
                }

                MessageBox.Show("Pedido enviado a cocina correctamente.");
                dgv_platillos.Rows.Clear();
                tb_comentarios.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pedido: " + ex.Message);
            }
        }
    }
}




