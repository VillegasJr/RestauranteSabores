namespace ScreenRestaurante
{
    partial class Ventas
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            FechaDia = new Label();
            label4 = new Label();
            TotalDia = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, -1);
            label1.Name = "label1";
            label1.Size = new Size(162, 60);
            label1.TabIndex = 0;
            label1.Text = "Ventas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 9);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 1;
            label2.Text = "Registro del Día:";
            // 
            // FechaDia
            // 
            FechaDia.AutoSize = true;
            FechaDia.Location = new Point(304, 9);
            FechaDia.Name = "FechaDia";
            FechaDia.Size = new Size(0, 25);
            FechaDia.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 73);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 3;
            label4.Text = "Total del Día:";
            // 
            // TotalDia
            // 
            TotalDia.AutoSize = true;
            TotalDia.Font = new Font("Modern No. 20", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalDia.Location = new Point(124, 67);
            TotalDia.Name = "TotalDia";
            TotalDia.Size = new Size(0, 41);
            TotalDia.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(776, 319);
            dataGridView1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(651, 95);
            label6.Name = "label6";
            label6.Size = new Size(137, 32);
            label6.TabIndex = 6;
            label6.Text = "HISTORIAL";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(TotalDia);
            Controls.Add(label4);
            Controls.Add(FechaDia);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ventas";
            Text = "Ventas";
            Load += Ventas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label FechaDia;
        private Label label4;
        private Label TotalDia;
        private DataGridView dataGridView1;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}