using Core.Clases;
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
    public partial class EditarReserva : Form
    {
        // Constructor que recibe los datos de la fila seleccionada
        public EditarReserva(string clave, string nombre, DateTime fecha, string personas, string nota)
        {
            InitializeComponent();

            // 1. Agregamos las opciones que necesites a la lista
            cmbNumeroPersonas.Items.Clear();
            cmbNumeroPersonas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });

            // 2. BLOQUEAMOS la casilla para que NO puedan escribir texto libre (solo seleccionar)
            cmbNumeroPersonas.DropDownStyle = ComboBoxStyle.DropDownList;

            // 3. Rellenamos el resto de los campos con normalidad
            txtClaveReserva.Text = clave;
            txtNombreCompleto.Text = nombre;
            dtpFechaReserva.Value = fecha;
            cmbNumeroPersonas.SelectedItem = personas; // Muestra el valor actual sin borrarlo
            txtNota.Text = nota;

            txtClaveReserva.Enabled = false; // Bloquear la clave
            txtNombreCompleto.Enabled = false;
        }
        public EditarReserva()
        {
            InitializeComponent();

        }

        private void EditarReserva_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarreserva_Click(object sender, EventArgs e)
        {
            try
            {
                // Creamos el objeto Reserva con los datos actualizados del formulario
                Reserva reservaModificada = new Reserva();
                reservaModificada.Codigo_Reserva = txtClaveReserva.Text;
                reservaModificada.Fecha_Hora = dtpFechaReserva.Value;
                reservaModificada.Num_Personas = Convert.ToInt32(cmbNumeroPersonas.Text);
                reservaModificada.Nota = txtNota.Text;

                // Instanciamos el repositorio y ejecutamos la modificación
                RepositorioReservacion repo = new RepositorioReservacion();
                bool resultado = repo.ModificarReserva(reservaModificada);

                if (resultado)
                {
                    MessageBox.Show("¡Reservación actualizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Cierra la ventana de edición al terminar
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la reservación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la reservación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
