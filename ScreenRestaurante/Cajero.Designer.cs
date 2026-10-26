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
            this.dgvDetallePedido = new DataGridView();
            txtPedido = new TextBox();
            btnBuscarPedido = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnActualizat = new Button();
            btnCobrar = new Button();
            cmbMetodoPago = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)this.dgvDetallePedido).BeginInit();
            SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Rockwell", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.SaddleBrown;
            label17.Location = new Point(11, 26);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(398, 43);
            label17.TabIndex = 30;
            label17.Text = "CAJERO DE SABORES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 91);
            label1.Name = "label1";
            label1.Size = new Size(214, 30);
            label1.TabIndex = 31;
            label1.Text = "Numero de pedido:";
            // 
            // dgvDetallePedido
            // 
            this.dgvDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallePedido.Location = new Point(23, 152);
            this.dgvDetallePedido.Name = "dgvDetallePedido";
            this.dgvDetallePedido.Size = new Size(502, 274);
            this.dgvDetallePedido.TabIndex = 32;
            // 
            // txtPedido
            // 
            txtPedido.Location = new Point(243, 98);
            txtPedido.Name = "txtPedido";
            txtPedido.Size = new Size(144, 23);
            txtPedido.TabIndex = 33;
            // 
            // btnBuscarPedido
            // 
            btnBuscarPedido.Location = new Point(416, 91);
            btnBuscarPedido.Name = "btnBuscarPedido";
            btnBuscarPedido.Size = new Size(97, 41);
            btnBuscarPedido.TabIndex = 34;
            btnBuscarPedido.Text = "Buscar pedido";
            btnBuscarPedido.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(550, 98);
            label2.Name = "label2";
            label2.Size = new Size(84, 30);
            label2.TabIndex = 35;
            label2.Text = "TOTAL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(640, 98);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 36;
            label3.Text = "$0.00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(550, 164);
            label4.Name = "label4";
            label4.Size = new Size(192, 30);
            label4.TabIndex = 37;
            label4.Text = "Metodo de pago:";
            label4.Click += label4_Click;
            // 
            // btnActualizat
            // 
            btnActualizat.Location = new Point(600, 358);
            btnActualizat.Name = "btnActualizat";
            btnActualizat.Size = new Size(97, 41);
            btnActualizat.TabIndex = 38;
            btnActualizat.Text = "ACTUALIZAR PEDIDO";
            btnActualizat.UseVisualStyleBackColor = true;
            // 
            // btnCobrar
            // 
            btnCobrar.Location = new Point(600, 278);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(97, 41);
            btnCobrar.TabIndex = 39;
            btnCobrar.Text = "COBRAR";
            btnCobrar.UseVisualStyleBackColor = true;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cmbMetodoPago.Location = new Point(590, 214);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(121, 23);
            cmbMetodoPago.TabIndex = 40;
            cmbMetodoPago.SelectedIndexChanged += cmbMetodoPago_SelectedIndexChanged;
            // 
            // Cajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 107, 53);
            ClientSize = new Size(771, 450);
            Controls.Add(cmbMetodoPago);
            Controls.Add(btnCobrar);
            Controls.Add(btnActualizat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBuscarPedido);
            Controls.Add(txtPedido);
            Controls.Add(this.dgvDetallePedido);
            Controls.Add(label1);
            Controls.Add(label17);
            Name = "Cajero";
            Text = "Cajero";
            ((System.ComponentModel.ISupportInitialize)this.dgvDetallePedido).EndInit();
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
        private Label label3;
        private Label label4;
        private Button btnActualizat;
        private Button btnCobrar;
        private ComboBox cmbMetodoPago;
    }
}