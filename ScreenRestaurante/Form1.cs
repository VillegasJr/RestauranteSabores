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
            string contrase�a = txtContrase�a.Text;

            if (usuario == "Gerente" && contrase�a == "2026Gerente")
            {
                MessageBox.Show(
                    "�Bienvenido, Gerente!",
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
                    "Usuario o contrase�a incorrectos.",
                    "Error de acceso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtContrase�a.Clear();
                txtContrase�a.Focus();
            }
        }
    }
}
