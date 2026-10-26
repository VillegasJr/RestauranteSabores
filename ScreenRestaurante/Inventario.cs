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
    public partial class Inventario : Form
    {
        private int idProductoSeleccionado = 0;
        public Inventario()
        {
            InitializeComponent();
        }

        private void ActualizarContadores()
        {
            try
            {
                RepositorioInventario repo = new RepositorioInventario();

                // Asignamos los valores obtenidos de la base de datos a los textos de tus Labels
                label3.Text = repo.TotalInventario().ToString();
                label5.Text = repo.StockBajo().ToString();
                label7.Text = repo.StockCritico().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar contadores: " + ex.Message);
            }
        }

        private void Agregar_Pd_Click(object sender, EventArgs e)
        {
            // --- 1. VALIDACIÓN DE LOS COMBOBOX ---
            if (Categoria_Pd.SelectedIndex == 0 || Categoria_Pd.Text == "Selecciona una categoría...")
            {
                MessageBox.Show("Por favor, selecciona una categoría válida.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene el proceso
            }

            if (Unidad_Pd.SelectedIndex == 0 || Unidad_Pd.Text == "Selecciona una unidad...")
            {
                MessageBox.Show("Por favor, selecciona una unidad válida.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene el proceso
            }

            // --- 2. TUS VARIABLES EXISTENTES ---
            string nombre = Nombre_Pd.Text;
            string categoria = Categoria_Pd.Text;
            decimal stock = Convert.ToDecimal(Stock_Pd.Text);
            string unidad = Unidad_Pd.Text;
            decimal minimo = Convert.ToDecimal(Minimo_Pd.Text);

            if (nombre == "" || stock == 0 || minimo == 0)
            {
                MessageBox.Show("Obligatoria rellenar todos los campos.",
                "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RepositorioInventario repoInventario = new RepositorioInventario();

                Inventarioo inventario = new Inventarioo();
                inventario.Nombre = nombre;
                inventario.Categoria = categoria;
                inventario.Stock = stock;
                inventario.Unidad = unidad;
                inventario.Minimo = minimo;

                repoInventario.AgregarInventario(inventario);

                MessageBox.Show("Articulo registrado correctamente.");

                Nombre_Pd.Clear();
                Stock_Pd.Clear();
                Minimo_Pd.Clear();
                Categoria_Pd.SelectedIndex = 0;
                Unidad_Pd.SelectedIndex = 0;

                CargarInventario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar alumno: " + ex.Message);
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CargarInventario();

            // --- ComboBox de Categoría ---
            Categoria_Pd.Items.Add("Selecciona categoría");
            Categoria_Pd.Items.Add("Chiles");
            Categoria_Pd.Items.Add("Verduras");
            Categoria_Pd.Items.Add("Carnes");
            Categoria_Pd.Items.Add("Lácteos");
            Categoria_Pd.Items.Add("Frutos");
            Categoria_Pd.Items.Add("Granos");
            Categoria_Pd.Items.Add("Aceites");
            Categoria_Pd.Items.Add("Frutas");

            // Selecciona el texto predeterminado para que aparezca al abrir el formulario
            Categoria_Pd.SelectedIndex = 0;


            // --- ComboBox de Unidad ---
            Unidad_Pd.Items.Add("Selecciona unidad");
            Unidad_Pd.Items.Add("kg");
            Unidad_Pd.Items.Add("lt");
            Unidad_Pd.Items.Add("pza");

            // Selecciona el texto predeterminado
            Unidad_Pd.SelectedIndex = 0;
        }
        private void CargarInventario()
        {
            try
            {
                RepositorioInventario repo = new RepositorioInventario();
                dataGridView1.DataSource = repo.InventarioInfo();

                // Ocultamos la columna del ID para que el usuario no la vea, 
                // pero siga estando disponible en segundo plano.
                dataGridView1.Columns["id"].Visible = false;

                // Llamamos a los contadores aquí para que se refresquen siempre que se recargue la tabla
                ActualizarContadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas del día: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                // Opción segura por índice de columna (0 es la primera columna, asegúrate que ahí esté tu ID)
                idProductoSeleccionado = Convert.ToInt32(fila.Cells["id"].Value);

                Nombre_Pd.Text = fila.Cells["Nombre"].Value.ToString();
                Categoria_Pd.Text = fila.Cells["Categoria"].Value.ToString();
                Stock_Pd.Text = fila.Cells["Stock"].Value.ToString();
                Unidad_Pd.Text = fila.Cells["Unidad"].Value.ToString();
                Minimo_Pd.Text = fila.Cells["Minimo"].Value.ToString();
            }
        }

        private void Actualizar_Pd_Click(object sender, EventArgs e)
        {
            // 1. Validar que se haya seleccionado un producto de la tabla
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto de la tabla para modificar.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar ComboBox y campos vacíos (igual que en agregar)
            if (Categoria_Pd.SelectedIndex == 0 || Categoria_Pd.Text == "Selecciona una categoría...")
            {
                MessageBox.Show("Por favor, selecciona una categoría válida.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Unidad_Pd.SelectedIndex == 0 || Unidad_Pd.Text == "Selecciona una unidad...")
            {
                MessageBox.Show("Por favor, selecciona una unidad válida.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(Nombre_Pd.Text) || string.IsNullOrEmpty(Stock_Pd.Text) || string.IsNullOrEmpty(Minimo_Pd.Text))
            {
                MessageBox.Show("Es obligatorio rellenar todos los campos.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RepositorioInventario repoInventario = new RepositorioInventario();
                Inventarioo inventario = new Inventarioo();

                inventario.ID = idProductoSeleccionado;
                inventario.Nombre = Nombre_Pd.Text;
                inventario.Categoria = Categoria_Pd.Text;
                inventario.Stock = Convert.ToDecimal(Stock_Pd.Text);
                inventario.Unidad = Unidad_Pd.Text;
                inventario.Minimo = Convert.ToDecimal(Minimo_Pd.Text);

                // 4. Llamar al método de actualización
                repoInventario.ActualizarInventario(inventario);

                MessageBox.Show("¡Producto modificado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 5. Limpiar campos, refrescar la tabla y reiniciar el ID seleccionado
                Nombre_Pd.Clear();
                Stock_Pd.Clear();
                Minimo_Pd.Clear();
                Categoria_Pd.SelectedIndex = 0;
                Unidad_Pd.SelectedIndex = 0;
                idProductoSeleccionado = 0;

                CargarInventario(); // Método para recargar tu DataGridView y ver los cambios reflejados
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar_Pd_Click(object sender, EventArgs e)
        {
            // 1. Validar que se haya seleccionado un producto de la tabla
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto de la tabla para eliminar.", "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Pedir confirmación antes de eliminar (¡Muy importante para evitar borrados accidentales!)
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    // 3. Crear instancias y asignar el ID a eliminar
                    RepositorioInventario repoInventario = new RepositorioInventario();
                    Inventarioo inventario = new Inventarioo();

                    inventario.ID = idProductoSeleccionado;

                    // 4. Ejecutar el método de eliminación
                    repoInventario.ElimiarProducto(inventario);

                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 5. Limpiar campos, reiniciar el ID seleccionado y refrescar el DataGridView
                    Nombre_Pd.Clear();
                    Stock_Pd.Clear();
                    Minimo_Pd.Clear();
                    Categoria_Pd.SelectedIndex = 0;
                    Unidad_Pd.SelectedIndex = 0;
                    idProductoSeleccionado = 0;

                    CargarInventario(); // Recarga la tabla para que desaparezca el producto borrado
                }
                 catch (Exception ex) // O catch normal dependiendo de tu versión
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
