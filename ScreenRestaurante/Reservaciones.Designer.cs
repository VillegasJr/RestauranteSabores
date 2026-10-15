namespace ScreenRestaurante
{
    partial class Reservaciones
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
            txtNota = new TextBox();
            label16 = new Label();
            label15 = new Label();
            cmdNumeroPersonas = new ComboBox();
            label14 = new Label();
            cmdHoraDisponible = new ComboBox();
            dtpFechareserva = new DateTimePicker();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtNombreCompleto = new TextBox();
            label9 = new Label();
            btnConfirmarreserva = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNota
            // 
            txtNota.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota.Location = new Point(32, 323);
            txtNota.Margin = new Padding(2, 2, 2, 2);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.ScrollBars = ScrollBars.Vertical;
            txtNota.Size = new Size(673, 108);
            txtNota.TabIndex = 38;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(32, 298);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(56, 25);
            label16.TabIndex = 37;
            label16.Text = "Nota";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(294, 241);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(197, 25);
            label15.TabIndex = 36;
            label15.Text = "Número de Personas";
            // 
            // cmdNumeroPersonas
            // 
            cmdNumeroPersonas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdNumeroPersonas.FormattingEnabled = true;
            cmdNumeroPersonas.Location = new Point(294, 265);
            cmdNumeroPersonas.Margin = new Padding(2, 2, 2, 2);
            cmdNumeroPersonas.Name = "cmdNumeroPersonas";
            cmdNumeroPersonas.Size = new Size(411, 33);
            cmdNumeroPersonas.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(32, 241);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(157, 25);
            label14.TabIndex = 34;
            label14.Text = "Hora Disponible";
            // 
            // cmdHoraDisponible
            // 
            cmdHoraDisponible.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdHoraDisponible.FormattingEnabled = true;
            cmdHoraDisponible.Location = new Point(32, 265);
            cmdHoraDisponible.Margin = new Padding(2, 2, 2, 2);
            cmdHoraDisponible.Name = "cmdHoraDisponible";
            cmdHoraDisponible.Size = new Size(241, 33);
            cmdHoraDisponible.TabIndex = 33;
            // 
            // dtpFechareserva
            // 
            dtpFechareserva.CalendarFont = new Font("Microsoft JhengHei", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechareserva.Font = new Font("Arial Narrow", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechareserva.Location = new Point(294, 207);
            dtpFechareserva.Margin = new Padding(2, 2, 2, 2);
            dtpFechareserva.Name = "dtpFechareserva";
            dtpFechareserva.Size = new Size(411, 32);
            dtpFechareserva.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(32, 182);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(89, 25);
            label12.TabIndex = 30;
            label12.Text = "Teléfono";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(32, 124);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(178, 25);
            label11.TabIndex = 29;
            label11.Text = "Correo Electrónico";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(32, 67);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(183, 25);
            label10.TabIndex = 28;
            label10.Text = "Nombre Completo ";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(32, 207);
            txtTelefono.Margin = new Padding(2, 2, 2, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(241, 32);
            txtTelefono.TabIndex = 27;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(32, 149);
            txtCorreo.Margin = new Padding(2, 2, 2, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(673, 32);
            txtCorreo.TabIndex = 26;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCompleto.Location = new Point(32, 91);
            txtNombreCompleto.Margin = new Padding(2, 2, 2, 2);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(673, 32);
            txtNombreCompleto.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.SaddleBrown;
            label9.Location = new Point(178, 5);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(382, 59);
            label9.TabIndex = 24;
            label9.Text = "Reservar Mesa";
            // 
            // btnConfirmarreserva
            // 
            btnConfirmarreserva.BackColor = Color.LightGray;
            btnConfirmarreserva.FlatStyle = FlatStyle.Flat;
            btnConfirmarreserva.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarreserva.Location = new Point(229, 444);
            btnConfirmarreserva.Margin = new Padding(2, 2, 2, 2);
            btnConfirmarreserva.Name = "btnConfirmarreserva";
            btnConfirmarreserva.Size = new Size(229, 39);
            btnConfirmarreserva.TabIndex = 39;
            btnConfirmarreserva.Text = "Confirmar Reserva";
            btnConfirmarreserva.UseVisualStyleBackColor = false;
            btnConfirmarreserva.Click += btnConfirmarreserva_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 182);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(201, 25);
            label1.TabIndex = 40;
            label1.Text = "Fecha de Reservación";
            // 
            // Reservaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(748, 508);
            Controls.Add(label1);
            Controls.Add(btnConfirmarreserva);
            Controls.Add(txtNota);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(cmdNumeroPersonas);
            Controls.Add(label14);
            Controls.Add(cmdHoraDisponible);
            Controls.Add(dtpFechareserva);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label9);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Reservaciones";
            Text = "Reservaciones";
            Load += Reservaciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota;
        private Label label16;
        private Label label15;
        private ComboBox cmdNumeroPersonas;
        private Label label14;
        private ComboBox cmdHoraDisponible;
        private DateTimePicker dtpFechareserva;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtNombreCompleto;
        private Label label9;
        private Button btnConfirmarreserva;
        private Label label1;
    }
}