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
            btn_iniciarsesion = new Button();
            lb_usuario = new Label();
            lb_contra = new Label();
            tb_usuario = new TextBox();
            tb_contra = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_iniciarsesion
            // 
            btn_iniciarsesion.FlatStyle = FlatStyle.Flat;
            btn_iniciarsesion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_iniciarsesion.Location = new Point(140, 286);
            btn_iniciarsesion.Margin = new Padding(4);
            btn_iniciarsesion.Name = "btn_iniciarsesion";
            btn_iniciarsesion.Size = new Size(198, 71);
            btn_iniciarsesion.TabIndex = 0;
            btn_iniciarsesion.Text = "Iniciar Sesion";
            btn_iniciarsesion.UseVisualStyleBackColor = true;
            // 
            // lb_usuario
            // 
            lb_usuario.AutoSize = true;
            lb_usuario.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_usuario.Location = new Point(81, 131);
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
            lb_contra.Location = new Point(81, 226);
            lb_contra.Margin = new Padding(4, 0, 4, 0);
            lb_contra.Name = "lb_contra";
            lb_contra.Size = new Size(156, 38);
            lb_contra.TabIndex = 2;
            lb_contra.Text = "Contraseña";
            // 
            // tb_usuario
            // 
            tb_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_usuario.Location = new Point(81, 88);
            tb_usuario.Margin = new Padding(4);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(328, 39);
            tb_usuario.TabIndex = 3;
            // 
            // tb_contra
            // 
            tb_contra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_contra.Location = new Point(81, 183);
            tb_contra.Margin = new Padding(4);
            tb_contra.Name = "tb_contra";
            tb_contra.Size = new Size(328, 39);
            tb_contra.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(13, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(481, 47);
            label1.TabIndex = 5;
            label1.Text = "Acceso Para Empleados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(510, 398);
            Controls.Add(label1);
            Controls.Add(tb_contra);
            Controls.Add(tb_usuario);
            Controls.Add(lb_contra);
            Controls.Add(lb_usuario);
            Controls.Add(btn_iniciarsesion);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_iniciarsesion;
        private Label lb_usuario;
        private Label lb_contra;
        private TextBox tb_usuario;
        private TextBox tb_contra;
        private Label label1;
    }
}
