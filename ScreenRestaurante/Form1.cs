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
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == "Gerente" && contraseña == "2026Gerente")
            {
                MessageBox.Show(
                    "¡Bienvenido, Gerente!",
                    "Acceso autorizado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

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
                    "Usuario o contraseña incorrectos.",
                    "Error de acceso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtContraseña.Clear();
                txtContraseña.Focus();
            }
        }
    }
}
