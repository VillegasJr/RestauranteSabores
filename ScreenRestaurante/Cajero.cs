using Core.Repositorio;
using Core.Repositorios;
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

            // Configurar las mesas disponibles.
            cmbMesa.Items.Clear();
            cmbMesa.Items.AddRange(new object[]
            {
                "Mesa 1",
                "Mesa 2",
                "Mesa 3",
                "Mesa 4"
            });

            cmbMesa.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // No seleccionar una mesa automáticamente.
            cmbMesa.SelectedIndex = -1;

            // Consultar cuando se seleccione una mesa.
            cmbMesa.SelectedIndexChanged +=
                cmbMesa_SelectedIndexChanged;
        }

        // Busca automáticamente el pedido de la mesa.
        private void cmbMesa_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            CargarPedidoDeMesa();
        }

        private void CargarPedidoDeMesa()
        {
            if (cmbMesa.SelectedItem == null)
                return;

            try
            {
                RepositorioPedidos repositorio =
                    new RepositorioPedidos();

                DataTable pedidos =
                    repositorio.ObtenerPedidosPendientesDeCobro(
                        cmbMesa.SelectedItem.ToString());

                // Limpiar los datos anteriores.
                txtPedido.Clear();
                dgvDetallePedido.DataSource = null;
                lblTotal.Text = "$0.00";

                if (pedidos.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Esta mesa no tiene pedidos listos " +
                        "pendientes de cobro.");

                    return;
                }

                if (pedidos.Rows.Count > 1)
                {
                    MessageBox.Show(
                        "Esta mesa tiene varios pedidos pendientes " +
                        "de cobro. Debemos seleccionar uno para " +
                        "no mezclar las cuentas.");

                    return;
                }

                int pedidoId = Convert.ToInt32(
                    pedidos.Rows[0]["IdPedido"]);

                txtPedido.Text = pedidoId.ToString();

                CargarDetallePedido(pedidoId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo consultar la mesa:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Consulta los platillos y calcula su subtotal.
        private void CargarDetallePedido(int pedidoId)
        {
            try
            {
                RepositorioPedidos repositorio =
                    new RepositorioPedidos();

                DataTable detalle =
                    repositorio.ObtenerDetalleParaCobro(
                        pedidoId);

                if (detalle.Rows.Count == 0)
                {
                    dgvDetallePedido.DataSource = null;
                    lblTotal.Text = "$0.00";

                    MessageBox.Show(
                        "El pedido no existe o no tiene platillos.");

                    return;
                }

                dgvDetallePedido.DataSource = detalle;

                decimal subtotal = 0;

                foreach (DataRow fila in detalle.Rows)
                {
                    subtotal += Convert.ToDecimal(
                        fila["Subtotal"]);
                }

                lblTotal.Text = subtotal.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron consultar los platillos:\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Permite buscar manualmente un pedido por su número.
        private void btnBuscarPedido_Click(
            object sender, EventArgs e)
        {
            if (!int.TryParse(txtPedido.Text, out int pedidoId)
                || pedidoId <= 0)
            {
                MessageBox.Show(
                    "Ingresa un número de pedido válido.");

                txtPedido.Focus();
                return;
            }

            CargarDetallePedido(pedidoId);
        }

        // Registra el cobro de un pedido.
        private void btnCobrar_Click(
            object sender, EventArgs e)
        {
            if (!int.TryParse(txtPedido.Text, out int pedidoId)
                || pedidoId <= 0)
            {
                MessageBox.Show(
                    "Selecciona una mesa o busca un pedido válido.");

                return;
            }

            if (dgvDetallePedido.DataSource == null ||
                dgvDetallePedido.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Primero debes cargar un pedido con platillos.");

                return;
            }

            if (cmbMetodoPago.SelectedItem == null)
            {
                MessageBox.Show(
                    "Selecciona un método de pago.");

                cmbMetodoPago.Focus();
                return;
            }

            try
            {
                string mesa;

                using (var conexion =
                    Core.Data.Conexion.CrearConexion())
                {
                    conexion.Open();

                    using (var comando =
                        new MySql.Data.MySqlClient.MySqlCommand(
                            "SELECT mesa FROM pedidos WHERE id = @id",
                            conexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@id", pedidoId);

                        object resultado =
                            comando.ExecuteScalar();

                        if (resultado == null ||
                            resultado == DBNull.Value)
                        {
                            MessageBox.Show(
                                "No se encontró el pedido.");

                            return;
                        }

                        mesa = resultado.ToString();
                    }
                }

                decimal subtotal = 0;

                foreach (DataGridViewRow fila
                    in dgvDetallePedido.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    subtotal += Convert.ToDecimal(
                        fila.Cells["Subtotal"].Value);
                }

                // Tasa provisional del 16 %.
                decimal iva = Math.Round(
                    subtotal * 0.16m, 2);

                decimal total = subtotal + iva;

                // TODO: usar el ID real del cajero autenticado.
                int cajeroId = 1;

                RepositorioVentas repositorioVentas =
                    new RepositorioVentas();

                int ventaId =
                    repositorioVentas.RegistrarVenta(
                        pedidoId,
                        mesa,
                        cajeroId,
                        cmbMetodoPago.SelectedItem.ToString(),
                        subtotal,
                        iva,
                        total);

                MessageBox.Show(
                    $"¡Cobro registrado correctamente!\n\n" +
                    $"Venta: #{ventaId}\n" +
                    $"Mesa: {mesa}\n" +
                    $"Subtotal: {subtotal:C2}\n" +
                    $"IVA: {iva:C2}\n" +
                    $"Total: {total:C2}",
                    "Cobro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                dgvDetallePedido.DataSource = null;
                txtPedido.Clear();
                lblTotal.Text = "$0.00";
                cmbMetodoPago.SelectedIndex = -1;
                cmbMesa.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo registrar el cobro:\n" +
                    ex.Message,
                    "Error de cobro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

