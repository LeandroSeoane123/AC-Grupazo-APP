namespace TP1
{
    partial class FormListarSociosCuotaVencida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListarSociosCuotaVencida));
            dataGridView1 = new DataGridView();
            label8 = new Label();
            buttonSalir = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(519, 295);
            dataGridView1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(45, 373);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 13;
            label8.Text = "Volver";
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.BackgroundImage = (Image)resources.GetObject("buttonSalir.BackgroundImage");
            buttonSalir.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.ForeColor = Color.Black;
            buttonSalir.Location = new Point(22, 366);
            buttonSalir.Margin = new Padding(3, 2, 3, 2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(188, 37);
            buttonSalir.TabIndex = 12;
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(buttonSalir);
            panel1.Location = new Point(-10, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 423);
            panel1.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(68, 7);
            label1.Name = "label1";
            label1.Size = new Size(436, 48);
            label1.TabIndex = 15;
            label1.Text = "Socios con cuota vencida";
            // 
            // FormListarSociosCuotaVencida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 410);
            Controls.Add(panel1);
            Name = "FormListarSociosCuotaVencida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AC Grupazo: Socios con cuota vencida";
            Load += FormListarSociosCuotaVencida_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label8;
        private Button buttonSalir;
        private Panel panel1;
        private Label label1;
    }
}