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
            flp_categorias = new FlowLayoutPanel();
            bt_platillos = new Button();
            bt_entradas = new Button();
            bt_bebidas = new Button();
            bt_postres = new Button();
            flp_productos = new FlowLayoutPanel();
            lb_pedidomesa = new Label();
            lb_comentarios = new Label();
            tb_comentarios = new TextBox();
            bt_enviarcocina = new Button();
            cb_mesas = new ComboBox();
            label1 = new Label();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_platillos).BeginInit();
            pnl_platillos.SuspendLayout();
            flp_categorias.SuspendLayout();
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
            pnl_platillos.Controls.Add(flp_categorias);
            pnl_platillos.Controls.Add(flp_productos);
            pnl_platillos.Location = new Point(645, 129);
            pnl_platillos.Name = "pnl_platillos";
            pnl_platillos.Size = new Size(536, 500);
            pnl_platillos.TabIndex = 1;
            // 
            // flp_categorias
            // 
            flp_categorias.Controls.Add(bt_platillos);
            flp_categorias.Controls.Add(bt_entradas);
            flp_categorias.Controls.Add(bt_bebidas);
            flp_categorias.Controls.Add(bt_postres);
            flp_categorias.Dock = DockStyle.Top;
            flp_categorias.Location = new Point(0, 0);
            flp_categorias.Name = "flp_categorias";
            flp_categorias.Size = new Size(536, 45);
            flp_categorias.TabIndex = 6;
            // 
            // bt_platillos
            // 
            bt_platillos.Location = new Point(3, 3);
            bt_platillos.Name = "bt_platillos";
            bt_platillos.Size = new Size(126, 33);
            bt_platillos.TabIndex = 1;
            bt_platillos.Text = "Platillos";
            bt_platillos.UseVisualStyleBackColor = true;
            // 
            // bt_entradas
            // 
            bt_entradas.Location = new Point(135, 3);
            bt_entradas.Name = "bt_entradas";
            bt_entradas.Size = new Size(126, 33);
            bt_entradas.TabIndex = 2;
            bt_entradas.Text = "Entradas";
            bt_entradas.UseVisualStyleBackColor = true;
            // 
            // bt_bebidas
            // 
            bt_bebidas.Location = new Point(267, 3);
            bt_bebidas.Name = "bt_bebidas";
            bt_bebidas.Size = new Size(126, 33);
            bt_bebidas.TabIndex = 3;
            bt_bebidas.Text = "Bebidas";
            bt_bebidas.UseVisualStyleBackColor = true;
            // 
            // bt_postres
            // 
            bt_postres.Location = new Point(399, 3);
            bt_postres.Name = "bt_postres";
            bt_postres.Size = new Size(126, 33);
            bt_postres.TabIndex = 4;
            bt_postres.Text = "Postres";
            bt_postres.UseVisualStyleBackColor = true;
            // 
            // flp_productos
            // 
            flp_productos.AutoScroll = true;
            flp_productos.Location = new Point(0, 51);
            flp_productos.Name = "flp_productos";
            flp_productos.Size = new Size(536, 449);
            flp_productos.TabIndex = 5;
            // 
            // lb_pedidomesa
            // 
            lb_pedidomesa.AutoSize = true;
            lb_pedidomesa.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_pedidomesa.Location = new Point(645, 88);
            lb_pedidomesa.Name = "lb_pedidomesa";
            lb_pedidomesa.Size = new Size(146, 30);
            lb_pedidomesa.TabIndex = 2;
            lb_pedidomesa.Text = "Pedido Mesa";
            // 
            // lb_comentarios
            // 
            lb_comentarios.AutoSize = true;
            lb_comentarios.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_comentarios.Location = new Point(33, 642);
            lb_comentarios.Name = "lb_comentarios";
            lb_comentarios.Size = new Size(144, 30);
            lb_comentarios.TabIndex = 3;
            lb_comentarios.Text = "Comentarios";
            // 
            // tb_comentarios
            // 
            tb_comentarios.Location = new Point(33, 683);
            tb_comentarios.Name = "tb_comentarios";
            tb_comentarios.Size = new Size(309, 25);
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
            cb_mesas.Size = new Size(169, 25);
            cb_mesas.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 82);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
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
            label17.Size = new Size(295, 43);
            label17.TabIndex = 29;
            label17.Text = "Modulo Pedidos";
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
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
            pnl_platillos.ResumeLayout(false);
            flp_categorias.ResumeLayout(false);
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
        private FlowLayoutPanel flp_categorias;
        private Button bt_platillos;
        private Button bt_entradas;
        private Button bt_bebidas;
        private Button bt_postres;
        private FlowLayoutPanel flp_productos;
    }
}