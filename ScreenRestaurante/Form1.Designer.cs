namespace ScreenRestaurante
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnIniciarSesion = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(159, 172);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(286, 32);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(159, 265);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(286, 32);
            txtContraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(395, 46);
            label1.TabIndex = 2;
            label1.Text = "Acceso de Empleados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(159, 131);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(159, 224);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.FlatStyle = FlatStyle.Popup;
            btnIniciarSesion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(192, 351);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(204, 69);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(198, 107, 53);
            ClientSize = new Size(649, 584);
            Controls.Add(btnIniciarSesion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnIniciarSesion;
    }
}
