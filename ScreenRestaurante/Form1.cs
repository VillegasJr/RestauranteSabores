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

namespace ScreenRestaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            

            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContraseña.Text;

            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Ingresa tu usuario y contraseña.");
                return;
            }

            Core.Repositorio.RepositorioUsuarios repositorio =
                new Core.Repositorio.RepositorioUsuarios();

            try
            {
                if (repositorio.ValidarUsuario(
                    usuario, contrasena, out string rol))
                {
                    Form ventana = null;

                    switch (rol.Trim().ToUpper())
                    {
                        case "GERENTE":
                            ventana = new Reservaciones();
                            break;

                        case "COCINERO":
                            ventana = new Cocinero();
                            break;

                        case "CAJERO":
                            ventana = new Cajero();
                            break;

                        case "MESERO":
                            ventana = new Pedidos();
                            break;

                        default:
                            MessageBox.Show(
                                "No hay una pantalla configurada para este puesto.");
                            break;
                    }

                    if (ventana != null)
                    {
                        MessageBox.Show(
                            "¡Bienvenido!",
                            "Acceso autorizado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.Hide();

                        try
                        {
                            using (ventana)
                            {
                                ventana.ShowDialog();
                            }
                        }
                        finally
                        {
                            this.Show();
                            txtContraseña.Clear();
                            txtContraseña.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos.",
                        "Error de acceso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtContraseña.Clear();
                    txtContraseña.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo validar el usuario: " + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
    
}
