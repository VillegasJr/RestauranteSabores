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
            string contrasena = txtContrase�a.Text;

            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Ingresa tu usuario y contrase�a.");
                return;
            }

            Core.Repositorio.RepositorioUsuarios repositorio =
                new Core.Repositorio.RepositorioUsuarios();

            try
            {
                if (repositorio.ValidarUsuario(
                    usuario, contrasena, out string rol))
                {
                    MessageBox.Show(
                        "�Bienvenido!",
                        "Acceso autorizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    if (rol == "GERENTE")
                    {
                        this.Hide();

                        using (Reservaciones ventana = new Reservaciones())
                        {
                            ventana.ShowDialog();
                        }

                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Tu usuario es v�lido, pero todav�a falta configurar la pantalla de tu puesto.");

                        txtContrase�a.Clear();
                        txtContrase�a.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Usuario o contrase�a incorrectos.",
                        "Error de acceso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtContrase�a.Clear();
                    txtContrase�a.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo validar el usuario: " + ex.Message,
                    "Error de conexi�n",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
