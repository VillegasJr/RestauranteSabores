using Core.repositorio;
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

        private void CargarReserva()
        {
            try
            {
                RepositorioReservacion repo = new RepositorioReservacion();
                txtInformacionReserva.DataSource = repo.MostrarReservas();

                // Ocultamos la columna del ID para que el usuario no la vea, 
                // pero siga estando disponible en segundo plano.
                txtInformacionReserva.Columns["id_reserva"].Visible = false;
                txtInformacionReserva.Columns["fecha_creacion"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las reservaciónes: " + ex.Message);
            }
        }

        private void Consultar_Reservaciónes_Load(object sender, EventArgs e)
        {
            CargarReserva();

        }

        private void btnConsultarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                RepositorioReservacion repo = new RepositorioReservacion();
                string codigo = txtCodigoReserva.Text.Trim(); // Cambia txtCodigoReserva por el nombre de tu TextBox

                if (string.IsNullOrEmpty(codigo))
                {
                    MessageBox.Show("Por favor, ingresa un código de reservación.");
                    return;
                }

                // Asignamos el resultado al DataGridView
                txtInformacionReserva.DataSource = repo.BuscarClave(codigo);

                // Ocultamos columnas innecesarias si existen
                if (txtInformacionReserva.Columns.Contains("id_reserva"))
                {
                    txtInformacionReserva.Columns["id_reserva"].Visible = false;
                }
                if (txtInformacionReserva.Columns.Contains("fecha_creacion"))
                {
                    txtInformacionReserva.Columns["fecha_creacion"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la reservación: " + ex.Message);
            }
        }

        private void btnEditarReserva_Click(object sender, EventArgs e)
        {
            // Verificamos que el usuario haya seleccionado una fila en la tabla
            if (txtInformacionReserva.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = txtInformacionReserva.SelectedRows[0];

                // Extraemos los valores de las celdas según los títulos de las columnas de tu Grid
                string clave = fila.Cells["Codigo de Reservación"].Value.ToString();
                string nombre = fila.Cells["Cliente"].Value.ToString();
                DateTime fecha = Convert.ToDateTime(fila.Cells["Día de Reservación"].Value);
                string personas = fila.Cells["No. de Personas"].Value.ToString();
                string nota = fila.Cells["Nota"].Value.ToString();

                // Abrimos el formulario EditarReserva pasándole los datos
                EditarReserva ventanaEditar = new EditarReserva(clave, nombre, fecha, personas, nota);
                ventanaEditar.ShowDialog();

                // Opcional: Recargar la tabla después de cerrar la ventana por si hubo cambios
                // btnCosultarReserva_Click(sender, e); 
                CargarReserva();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila de la tabla para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            // Verificamos que haya una fila seleccionada en la tabla
            if (txtInformacionReserva.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = txtInformacionReserva.SelectedRows[0];
                string codigoReserva = fila.Cells["Codigo de Reservación"].Value.ToString();
                string estadoActual = fila.Cells["Estado"].Value.ToString();

                // Preguntamos al usuario para confirmar la acción
                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de cancelar la reservación con código: {codigoReserva}?",
                    "Confirmar cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    RepositorioReservacion repo = new RepositorioReservacion();
                    // Ejecutamos el cambio de estado a CANCELADA en la base de datos
                    bool exito = repo.CambiarEstadoReserva(codigoReserva, "CANCELADA");

                    if (exito)
                    {
                        MessageBox.Show("La reservación ha sido cancelada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargamos la tabla para ver reflejado el cambio de estado de inmediato
                        CargarReserva();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el estado de la reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reservación de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReactivarReserva_Click(object sender, EventArgs e)
        {
            // Verificamos que haya una fila seleccionada en la tabla
            if (txtInformacionReserva.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = txtInformacionReserva.SelectedRows[0];
                string codigoReserva = fila.Cells["Codigo de Reservación"].Value.ToString();
                string estadoActual = fila.Cells["Estado"].Value.ToString();

                // Preguntamos al usuario para confirmar la reactivación
                DialogResult resultado = MessageBox.Show(
                    $"¿Deseas reactivar/confirmar la reservación con código: {codigoReserva}?",
                    "Confirmar reactivación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    RepositorioReservacion repo = new RepositorioReservacion();

                    // Cambiamos el estado a CONFIRMADA (o PENDIENTE, según prefieras)
                    bool exito = repo.CambiarEstadoReserva(codigoReserva, "CONFIRMADA");

                    if (exito)
                    {
                        MessageBox.Show("La reservación ha sido reactivada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargamos la tabla para ver reflejado el cambio de estado de inmediato
                        CargarReserva();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo reactivar la reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una reservación de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

