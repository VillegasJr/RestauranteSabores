namespace ScreenRestaurante
{
    partial class Inventario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Nombre_Pd = new TextBox();
            label8 = new Label();
            label9 = new Label();
            Categoria_Pd = new ComboBox();
            label10 = new Label();
            Stock_Pd = new TextBox();
            label11 = new Label();
            Unidad_Pd = new ComboBox();
            Agregar_Pd = new Button();
            Actualizar_Pd = new Button();
            Eliminar_Pd = new Button();
            label12 = new Label();
            Minimo_Pd = new TextBox();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(731, 9);
            label1.Name = "label1";
            label1.Size = new Size(516, 128);
            label1.TabIndex = 0;
            label1.Text = "Inventario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(101, 160);
            label2.Name = "label2";
            label2.Size = new Size(217, 32);
            label2.TabIndex = 1;
            label2.Text = "Total de Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(187, 205);
            label3.Name = "label3";
            label3.Size = new Size(45, 54);
            label3.TabIndex = 2;
            label3.Text = "8";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(369, 160);
            label4.Name = "label4";
            label4.Size = new Size(128, 32);
            label4.TabIndex = 3;
            label4.Text = "Stock Bajo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(410, 205);
            label5.Name = "label5";
            label5.Size = new Size(45, 54);
            label5.TabIndex = 4;
            label5.Text = "3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(560, 160);
            label6.Name = "label6";
            label6.Size = new Size(150, 32);
            label6.TabIndex = 5;
            label6.Text = "Stock Crítico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(608, 205);
            label7.Name = "label7";
            label7.Size = new Size(45, 54);
            label7.TabIndex = 6;
            label7.Text = "1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 293);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(812, 427);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Nombre_Pd
            // 
            Nombre_Pd.Location = new Point(955, 293);
            Nombre_Pd.Name = "Nombre_Pd";
            Nombre_Pd.Size = new Size(274, 31);
            Nombre_Pd.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(867, 296);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 9;
            label8.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(857, 331);
            label9.Name = "label9";
            label9.Size = new Size(92, 25);
            label9.TabIndex = 10;
            label9.Text = "Categoría:";
            // 
            // Categoria_Pd
            // 
            Categoria_Pd.FormattingEnabled = true;
            Categoria_Pd.Location = new Point(955, 328);
            Categoria_Pd.Name = "Categoria_Pd";
            Categoria_Pd.Size = new Size(240, 33);
            Categoria_Pd.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(890, 368);
            label10.Name = "label10";
            label10.Size = new Size(59, 25);
            label10.TabIndex = 12;
            label10.Text = "Stock:";
            // 
            // Stock_Pd
            // 
            Stock_Pd.Location = new Point(955, 368);
            Stock_Pd.Name = "Stock_Pd";
            Stock_Pd.Size = new Size(206, 31);
            Stock_Pd.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(876, 407);
            label11.Name = "label11";
            label11.Size = new Size(73, 25);
            label11.TabIndex = 14;
            label11.Text = "Unidad:";
            // 
            // Unidad_Pd
            // 
            Unidad_Pd.FormattingEnabled = true;
            Unidad_Pd.Location = new Point(955, 404);
            Unidad_Pd.Name = "Unidad_Pd";
            Unidad_Pd.Size = new Size(240, 33);
            Unidad_Pd.TabIndex = 15;
            // 
            // Agregar_Pd
            // 
            Agregar_Pd.Location = new Point(924, 487);
            Agregar_Pd.Name = "Agregar_Pd";
            Agregar_Pd.Size = new Size(127, 37);
            Agregar_Pd.TabIndex = 16;
            Agregar_Pd.Text = "Agregar";
            Agregar_Pd.UseVisualStyleBackColor = true;
            Agregar_Pd.Click += Agregar_Pd_Click;
            // 
            // Actualizar_Pd
            // 
            Actualizar_Pd.Location = new Point(1057, 487);
            Actualizar_Pd.Name = "Actualizar_Pd";
            Actualizar_Pd.Size = new Size(127, 37);
            Actualizar_Pd.TabIndex = 17;
            Actualizar_Pd.Text = "Modificar";
            Actualizar_Pd.UseVisualStyleBackColor = true;
            Actualizar_Pd.Click += Actualizar_Pd_Click;
            // 
            // Eliminar_Pd
            // 
            Eliminar_Pd.Location = new Point(934, 597);
            Eliminar_Pd.Name = "Eliminar_Pd";
            Eliminar_Pd.Size = new Size(235, 83);
            Eliminar_Pd.TabIndex = 18;
            Eliminar_Pd.Text = "Eliminar Producto";
            Eliminar_Pd.UseVisualStyleBackColor = true;
            Eliminar_Pd.Click += Eliminar_Pd_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(850, 570);
            label12.Name = "label12";
            label12.Size = new Size(397, 24);
            label12.TabIndex = 19;
            label12.Text = "Selecciona el \"Producto\" que deseas eliminar.";
            // 
            // Minimo_Pd
            // 
            Minimo_Pd.Location = new Point(955, 442);
            Minimo_Pd.Name = "Minimo_Pd";
            Minimo_Pd.Size = new Size(206, 31);
            Minimo_Pd.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(872, 445);
            label13.Name = "label13";
            label13.Size = new Size(77, 25);
            label13.TabIndex = 20;
            label13.Text = "Minimo:";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1249, 777);
            Controls.Add(Minimo_Pd);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(Eliminar_Pd);
            Controls.Add(Actualizar_Pd);
            Controls.Add(Agregar_Pd);
            Controls.Add(Unidad_Pd);
            Controls.Add(label11);
            Controls.Add(Stock_Pd);
            Controls.Add(label10);
            Controls.Add(Categoria_Pd);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(Nombre_Pd);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private TextBox Nombre_Pd;
        private Label label8;
        private Label label9;
        private ComboBox Categoria_Pd;
        private Label label10;
        private TextBox Stock_Pd;
        private Label label11;
        private ComboBox Unidad_Pd;
        private Button Agregar_Pd;
        private Button Actualizar_Pd;
        private Button Eliminar_Pd;
        private Label label12;
        private TextBox Minimo_Pd;
        private Label label13;
    }
}