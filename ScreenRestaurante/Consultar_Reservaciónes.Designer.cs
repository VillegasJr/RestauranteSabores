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
            button1 = new Button();
            label18 = new Label();
            textBox5 = new TextBox();
            label17 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Linen;
            button1.Location = new Point(684, 139);
            button1.Name = "button1";
            button1.Size = new Size(219, 61);
            button1.TabIndex = 31;
            button1.Text = "Cosultar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(104, 98);
            label18.Name = "label18";
            label18.Size = new Size(444, 38);
            label18.TabIndex = 30;
            label18.Text = "Ingresa tu código de reservación";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(104, 139);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(554, 61);
            textBox5.TabIndex = 29;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.SaddleBrown;
            label17.Location = new Point(214, 11);
            label17.Name = "label17";
            label17.Size = new Size(841, 87);
            label17.TabIndex = 28;
            label17.Text = "Consultar Reservación";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 248);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1159, 211);
            dataGridView1.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 204);
            label1.Name = "label1";
            label1.Size = new Size(210, 38);
            label1.TabIndex = 33;
            label1.Text = "Inf. Reservación";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Linen;
            button2.Location = new Point(909, 139);
            button2.Name = "button2";
            button2.Size = new Size(219, 61);
            button2.TabIndex = 34;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Linen;
            button3.Location = new Point(967, 465);
            button3.Name = "button3";
            button3.Size = new Size(219, 61);
            button3.TabIndex = 35;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            // 
            // Consultar_Reservaciónes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(1212, 548);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label18);
            Controls.Add(textBox5);
            Controls.Add(label17);
            Name = "Consultar_Reservaciónes";
            Text = "Consultar_Reservaciónes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label18;
        private TextBox textBox5;
        private Label label17;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button2;
        private Button button3;
    }
}