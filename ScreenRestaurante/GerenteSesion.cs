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
    public partial class GerenteSesion : Form
    {
        public GerenteSesion()
        {
            InitializeComponent();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Instanciamos el formulario de Ventas
            Ventas ventanaVentas = new Ventas();

            // 2. Lo mostramos en pantalla
            ventanaVentas.Show();
        }

        private void invetarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Instanciamos el formulario de Ventas
            Inventario ventanaInventario = new Inventario();

            // 2. Lo mostramos en pantalla
            ventanaInventario.Show();
        }

        private void consultarReservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_Reservaciónes ResConsulta = new Consultar_Reservaciónes();

            ResConsulta.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Opcional: Preguntar si realmente desea cerrar sesión
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // 2. Si tienes tu formulario de Login (por ejemplo se llama Login o Form1):
                // Login ventanaLogin = new Login();
                // ventanaLogin.Show();

                // 3. Cierra la ventana actual del gerente
                this.Close();

                // Nota: Si este es el formulario principal de la aplicación y al cerrarlo 
                // quieres que se cierre todo el programa, puedes usar Application.Exit();
            }
        }
    }
}