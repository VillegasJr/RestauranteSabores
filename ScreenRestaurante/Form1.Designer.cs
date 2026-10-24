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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciarSesion = new Button();
            lb_usuario = new Label();
            lb_contra = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.FlatStyle = FlatStyle.Flat;
            btnIniciarSesion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSesion.Location = new Point(140, 287);
            btnIniciarSesion.Margin = new Padding(4, 3, 4, 3);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(199, 72);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lb_usuario
            // 
            lb_usuario.AutoSize = true;
            lb_usuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_usuario.Location = new Point(81, 132);
            lb_usuario.Margin = new Padding(4, 0, 4, 0);
            lb_usuario.Name = "lb_usuario";
            lb_usuario.Size = new Size(111, 38);
            lb_usuario.TabIndex = 1;
            lb_usuario.Text = "Usuario";
            // 
            // lb_contra
            // 
            lb_contra.AutoSize = true;
            lb_contra.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_contra.Location = new Point(81, 227);
            lb_contra.Margin = new Padding(4, 0, 4, 0);
            lb_contra.Name = "lb_contra";
            lb_contra.Size = new Size(156, 38);
            lb_contra.TabIndex = 2;
            lb_contra.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(81, 88);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(328, 39);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(81, 183);
            txtContraseña.Margin = new Padding(4, 3, 4, 3);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(328, 39);
            txtContraseña.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(13, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(481, 47);
            label1.TabIndex = 5;
            label1.Text = "Acceso Para Empleados";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 107, 53);
            ClientSize = new Size(510, 398);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lb_contra);
            Controls.Add(lb_usuario);
            Controls.Add(btnIniciarSesion);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private Label lb_usuario;
        private Label lb_contra;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label1;
    }
}
