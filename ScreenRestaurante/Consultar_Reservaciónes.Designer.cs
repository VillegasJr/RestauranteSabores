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
            btnReactivarReserva = new Button();
            ((System.ComponentModel.ISupportInitialize)txtInformacionReserva).BeginInit();
            SuspendLayout();
            // 
            // btnConsultarReserva
            // 
            btnConsultarReserva.BackColor = Color.DarkGray;
            btnConsultarReserva.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultarReserva.ForeColor = Color.Linen;
            btnConsultarReserva.Location = new Point(507, 137);
            btnConsultarReserva.Margin = new Padding(2, 4, 2, 4);
            btnConsultarReserva.Name = "btnConsultarReserva";
            btnConsultarReserva.Size = new Size(219, 61);
            btnConsultarReserva.TabIndex = 31;
            btnConsultarReserva.Text = "Cosultar";
            btnConsultarReserva.UseVisualStyleBackColor = false;
            btnConsultarReserva.Click += btnConsultarReserva_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(33, 92);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(444, 38);
            label18.TabIndex = 30;
            label18.Text = "Ingresa tu código de reservación";
            // 
            // txtCodigoReserva
            // 
            txtCodigoReserva.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigoReserva.Location = new Point(33, 137);
            txtCodigoReserva.Margin = new Padding(2, 4, 2, 4);
            txtCodigoReserva.Name = "txtCodigoReserva";
            txtCodigoReserva.Size = new Size(457, 61);
            txtCodigoReserva.TabIndex = 29;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.SaddleBrown;
            label17.Location = new Point(71, 9);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(841, 87);
            label17.TabIndex = 28;
            label17.Text = "Consultar Reservación";
            // 
            // txtInformacionReserva
            // 
            txtInformacionReserva.BackgroundColor = Color.Gainsboro;
            txtInformacionReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            txtInformacionReserva.Location = new Point(29, 249);
            txtInformacionReserva.Margin = new Padding(2, 4, 2, 4);
            txtInformacionReserva.Name = "txtInformacionReserva";
            txtInformacionReserva.RowHeadersWidth = 62;
            txtInformacionReserva.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            txtInformacionReserva.Size = new Size(966, 211);
            txtInformacionReserva.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 204);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 38);
            label1.TabIndex = 33;
            label1.Text = "Inf. Reservación";
            // 
            // btnEditarReserva
            // 
            btnEditarReserva.BackColor = Color.DarkGray;
            btnEditarReserva.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarReserva.ForeColor = Color.Linen;
            btnEditarReserva.Location = new Point(732, 137);
            btnEditarReserva.Margin = new Padding(2, 4, 2, 4);
            btnEditarReserva.Name = "btnEditarReserva";
            btnEditarReserva.Size = new Size(219, 61);
            btnEditarReserva.TabIndex = 34;
            btnEditarReserva.Text = "Editar";
            btnEditarReserva.UseVisualStyleBackColor = false;
            btnEditarReserva.Click += btnEditarReserva_Click;
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.BackColor = Color.DarkGray;
            btnCancelarReserva.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelarReserva.ForeColor = Color.Linen;
            btnCancelarReserva.Location = new Point(776, 468);
            btnCancelarReserva.Margin = new Padding(2, 4, 2, 4);
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.Size = new Size(219, 61);
            btnCancelarReserva.TabIndex = 35;
            btnCancelarReserva.Text = "Cancelar";
            btnCancelarReserva.UseVisualStyleBackColor = false;
            btnCancelarReserva.Click += btnCancelarReserva_Click;
            // 
            // btnReactivarReserva
            // 
            btnReactivarReserva.BackColor = Color.DarkGray;
            btnReactivarReserva.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReactivarReserva.ForeColor = Color.Linen;
            btnReactivarReserva.Location = new Point(533, 468);
            btnReactivarReserva.Margin = new Padding(2, 4, 2, 4);
            btnReactivarReserva.Name = "btnReactivarReserva";
            btnReactivarReserva.Size = new Size(219, 61);
            btnReactivarReserva.TabIndex = 36;
            btnReactivarReserva.Text = "Confirmar";
            btnReactivarReserva.UseVisualStyleBackColor = false;
            btnReactivarReserva.Click += btnReactivarReserva_Click;
            // 
            // Consultar_Reservaciónes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(198, 107, 53);
            ClientSize = new Size(1033, 549);
            Controls.Add(btnReactivarReserva);
            Controls.Add(btnCancelarReserva);
            Controls.Add(btnEditarReserva);
            Controls.Add(label1);
            Controls.Add(txtInformacionReserva);
            Controls.Add(btnConsultarReserva);
            Controls.Add(label18);
            Controls.Add(txtCodigoReserva);
            Controls.Add(label17);
            Margin = new Padding(2, 4, 2, 4);
            Name = "Consultar_Reservaciónes";
            Text = "Consultar_Reservaciónes";
            Load += Consultar_Reservaciónes_Load;
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
        private Button btnReactivarReserva;
    }
}