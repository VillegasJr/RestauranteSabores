namespace ScreenRestaurante
{
    partial class Cocinero
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
            label2 = new Label();
            label3 = new Label();
            btnActualizar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Rockwell", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.SaddleBrown;
            label17.Location = new Point(13, 25);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(431, 54);
            label17.TabIndex = 31;
            label17.Text = "COCINA SABORES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 125);
            label1.Name = "label1";
            label1.Size = new Size(241, 38);
            label1.TabIndex = 32;
            label1.Text = "Pedido pentiente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(662, 125);
            label2.Name = "label2";
            label2.Size = new Size(171, 38);
            label2.TabIndex = 33;
            label2.Text = "Pedido listo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(342, 125);
            label3.Name = "label3";
            label3.Size = new Size(213, 38);
            label3.TabIndex = 34;
            label3.Text = "En preparacion";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(738, 47);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 74);
            btnActualizar.TabIndex = 35;
            btnActualizar.Text = "Actualizar Pedidos";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.IndianRed;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(14, 187);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(228, 397);
            panel1.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(342, 187);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 397);
            panel2.TabIndex = 37;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.YellowGreen;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(662, 187);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(228, 397);
            panel3.TabIndex = 37;
            // 
            // Cocinero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 107, 53);
            ClientSize = new Size(914, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnActualizar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label17);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cocinero";
            Text = "Cocinero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label17;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnActualizar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}