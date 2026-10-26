using System;
using System.Windows.Forms;
using Core.Repositorio;


namespace ScreenRestaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        // Se ejecuta cuando el usuario pulsa el botón de iniciar sesión.
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Obtener el usuario y quitar espacios al principio y al final.
            string usuario = txtUsuario.Text.Trim();

            // Obtener la contraseña introducida.
            string contrasena = txtContraseña.Text;

            // Comprobar que ambos campos tengan información.
            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show(
                    "Ingresa tu usuario y contraseña.",
                    "Campos obligatorios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return; // Detener el proceso si falta algún dato.
            }

            // Crear el repositorio que valida las credenciales en MySQL.
            RepositorioUsuarios repositorio =
                new RepositorioUsuarios();

            try
            {
                // Validar las credenciales y recuperar el rol del empleado.
                if (repositorio.ValidarUsuario(
                    usuario, contrasena, out string rol))
                {
                    MessageBox.Show(
                        "¡Bienvenido!",
                        "Acceso autorizado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Normalizar el rol para comparar sin distinguir
                    // entre mayúsculas y minúsculas.
                    switch (rol.Trim().ToUpperInvariant())
                    {
                        case "GERENTE":
                            AbrirVentana(new GerenteSesion());
                            break;

                        case "CHEF":
                        case "COCINERO":
                            AbrirVentana(new Cocinero());
                            break;

                        case "CAJERO":
                            AbrirVentana(new Cajero());
                            break;

                        case "MESERO":
                            AbrirVentana(new Pedidos());
                            break;

                        default:
                            // El usuario existe, pero el rol no está configurado.
                            MessageBox.Show(
                                "Tu usuario es válido, pero el puesto '" +
                                rol + "' no tiene una ventana configurada.",
                                "Puesto no configurado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtContraseña.Clear();
                            txtContraseña.Focus();
                            break;
                    }
                }
                else
                {
                    // Mostrar un error si las credenciales no coinciden.
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
                // Informar si ocurre un error al validar el usuario.
                MessageBox.Show(
                    "No se pudo validar el usuario: " + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Abre la ventana correspondiente y oculta temporalmente el inicio.
        private void AbrirVentana(Form ventana)
        {
            this.Hide();

            try
            {
                // Mostrar la ventana hasta que el usuario la cierre.
                using (ventana)
                {
                    ventana.ShowDialog();
                }
            }
            finally
            {
                // Volver a mostrar el inicio de sesión al cerrar la ventana.
                this.Show();
            }
        }
    }
}
