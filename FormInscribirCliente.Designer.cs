
namespace TP1
{
    partial class FormInscribirCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscribirCliente));
            labelTelefono = new Label();
            label5 = new Label();
            label4 = new Label();
            textBoxTelefono = new TextBox();
            labelFechaNacimiento = new Label();
            labelEmail = new Label();
            textBoxNumeroDNI = new TextBox();
            textBoxEmail = new TextBox();
            label3 = new Label();
            label7 = new Label();
            labelNumeroDNI = new Label();
            buttonVolver = new Button();
            label2 = new Label();
            buttonRegistrar = new Button();
            textBoxApellido = new TextBox();
            labelPantallaRegistro = new Label();
            labelApellido = new Label();
            comboBoxTipoCliente = new ComboBox();
            label1 = new Label();
            label6 = new Label();
            textBoxNombre = new TextBox();
            label8 = new Label();
            labelNombre = new Label();
            checkBoxAptoFisico = new CheckBox();
            panel1 = new Panel();
            comboBoxDia = new ComboBox();
            comboBoxAño = new ComboBox();
            comboBoxMes = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.BackColor = Color.Transparent;
            labelTelefono.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefono.ForeColor = Color.White;
            labelTelefono.Location = new Point(340, 252);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(150, 22);
            labelTelefono.TabIndex = 13;
            labelTelefono.Text = "Número de teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(485, 255);
            label5.Name = "label5";
            label5.Size = new Size(16, 20);
            label5.TabIndex = 14;
            label5.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(696, 170);
            label4.Name = "label4";
            label4.Size = new Size(16, 20);
            label4.TabIndex = 11;
            label4.Text = "*";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTelefono.Location = new Point(341, 274);
            textBoxTelefono.Margin = new Padding(3, 2, 3, 2);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.PlaceholderText = "Sin puntos. Ej: 1145459696";
            textBoxTelefono.Size = new Size(189, 27);
            textBoxTelefono.TabIndex = 5;
            textBoxTelefono.KeyPress += textBoxTelefono_KeyPress;
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.BackColor = Color.Transparent;
            labelFechaNacimiento.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelFechaNacimiento.ForeColor = Color.White;
            labelFechaNacimiento.Location = new Point(575, 171);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(124, 36);
            labelFechaNacimiento.TabIndex = 10;
            labelFechaNacimiento.Text = "Fecha de nacimiento\r\n(DIA-MES-AÑO)";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(575, 253);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 22);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "E-mail";
            // 
            // textBoxNumeroDNI
            // 
            textBoxNumeroDNI.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumeroDNI.Location = new Point(340, 144);
            textBoxNumeroDNI.Margin = new Padding(3, 2, 3, 2);
            textBoxNumeroDNI.Name = "textBoxNumeroDNI";
            textBoxNumeroDNI.PlaceholderText = "Sin puntos. Ej: 12345678";
            textBoxNumeroDNI.Size = new Size(189, 27);
            textBoxNumeroDNI.TabIndex = 1;
            textBoxNumeroDNI.KeyPress += textBoxNumeroDNI_KeyPress;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(573, 275);
            textBoxEmail.Margin = new Padding(3, 2, 3, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "usuario@mimail.com";
            textBoxEmail.Size = new Size(189, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(405, 184);
            label3.Name = "label3";
            label3.Size = new Size(16, 20);
            label3.TabIndex = 8;
            label3.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(625, 252);
            label7.Name = "label7";
            label7.Size = new Size(16, 20);
            label7.TabIndex = 18;
            label7.Text = "*";
            // 
            // labelNumeroDNI
            // 
            labelNumeroDNI.AutoSize = true;
            labelNumeroDNI.BackColor = Color.Transparent;
            labelNumeroDNI.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelNumeroDNI.ForeColor = Color.White;
            labelNumeroDNI.Location = new Point(340, 183);
            labelNumeroDNI.Name = "labelNumeroDNI";
            labelNumeroDNI.Size = new Size(70, 22);
            labelNumeroDNI.TabIndex = 7;
            labelNumeroDNI.Text = "Apellido";
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.Transparent;
            buttonVolver.BackgroundImage = (Image)resources.GetObject("buttonVolver.BackgroundImage");
            buttonVolver.BackgroundImageLayout = ImageLayout.Zoom;
            buttonVolver.FlatStyle = FlatStyle.Popup;
            buttonVolver.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(184, 411);
            buttonVolver.Margin = new Padding(3, 2, 3, 2);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(188, 37);
            buttonVolver.TabIndex = 8;
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(639, 120);
            label2.Name = "label2";
            label2.Size = new Size(16, 20);
            label2.TabIndex = 5;
            label2.Text = "*";
            // 
            // buttonRegistrar
            // 
            buttonRegistrar.BackColor = Color.Transparent;
            buttonRegistrar.BackgroundImage = (Image)resources.GetObject("buttonRegistrar.BackgroundImage");
            buttonRegistrar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRegistrar.FlatStyle = FlatStyle.Popup;
            buttonRegistrar.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrar.ForeColor = Color.White;
            buttonRegistrar.Location = new Point(447, 411);
            buttonRegistrar.Margin = new Padding(3, 2, 3, 2);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.RightToLeft = RightToLeft.No;
            buttonRegistrar.Size = new Size(188, 37);
            buttonRegistrar.TabIndex = 9;
            buttonRegistrar.UseVisualStyleBackColor = false;
            buttonRegistrar.Click += buttonRegistrar_Click;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApellido.Location = new Point(340, 207);
            textBoxApellido.Margin = new Padding(3, 2, 3, 2);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.PlaceholderText = "Ingrese su apellido";
            textBoxApellido.Size = new Size(189, 27);
            textBoxApellido.TabIndex = 3;
            // 
            // labelPantallaRegistro
            // 
            labelPantallaRegistro.AutoSize = true;
            labelPantallaRegistro.BackColor = Color.Transparent;
            labelPantallaRegistro.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelPantallaRegistro.ForeColor = Color.White;
            labelPantallaRegistro.Location = new Point(340, 55);
            labelPantallaRegistro.Name = "labelPantallaRegistro";
            labelPantallaRegistro.Size = new Size(405, 34);
            labelPantallaRegistro.TabIndex = 21;
            labelPantallaRegistro.Text = "Ingrese los datos del nuevo cliente";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.BackColor = Color.Transparent;
            labelApellido.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelApellido.ForeColor = Color.White;
            labelApellido.Location = new Point(575, 120);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(66, 22);
            labelApellido.TabIndex = 3;
            labelApellido.Text = "Nombre";
            // 
            // comboBoxTipoCliente
            // 
            comboBoxTipoCliente.FormattingEnabled = true;
            comboBoxTipoCliente.ItemHeight = 15;
            comboBoxTipoCliente.Items.AddRange(new object[] { "Socio", "No socio" });
            comboBoxTipoCliente.Location = new Point(573, 339);
            comboBoxTipoCliente.Name = "comboBoxTipoCliente";
            comboBoxTipoCliente.Size = new Size(183, 23);
            comboBoxTipoCliente.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(447, 122);
            label1.Name = "label1";
            label1.Size = new Size(16, 20);
            label1.TabIndex = 2;
            label1.Text = "*";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(575, 315);
            label6.Name = "label6";
            label6.Size = new Size(137, 21);
            label6.TabIndex = 22;
            label6.Text = "Tipo de cliente";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.Location = new Point(575, 144);
            textBoxNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Ingrese su nombre";
            textBoxNombre.Size = new Size(189, 27);
            textBoxNombre.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(696, 315);
            label8.Name = "label8";
            label8.Size = new Size(16, 20);
            label8.TabIndex = 24;
            label8.Text = "*";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.Transparent;
            labelNombre.Font = new Font("Impact", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(340, 122);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(112, 21);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Numero de DNI";
            // 
            // checkBoxAptoFisico
            // 
            checkBoxAptoFisico.AutoSize = true;
            checkBoxAptoFisico.BackColor = Color.Transparent;
            checkBoxAptoFisico.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAptoFisico.ForeColor = Color.White;
            checkBoxAptoFisico.Location = new Point(342, 338);
            checkBoxAptoFisico.Name = "checkBoxAptoFisico";
            checkBoxAptoFisico.Size = new Size(190, 26);
            checkBoxAptoFisico.TabIndex = 25;
            checkBoxAptoFisico.Text = "¿Presento apto fisico?";
            checkBoxAptoFisico.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(comboBoxDia);
            panel1.Controls.Add(comboBoxAño);
            panel1.Controls.Add(comboBoxMes);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(checkBoxAptoFisico);
            panel1.Controls.Add(labelNombre);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxTipoCliente);
            panel1.Controls.Add(labelApellido);
            panel1.Controls.Add(labelPantallaRegistro);
            panel1.Controls.Add(textBoxApellido);
            panel1.Controls.Add(buttonRegistrar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonVolver);
            panel1.Controls.Add(labelNumeroDNI);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxNumeroDNI);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(labelFechaNacimiento);
            panel1.Controls.Add(textBoxTelefono);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(labelTelefono);
            panel1.Location = new Point(-8, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 482);
            panel1.TabIndex = 26;
            // 
            // comboBoxDia
            // 
            comboBoxDia.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDia.FormattingEnabled = true;
            comboBoxDia.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            comboBoxDia.Location = new Point(575, 207);
            comboBoxDia.Name = "comboBoxDia";
            comboBoxDia.Size = new Size(37, 23);
            comboBoxDia.TabIndex = 32;
            // 
            // comboBoxAño
            // 
            comboBoxAño.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAño.FormattingEnabled = true;
            comboBoxAño.Items.AddRange(new object[] { "2024", "2023", "2022", "2021", "2020", "2019", "2018", "2017", "2016", "2015", "2014", "2013", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924" });
            comboBoxAño.Location = new Point(660, 207);
            comboBoxAño.Name = "comboBoxAño";
            comboBoxAño.Size = new Size(61, 23);
            comboBoxAño.TabIndex = 31;
            // 
            // comboBoxMes
            // 
            comboBoxMes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            comboBoxMes.Location = new Point(618, 207);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(37, 23);
            comboBoxMes.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(527, 338);
            label11.Name = "label11";
            label11.Size = new Size(16, 20);
            label11.TabIndex = 28;
            label11.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(249, 387);
            label10.Name = "label10";
            label10.Size = new Size(55, 22);
            label10.TabIndex = 27;
            label10.Text = "Volver";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(498, 387);
            label9.Name = "label9";
            label9.Size = new Size(77, 22);
            label9.TabIndex = 26;
            label9.Text = "Registrar";
            // 
            // FormInscribirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 482);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormInscribirCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grupazo AC: Inscripción";
            Load += FormInscribirCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label labelTelefono;
        private Label label5;
        private Label label4;
        private TextBox textBoxTelefono;
        private Label labelFechaNacimiento;
        private Label labelEmail;
        private TextBox textBoxNumeroDNI;
        private TextBox textBoxEmail;
        private Label label3;
        private Label label7;
        private Label labelNumeroDNI;
        private Button buttonVolver;
        private Label label2;
        private Button buttonRegistrar;
        private TextBox textBoxApellido;
        private Label labelPantallaRegistro;
        private Label labelApellido;
        private ComboBox comboBoxTipoCliente;
        private Label label1;
        private Label label6;
        private TextBox textBoxNombre;
        private Label label8;
        private Label labelNombre;
        private CheckBox checkBoxAptoFisico;
        private Panel panel1;
        private Label label9;
        private Label label10;
        private Label label11;
        private ComboBox comboBoxDia;
        private ComboBox comboBoxAño;
        private ComboBox comboBoxMes;
    }
}