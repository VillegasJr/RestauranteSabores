namespace ScreenRestaurante
{
    partial class Pedidos
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
            dgv_platillos = new DataGridView();
            Col_Platillo = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colComentario = new DataGridViewTextBoxColumn();
            pnl_platillos = new Panel();
            lb_pedidomesa = new Label();
            lb_comentarios = new Label();
            tb_comentarios = new TextBox();
            bt_enviarcocina = new Button();
            cb_mesas = new ComboBox();
            label1 = new Label();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_platillos).BeginInit();
            SuspendLayout();
            // 
            // dgv_platillos
            // 
            dgv_platillos.AllowUserToAddRows = false;
            dgv_platillos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_platillos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_platillos.Columns.AddRange(new DataGridViewColumn[] { Col_Platillo, colCantidad, colPrecio, colComentario });
            dgv_platillos.GridColor = Color.FromArgb(255, 249, 244);
            dgv_platillos.Location = new Point(18, 129);
            dgv_platillos.MultiSelect = false;
            dgv_platillos.Name = "dgv_platillos";
            dgv_platillos.ReadOnly = true;
            dgv_platillos.RowHeadersWidth = 51;
            dgv_platillos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_platillos.Size = new Size(520, 500);
            dgv_platillos.TabIndex = 0;
            // 
            // Col_Platillo
            // 
            Col_Platillo.HeaderText = "Platillo";
            Col_Platillo.MinimumWidth = 6;
            Col_Platillo.Name = "Col_Platillo";
            Col_Platillo.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.MinimumWidth = 6;
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colComentario
            // 
            colComentario.HeaderText = "Comentario";
            colComentario.MinimumWidth = 6;
            colComentario.Name = "colComentario";
            colComentario.ReadOnly = true;
            // 
            // pnl_platillos
            // 
            pnl_platillos.Location = new Point(645, 129);
            pnl_platillos.Name = "pnl_platillos";
            pnl_platillos.Size = new Size(525, 500);
            pnl_platillos.TabIndex = 1;
            // 
            // lb_pedidomesa
            // 
            lb_pedidomesa.AutoSize = true;
            lb_pedidomesa.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_pedidomesa.Location = new Point(645, 88);
            lb_pedidomesa.Name = "lb_pedidomesa";
            lb_pedidomesa.Size = new Size(184, 38);
            lb_pedidomesa.TabIndex = 2;
            lb_pedidomesa.Text = "Pedido Mesa";
            // 
            // lb_comentarios
            // 
            lb_comentarios.AutoSize = true;
            lb_comentarios.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_comentarios.Location = new Point(33, 642);
            lb_comentarios.Name = "lb_comentarios";
            lb_comentarios.Size = new Size(183, 38);
            lb_comentarios.TabIndex = 3;
            lb_comentarios.Text = "Comentarios";
            // 
            // tb_comentarios
            // 
            tb_comentarios.Location = new Point(33, 683);
            tb_comentarios.Name = "tb_comentarios";
            tb_comentarios.Size = new Size(309, 30);
            tb_comentarios.TabIndex = 4;
            // 
            // bt_enviarcocina
            // 
            bt_enviarcocina.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_enviarcocina.Location = new Point(952, 661);
            bt_enviarcocina.Name = "bt_enviarcocina";
            bt_enviarcocina.Size = new Size(204, 52);
            bt_enviarcocina.TabIndex = 5;
            bt_enviarcocina.Text = "Enviar Cocina";
            bt_enviarcocina.UseVisualStyleBackColor = true;
            bt_enviarcocina.Click += bt_enviarcocina_Click;
            // 
            // cb_mesas
            // 
            cb_mesas.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_mesas.FormattingEnabled = true;
            cb_mesas.Location = new Point(143, 82);
            cb_mesas.Name = "cb_mesas";
            cb_mesas.Size = new Size(169, 31);
            cb_mesas.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 82);
            label1.Name = "label1";
            label1.Size = new Size(86, 38);
            label1.TabIndex = 7;
            label1.Text = "Mesa";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Rockwell", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.SaddleBrown;
            label17.Location = new Point(18, 9);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(375, 54);
            label17.TabIndex = 29;
            label17.Text = "Modulo Pedidos";
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 107, 53);
            ClientSize = new Size(1218, 743);
            Controls.Add(label17);
            Controls.Add(label1);
            Controls.Add(cb_mesas);
            Controls.Add(bt_enviarcocina);
            Controls.Add(tb_comentarios);
            Controls.Add(lb_comentarios);
            Controls.Add(lb_pedidomesa);
            Controls.Add(pnl_platillos);
            Controls.Add(dgv_platillos);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1000, 650);
            Name = "Pedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)dgv_platillos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_platillos;
        private Panel pnl_platillos;
        private Label label1;
        private Label lb_comentarios;
        private TextBox tb_comentarios;
        private Button bt_enviarcocina;
        public Label lb_pedidomesa;
        private DataGridViewTextBoxColumn Col_Platillo;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colComentario;
        private ComboBox cb_mesas;
        private Label label17;
    }
}