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
            ((System.ComponentModel.ISupportInitialize)dgv_platillos).BeginInit();
            SuspendLayout();
            // 
            // dgv_platillos
            // 
            dgv_platillos.AllowUserToAddRows = false;
            dgv_platillos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_platillos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_platillos.Columns.AddRange(new DataGridViewColumn[] { Col_Platillo, colCantidad, colPrecio, colComentario });
            dgv_platillos.Location = new Point(76, 106);
            dgv_platillos.MultiSelect = false;
            dgv_platillos.Name = "dgv_platillos";
            dgv_platillos.ReadOnly = true;
            dgv_platillos.RowHeadersWidth = 51;
            dgv_platillos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_platillos.Size = new Size(437, 388);
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
            pnl_platillos.Location = new Point(641, 106);
            pnl_platillos.Name = "pnl_platillos";
            pnl_platillos.Size = new Size(337, 388);
            pnl_platillos.TabIndex = 1;
            // 
            // lb_pedidomesa
            // 
            lb_pedidomesa.AutoSize = true;
            lb_pedidomesa.Location = new Point(641, 68);
            lb_pedidomesa.Name = "lb_pedidomesa";
            lb_pedidomesa.Size = new Size(94, 20);
            lb_pedidomesa.TabIndex = 2;
            lb_pedidomesa.Text = "Pedido Mesa";
            // 
            // lb_comentarios
            // 
            lb_comentarios.AutoSize = true;
            lb_comentarios.Location = new Point(113, 534);
            lb_comentarios.Name = "lb_comentarios";
            lb_comentarios.Size = new Size(93, 20);
            lb_comentarios.TabIndex = 3;
            lb_comentarios.Text = "Comentarios";
            // 
            // tb_comentarios
            // 
            tb_comentarios.Location = new Point(113, 566);
            tb_comentarios.Name = "tb_comentarios";
            tb_comentarios.Size = new Size(275, 27);
            tb_comentarios.TabIndex = 4;
            // 
            // bt_enviarcocina
            // 
            bt_enviarcocina.Location = new Point(845, 566);
            bt_enviarcocina.Name = "bt_enviarcocina";
            bt_enviarcocina.Size = new Size(133, 29);
            bt_enviarcocina.TabIndex = 5;
            bt_enviarcocina.Text = "Enviar Cocina";
            bt_enviarcocina.UseVisualStyleBackColor = true;
            // 
            // cb_mesas
            // 
            cb_mesas.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_mesas.FormattingEnabled = true;
            cb_mesas.Location = new Point(127, 68);
            cb_mesas.Name = "cb_mesas";
            cb_mesas.Size = new Size(151, 28);
            cb_mesas.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 71);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 7;
            label1.Text = "Mesa";
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 652);
            Controls.Add(label1);
            Controls.Add(cb_mesas);
            Controls.Add(bt_enviarcocina);
            Controls.Add(tb_comentarios);
            Controls.Add(lb_comentarios);
            Controls.Add(lb_pedidomesa);
            Controls.Add(pnl_platillos);
            Controls.Add(dgv_platillos);
            Name = "Pedidos";
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
    }
}