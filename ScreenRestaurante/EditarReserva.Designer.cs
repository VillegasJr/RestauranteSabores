namespace ScreenRestaurante
{
    partial class EditarReserva
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
            btnConfirmarreserva = new Button();
            txtNota = new TextBox();
            label15 = new Label();
            cmbNumeroPersonas = new ComboBox();
            dtpFechaReserva = new DateTimePicker();
            label10 = new Label();
            txtNombreCompleto = new TextBox();
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtClaveReserva = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 194);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 38);
            label1.TabIndex = 55;
            label1.Text = "Fecha de Reservación";
            // 
            // btnConfirmarreserva
            // 
            btnConfirmarreserva.BackColor = Color.LightGray;
            btnConfirmarreserva.FlatStyle = FlatStyle.Flat;
            btnConfirmarreserva.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarreserva.Location = new Point(307, 536);
            btnConfirmarreserva.Margin = new Padding(2, 4, 2, 4);
            btnConfirmarreserva.Name = "btnConfirmarreserva";
            btnConfirmarreserva.Size = new Size(395, 105);
            btnConfirmarreserva.TabIndex = 54;
            btnConfirmarreserva.Text = "Confirmar Modificación";
            btnConfirmarreserva.UseVisualStyleBackColor = false;
            btnConfirmarreserva.Click += btnConfirmarreserva_Click;
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota.Location = new Point(56, 336);
            txtNota.Margin = new Padding(2, 4, 2, 4);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.ScrollBars = ScrollBars.Vertical;
            txtNota.Size = new Size(960, 178);
            txtNota.TabIndex = 53;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(682, 197);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(288, 38);
            label15.TabIndex = 52;
            label15.Text = "Número de Personas";
            // 
            // cmbNumeroPersonas
            // 
            cmbNumeroPersonas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbNumeroPersonas.FormattingEnabled = true;
            cmbNumeroPersonas.Location = new Point(682, 237);
            cmbNumeroPersonas.Margin = new Padding(2, 4, 2, 4);
            cmbNumeroPersonas.Name = "cmbNumeroPersonas";
            cmbNumeroPersonas.Size = new Size(313, 46);
            cmbNumeroPersonas.TabIndex = 51;
            // 
            // dtpFechaReserva
            // 
            dtpFechaReserva.CalendarFont = new Font("Microsoft JhengHei", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaReserva.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaReserva.Location = new Point(56, 235);
            dtpFechaReserva.Margin = new Padding(2, 4, 2, 4);
            dtpFechaReserva.Name = "dtpFechaReserva";
            dtpFechaReserva.Size = new Size(585, 44);
            dtpFechaReserva.TabIndex = 48;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(468, 93);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(269, 38);
            label10.TabIndex = 45;
            label10.Text = "Nombre Completo ";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCompleto.Location = new Point(468, 136);
            txtNombreCompleto.Margin = new Padding(2, 4, 2, 4);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(527, 45);
            txtNombreCompleto.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SaddleBrown;
            label9.Location = new Point(181, -3);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(688, 87);
            label9.TabIndex = 41;
            label9.Text = "Reservacion Mesa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 294);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 38);
            label2.TabIndex = 56;
            label2.Text = "Nota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 93);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(196, 38);
            label3.TabIndex = 58;
            label3.Text = "Clave Reserva";
            // 
            // txtClaveReserva
            // 
            txtClaveReserva.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClaveReserva.Location = new Point(56, 133);
            txtClaveReserva.Margin = new Padding(2, 4, 2, 4);
            txtClaveReserva.Name = "txtClaveReserva";
            txtClaveReserva.Size = new Size(388, 45);
            txtClaveReserva.TabIndex = 57;
            // 
            // EditarReserva
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1062, 704);
            Controls.Add(label3);
            Controls.Add(txtClaveReserva);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConfirmarreserva);
            Controls.Add(txtNota);
            Controls.Add(label15);
            Controls.Add(cmbNumeroPersonas);
            Controls.Add(dtpFechaReserva);
            Controls.Add(label10);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label9);
            Name = "EditarReserva";
            Text = "EditarReserva";
            Load += EditarReserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnConfirmarreserva;
        private TextBox txtNota;
        private Label label15;
        private ComboBox cmbNumeroPersonas;
        private DateTimePicker dtpFechaReserva;
        private Label label10;
        private TextBox txtNombreCompleto;
        private Label label9;
        private Label label2;
        private Label label3;
        private TextBox txtClaveReserva;
    }
}