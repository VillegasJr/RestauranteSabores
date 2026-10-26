namespace ScreenRestaurante
{
    partial class GerenteSesion
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
            menuStrip1 = new MenuStrip();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            invetarioToolStripMenuItem = new ToolStripMenuItem();
            consultarReservacionesToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            hacerReservacionesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ventasToolStripMenuItem, invetarioToolStripMenuItem, consultarReservacionesToolStripMenuItem, cerrarSesiónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(505, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(53, 22);
            ventasToolStripMenuItem.Text = "Ventas";
            ventasToolStripMenuItem.Click += ventasToolStripMenuItem_Click;
            // 
            // invetarioToolStripMenuItem
            // 
            invetarioToolStripMenuItem.Name = "invetarioToolStripMenuItem";
            invetarioToolStripMenuItem.Size = new Size(65, 22);
            invetarioToolStripMenuItem.Text = "Invetario";
            invetarioToolStripMenuItem.Click += invetarioToolStripMenuItem_Click;
            // 
            // consultarReservacionesToolStripMenuItem
            // 
            consultarReservacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hacerReservacionesToolStripMenuItem });
            consultarReservacionesToolStripMenuItem.Name = "consultarReservacionesToolStripMenuItem";
            consultarReservacionesToolStripMenuItem.Size = new Size(147, 22);
            consultarReservacionesToolStripMenuItem.Text = "Consultar Reservaciones";
            consultarReservacionesToolStripMenuItem.Click += consultarReservacionesToolStripMenuItem_Click;
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(88, 22);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesiónToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(0, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(390, 128);
            label1.TabIndex = 1;
            label1.Text = "Sabores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(375, 79);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 30);
            label2.TabIndex = 2;
            label2.Text = "México";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(38, 136);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(303, 21);
            label3.TabIndex = 3;
            label3.Text = "Cocina Tradicional Mexicana · Desde 1998";
            // 
            // hacerReservacionesToolStripMenuItem
            // 
            hacerReservacionesToolStripMenuItem.Name = "hacerReservacionesToolStripMenuItem";
            hacerReservacionesToolStripMenuItem.Size = new Size(180, 22);
            hacerReservacionesToolStripMenuItem.Text = "Hacer reservaciones";
            hacerReservacionesToolStripMenuItem.Click += hacerReservacionToolStripMenuItem_Click;
            // 
            // GerenteSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 107, 53);
            ClientSize = new Size(505, 193);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "GerenteSesion";
            Text = "GerenteSesion";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem invetarioToolStripMenuItem;
        private ToolStripMenuItem consultarReservacionesToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem hacerReservacionesToolStripMenuItem;
    }
}