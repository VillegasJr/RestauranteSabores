namespace ScreenRestaurante
{
    partial class Cajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label17 = new Label();
            label1 = new Label();
            dgvDetallePedido = new DataGridView();
            txtPedido = new TextBox();
            btnBuscarPedido = new Button();
            label2 = new Label();
            lblTotal = new Label();
            label4 = new Label();
            btnActualizat = new Button();
            btnCobrar = new Button();
            cmbMetodoPago = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).BeginInit();
            SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Rockwell", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.SaddleBrown;
            label17.Location = new Point(13, 35);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(498, 54);
            label17.TabIndex = 30;
            label17.Text = "CAJERO DE SABORES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 121);
            label1.Name = "label1";
            label1.Size = new Size(272, 38);
            label1.TabIndex = 31;
            label1.Text = "Numero de pedido:";
            // 
            // dgvDetallePedido
            // 
            dgvDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePedido.Location = new Point(26, 203);
            dgvDetallePedido.Margin = new Padding(3, 4, 3, 4);
            dgvDetallePedido.Name = "dgvDetallePedido";
            dgvDetallePedido.RowHeadersWidth = 51;
            dgvDetallePedido.Size = new Size(574, 365);
            dgvDetallePedido.TabIndex = 32;
            // 
            // txtPedido
            // 
            txtPedido.Location = new Point(278, 131);
            txtPedido.Margin = new Padding(3, 4, 3, 4);
            txtPedido.Name = "txtPedido";
            txtPedido.Size = new Size(164, 27);
            txtPedido.TabIndex = 33;
            // 
            // btnBuscarPedido
            // 
            btnBuscarPedido.Location = new Point(475, 121);
            btnBuscarPedido.Margin = new Padding(3, 4, 3, 4);
            btnBuscarPedido.Name = "btnBuscarPedido";
            btnBuscarPedido.Size = new Size(111, 55);
            btnBuscarPedido.TabIndex = 34;
            btnBuscarPedido.Text = "Buscar pedido";
            btnBuscarPedido.UseVisualStyleBackColor = true;
            btnBuscarPedido.Click += btnBuscarPedido_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(629, 131);
            label2.Name = "label2";
            label2.Size = new Size(108, 38);
            label2.TabIndex = 35;
            label2.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.White;
            lblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(731, 131);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(89, 38);
            lblTotal.TabIndex = 36;
            lblTotal.Text = "$0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(629, 219);
            label4.Name = "label4";
            label4.Size = new Size(243, 38);
            label4.TabIndex = 37;
            label4.Text = "Metodo de pago:";
            label4.Click += label4_Click;
            // 
            // btnActualizat
            // 
            btnActualizat.Location = new Point(686, 477);
            btnActualizat.Margin = new Padding(3, 4, 3, 4);
            btnActualizat.Name = "btnActualizat";
            btnActualizat.Size = new Size(111, 55);
            btnActualizat.TabIndex = 38;
            btnActualizat.Text = "ACTUALIZAR PEDIDO";
            btnActualizat.UseVisualStyleBackColor = true;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(686, 371);
            btnCobrar.Margin = new Padding(3, 4, 3, 4);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(111, 55);
            btnCobrar.TabIndex = 39;
            btnCobrar.Text = "COBRAR";
            btnCobrar.UseVisualStyleBackColor = true;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cmbMetodoPago.Location = new Point(674, 285);
            cmbMetodoPago.Margin = new Padding(3, 4, 3, 4);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(138, 28);
            cmbMetodoPago.TabIndex = 40;
            cmbMetodoPago.SelectedIndexChanged += cmbMetodoPago_SelectedIndexChanged;
            // 
            // Cajero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 107, 53);
            ClientSize = new Size(881, 600);
            Controls.Add(cmbMetodoPago);
            Controls.Add(btnCobrar);
            Controls.Add(btnActualizat);
            Controls.Add(label4);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(btnBuscarPedido);
            Controls.Add(txtPedido);
            Controls.Add(dgvDetallePedido);
            Controls.Add(label1);
            Controls.Add(label17);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cajero";
            Text = "Cajero";
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label17;
        private Label label1;
        private DataGridView dgvDetallePedido;
        private DataGridView dataGridView1;
        private TextBox txtPedido;
        private Button btnBuscarPedido;
        private Label label2;
        private Label lblTotal;
        private Label label4;
        private Button btnActualizat;
        private Button btnCobrar;
        private ComboBox cmbMetodoPago;
    }
}