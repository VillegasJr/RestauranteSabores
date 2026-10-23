namespace ScreenRestaurante
{
    partial class Consultar_Reservaciónes
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
            btnConsultarReserva = new Button();
            label18 = new Label();
            txtCodigoReserva = new TextBox();
            label17 = new Label();
            txtInformacionReserva = new DataGridView();
            label1 = new Label();
            btnEditarReserva = new Button();
            btnCancelarReserva = new Button();
            ((System.ComponentModel.ISupportInitialize)txtInformacionReserva).BeginInit();
            SuspendLayout();
            // 
            // btnConsultarReserva
            // 
            btnConsultarReserva.BackColor = Color.DarkGray;
            btnConsultarReserva.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultarReserva.ForeColor = Color.Linen;
            btnConsultarReserva.Location = new Point(547, 111);
            btnConsultarReserva.Margin = new Padding(2, 3, 2, 3);
            btnConsultarReserva.Name = "btnConsultarReserva";
            btnConsultarReserva.Size = new Size(175, 49);
            btnConsultarReserva.TabIndex = 31;
            btnConsultarReserva.Text = "Cosultar";
            btnConsultarReserva.UseVisualStyleBackColor = false;
            btnConsultarReserva.Click += btnConsultarReserva_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(83, 79);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(391, 32);
            label18.TabIndex = 30;
            label18.Text = "Ingresa tu código de reservación";
            // 
            // txtCodigoReserva
            // 
            txtCodigoReserva.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoReserva.Location = new Point(83, 115);
            txtCodigoReserva.Margin = new Padding(2, 3, 2, 3);
            txtCodigoReserva.Name = "txtCodigoReserva";
            txtCodigoReserva.Size = new Size(444, 52);
            txtCodigoReserva.TabIndex = 29;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.SaddleBrown;
            label17.Location = new Point(171, 9);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(705, 73);
            label17.TabIndex = 28;
            label17.Text = "Consultar Reservación";
            // 
            // txtInformacionReserva
            // 
            txtInformacionReserva.BackgroundColor = Color.Gainsboro;
            txtInformacionReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            txtInformacionReserva.Location = new Point(23, 199);
            txtInformacionReserva.Margin = new Padding(2, 3, 2, 3);
            txtInformacionReserva.Name = "txtInformacionReserva";
            txtInformacionReserva.RowHeadersWidth = 62;
            txtInformacionReserva.Size = new Size(927, 169);
            txtInformacionReserva.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 163);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 33;
            label1.Text = "Inf. Reservación";
            // 
            // btnEditarReserva
            // 
            btnEditarReserva.BackColor = Color.DarkGray;
            btnEditarReserva.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarReserva.ForeColor = Color.Linen;
            btnEditarReserva.Location = new Point(727, 111);
            btnEditarReserva.Margin = new Padding(2, 3, 2, 3);
            btnEditarReserva.Name = "btnEditarReserva";
            btnEditarReserva.Size = new Size(175, 49);
            btnEditarReserva.TabIndex = 34;
            btnEditarReserva.Text = "Editar";
            btnEditarReserva.UseVisualStyleBackColor = false;
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.BackColor = Color.DarkGray;
            btnCancelarReserva.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarReserva.ForeColor = Color.Linen;
            btnCancelarReserva.Location = new Point(774, 372);
            btnCancelarReserva.Margin = new Padding(2, 3, 2, 3);
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.Size = new Size(175, 49);
            btnCancelarReserva.TabIndex = 35;
            btnCancelarReserva.Text = "Cancelar";
            btnCancelarReserva.UseVisualStyleBackColor = false;
            // 
            // Consultar_Reservaciónes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 107, 53);
            ClientSize = new Size(969, 439);
            Controls.Add(btnCancelarReserva);
            Controls.Add(btnEditarReserva);
            Controls.Add(label1);
            Controls.Add(txtInformacionReserva);
            Controls.Add(btnConsultarReserva);
            Controls.Add(label18);
            Controls.Add(txtCodigoReserva);
            Controls.Add(label17);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Consultar_Reservaciónes";
            Text = "Consultar_Reservaciónes";
            ((System.ComponentModel.ISupportInitialize)txtInformacionReserva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsultarReserva;
        private Label label18;
        private TextBox txtCodigoReserva;
        private Label label17;
        private DataGridView txtInformacionReserva;
        private Label label1;
        private Button btnEditarReserva;
        private Button btnCancelarReserva;
    }
}