using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Core.Repositorio;

namespace ScreenRestaurante
{
    public partial class Reservaciones : Form
    {
        public Reservaciones()
        {
            InitializeComponent();
        }

        private void Reservaciones_Load(object sender, EventArgs e)
        {
            // Horarios disponibles
            cmdHoraDisponible.DropDownStyle = ComboBoxStyle.DropDownList;

            cmdHoraDisponible.Items.Clear();

            cmdHoraDisponible.Items.AddRange(new object[]
            {
              "13:00",
              "14:00",
              "15:00",
              "16:00",
              "17:00",
               "18:00",
               "19:00",
              "20:00",
               "21:00"
            });

            cmdHoraDisponible.SelectedIndex = -1;

            // Número de personas
            cmdNumeroPersonas.DropDownStyle = ComboBoxStyle.DropDownList;

            cmdNumeroPersonas.Items.Clear();

            cmdNumeroPersonas.Items.AddRange(new object[]
            {
              "1 persona",
              "2 personas",
              "3 personas",
               "4 personas",
               "5 personas",
               "6 personas",
               "7 personas",
               "8 personas"
            });

            cmdNumeroPersonas.SelectedIndex = -1;
        }



        private void btnConfirmarreserva_Click(object sender, EventArgs e)
        {
            try
            {
                //obtenemos los datos escritos por el usuario
                string nombre = txtNombreCompleto.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string nota = txtNota.Text.Trim();

                //comprobamos que se haya elegido una hora
                string textoHoraSeleccionada = cmdHoraDisponible.Text.Trim();
                if (string.IsNullOrWhiteSpace(textoHoraSeleccionada))
                {
                    MessageBox.Show("Por favor, seleccione una hora disponible para la reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                if (cmdNumeroPersonas.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione el número de personas para la reservación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //convertimos la hora seleccionada
                //los horarios del combobox deben usar formatos como "14:30" o "09:00"
                string textoHora = cmdHoraDisponible.SelectedItem.ToString();

                bool horaValida = TimeSpan.TryParseExact(textoHora, new[] { @"hh\:mm" }, CultureInfo.InvariantCulture, out TimeSpan hota);

                if (!horaValida)
                {
                    MessageBox.Show("El horario debe tener formato de 24 horas, por ejemplo 19:00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //obtrenemos la fecha seleccionada y le agregamos la hora
                DateTime fechaHora = dtpFechareserva.Value.Date.Add(hota);

                //obtenemos el numero de personas
                //admite opciones como "4" o "4 personas"
                string textoPersonas = cmdNumeroPersonas.SelectedItem.ToString();
                string primerDato = textoPersonas.Split(' ')[0];

                if (!int.TryParse(primerDato, out int Personas))
                {
                    MessageBox.Show("El número de personas debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //guardamos lo datos y recuperamos el codigo de reserva generado
                var repo = new RepositorioReservas();
                string codigo = repo.RegistrarReserva(nombre, correo, telefono, fechaHora, Personas, nota);

                //informamos que la operacion termino correctamente
                MessageBox.Show("Reservación registrada con éxito!\n\nCódigo de reserva: " + codigo, "reserva confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombreCompleto.Clear();
                txtCorreo.Clear();
                txtTelefono.Clear();
                txtNota.Clear();

                cmdHoraDisponible.SelectedIndex = -1;
                cmdNumeroPersonas.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar la reservación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}