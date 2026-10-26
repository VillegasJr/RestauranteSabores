
using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using Core.Repositorios;

namespace ScreenRestaurante
{
    public partial class Pedidos : Form
    {
        private RepositorioPedidos repositorio = new RepositorioPedidos();
        private int idMesero = 1;
        private string categoriaActual = "Platillos";
        private Dictionary<DataGridViewRow, string> comentarios = new Dictionary<DataGridViewRow, string>();

        public Pedidos()
        {
            InitializeComponent();
            ConfigurarColumnas();

            cb_mesas.Items.Clear();
            cb_mesas.Items.AddRange(new object[] { "Mesa 1", "Mesa 2", "Mesa 3", "Mesa 4" });
            cb_mesas.SelectedIndex = 0;

            dgv_platillos.AllowUserToAddRows = false;

            bt_platillos.Click += bt_platillos_Click;
            bt_entradas.Click += bt_entradas_Click;
            bt_bebidas.Click += bt_bebidas_Click;
            bt_postres.Click += bt_postres_Click;
            bt_enviarcocina.Click += bt_enviarcocina_Click;
            bt_quitarplatillo.Click += bt_quitarplatillo_Click;

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

                flp_productos.SuspendLayout();
                flp_productos.FlowDirection = FlowDirection.LeftToRight;
                flp_productos.WrapContents = true;
                flp_productos.AutoScroll = true;

                foreach (DataRow fila in tabla.Rows)
                {
                    Button boton = new Button();
                    boton.Width = 190;
                    boton.Height = 45;
                    boton.Margin = new Padding(5);
                    boton.Tag = new object[]
                    {
                        Convert.ToInt32(fila["id"]),
                        fila["nombre"].ToString(),
                        Convert.ToDecimal(fila["precio"])
                    };

                    boton.Text = fila["nombre"].ToString() + Environment.NewLine +
                        "$" + Convert.ToDecimal(fila["precio"]).ToString("0.00");
                    boton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    boton.Click += producto_Click;

                    flp_productos.Controls.Add(boton);
                }

                flp_productos.ResumeLayout(true);
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

            int indice = dgv_platillos.Rows.Add(datos[0], datos[1], 1, datos[2]);
            comentarios[dgv_platillos.Rows[indice]] = tb_comentarios.Text.Trim();

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
                    if (fila.IsNewRow) continue;

                    int menuId = Convert.ToInt32(fila.Cells["Col_MenuId"].Value);
                    int cantidad = Convert.ToInt32(fila.Cells["colCantidad"].Value);
                    string nota = comentarios.ContainsKey(fila) ? comentarios[fila] : "";

                    repositorio.RegistrarPlatillo(idPedido, menuId, cantidad, nota);
                }

                MessageBox.Show("Pedido enviado a cocina correctamente.");
                dgv_platillos.Rows.Clear();
                comentarios.Clear();
                tb_comentarios.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el pedido: " + ex.Message);
            }
        }

        //boton de quitar platillo del pedido
        private void bt_quitarplatillo_Click(object sender, EventArgs e)
        {
            if (dgv_platillos.CurrentRow == null || dgv_platillos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona el platillo que deseas quitar.");
                return;
            }

            DataGridViewRow fila = dgv_platillos.CurrentRow;
            comentarios.Remove(fila);
            dgv_platillos.Rows.Remove(fila);
        }

        private void ConfigurarColumnas()
        {
            dgv_platillos.Columns.Clear();
            dgv_platillos.AutoGenerateColumns = false;
            dgv_platillos.AllowUserToAddRows = false;

            dgv_platillos.Columns.Add("Col_MenuId", "ID");
            dgv_platillos.Columns["Col_MenuId"].Visible = false;
            dgv_platillos.Columns.Add("colPlatillo", "Platillo");
            dgv_platillos.Columns.Add("colCantidad", "Cantidad");
            dgv_platillos.Columns.Add("colPrecio", "Precio");
        }
    }
}





