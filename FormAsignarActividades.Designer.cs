namespace TP1
{
    partial class FormAsignarActividades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsignarActividades));
            dtgvActividad = new DataGridView();
            Actividad = new DataGridViewTextBoxColumn();
            Cupo = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            comboBoxAct = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBoxDNIAct = new TextBox();
            buttonVolver = new Button();
            buttonAsigAct = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvActividad
            // 
            dtgvActividad.AllowUserToAddRows = false;
            dtgvActividad.AllowUserToDeleteRows = false;
            dtgvActividad.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvActividad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividad.Columns.AddRange(new DataGridViewColumn[] { Actividad, Cupo, Precio });
            dtgvActividad.Location = new Point(392, 109);
            dtgvActividad.Name = "dtgvActividad";
            dtgvActividad.ReadOnly = true;
            dtgvActividad.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgvActividad.RowTemplate.Height = 25;
            dtgvActividad.Size = new Size(343, 201);
            dtgvActividad.TabIndex = 1;
            // 
            // Actividad
            // 
            Actividad.HeaderText = "ACTIVIDAD";
            Actividad.Name = "Actividad";
            Actividad.ReadOnly = true;
            // 
            // Cupo
            // 
            Cupo.HeaderText = "CUPO";
            Cupo.Name = "Cupo";
            Cupo.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "PRECIO";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(360, 50);
            label1.Name = "label1";
            label1.Size = new Size(423, 37);
            label1.TabIndex = 2;
            label1.Text = "Lista de actividades disponibles";
            // 
            // comboBoxAct
            // 
            comboBoxAct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAct.FormattingEnabled = true;
            comboBoxAct.Items.AddRange(new object[] { "Basket", "Futbol", "Handball", "Hockey", "Natacion", "Tenis", "Volley" });
            comboBoxAct.Location = new Point(93, 149);
            comboBoxAct.Name = "comboBoxAct";
            comboBoxAct.Size = new Size(142, 23);
            comboBoxAct.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(28, 96);
            label2.Name = "label2";
            label2.Size = new Size(298, 20);
            label2.TabIndex = 4;
            label2.Text = "Seleccione la actividad que desea asignar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(28, 225);
            label3.Name = "label3";
            label3.Size = new Size(318, 20);
            label3.TabIndex = 5;
            label3.Text = "Ingrese DNI del cliente a asignarle actividad:";
            // 
            // textBoxDNIAct
            // 
            textBoxDNIAct.Location = new Point(93, 272);
            textBoxDNIAct.Name = "textBoxDNIAct";
            textBoxDNIAct.PlaceholderText = "Sin puntos. Ej: 12345678";
            textBoxDNIAct.Size = new Size(142, 23);
            textBoxDNIAct.TabIndex = 6;
            textBoxDNIAct.KeyPress += textBoxDNIAct_KeyPress;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.Transparent;
            buttonVolver.BackgroundImage = (Image)resources.GetObject("buttonVolver.BackgroundImage");
            buttonVolver.BackgroundImageLayout = ImageLayout.Zoom;
            buttonVolver.FlatStyle = FlatStyle.Popup;
            buttonVolver.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVolver.Location = new Point(187, 379);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(188, 37);
            buttonVolver.TabIndex = 7;
            buttonVolver.Text = "\r\n";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonAsigAct
            // 
            buttonAsigAct.BackColor = Color.Transparent;
            buttonAsigAct.BackgroundImage = (Image)resources.GetObject("buttonAsigAct.BackgroundImage");
            buttonAsigAct.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAsigAct.FlatStyle = FlatStyle.Popup;
            buttonAsigAct.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAsigAct.Location = new Point(447, 379);
            buttonAsigAct.Name = "buttonAsigAct";
            buttonAsigAct.Size = new Size(188, 37);
            buttonAsigAct.TabIndex = 8;
            buttonAsigAct.UseVisualStyleBackColor = false;
            buttonAsigAct.Click += buttonAsigAct_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonAsigAct);
            panel1.Controls.Add(textBoxDNIAct);
            panel1.Controls.Add(buttonVolver);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxAct);
            panel1.Location = new Point(-7, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 458);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(456, 351);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 10;
            label5.Text = "Asignar actividad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(244, 351);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 9;
            label4.Text = "Volver";
            // 
            // FormAsignarActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgvActividad);
            Controls.Add(panel1);
            Name = "FormAsignarActividades";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grupazo AC: Asignar actividad";
            Load += AsignarActividades_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvActividad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvActividad;
        private Label label1;
        private DataGridViewTextBoxColumn Actividad;
        private DataGridViewTextBoxColumn Cupo;
        private DataGridViewTextBoxColumn Precio;
        private ComboBox comboBoxAct;
        private Label label2;
        private Label label3;
        private TextBox textBoxDNIAct;
        private Button buttonVolver;
        private Button buttonAsigAct;
        private Panel panel1;
        private Label label5;
        private Label label4;
    }
}