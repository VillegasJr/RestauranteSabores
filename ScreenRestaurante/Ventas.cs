using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.Repositorio;
using MySql.Data.MySqlClient;

namespace ScreenRestaurante
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();

            // Instancia o llama a tu repositorio de ventas (dependiendo de cómo manejes la inyección o instanciación)
            RepositorioVentas repoVentas = new RepositorioVentas();

            // Obtienes el total y lo formateas como moneda
            decimal total = repoVentas.VentaTotalDia();
            TotalDia.Text = total.ToString("C2"); // El formato "C2" agrega automáticamente el símbolo de moneda y dos decimales
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            CargarHistorialDelDia();
        }

        private void CargarHistorialDelDia()
        {
            try
            {
                RepositorioVentas repo = new RepositorioVentas();
                dataGridView1.DataSource = repo.VentaDelDia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las ventas del día: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Muestra la fecha y la hora actual formateada
            FechaDia.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss - tt");
        }
    }
}
