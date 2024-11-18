namespace TP1
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnIngresar = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            buttonSalir = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(345, 148);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario";
            txtUser.Size = new Size(171, 23);
            txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.AcceptsTab = true;
            txtPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(345, 235);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Contraseña";
            txtPass.Size = new Size(171, 23);
            txtPass.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Transparent;
            btnIngresar.BackgroundImage = (Image)resources.GetObject("btnIngresar.BackgroundImage");
            btnIngresar.BackgroundImageLayout = ImageLayout.Zoom;
            btnIngresar.FlatStyle = FlatStyle.Popup;
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(520, 340);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(102, 55);
            btnIngresar.TabIndex = 6;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(95, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 189);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(200, 40);
            label1.Name = "label1";
            label1.Size = new Size(264, 48);
            label1.TabIndex = 8;
            label1.Text = "INICIAR SESION";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonSalir);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-18, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 422);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(277, 83);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 12;
            label4.Text = "Grupazo AC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 316);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 11;
            label3.Text = "Salir";
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Transparent;
            buttonSalir.BackgroundImage = (Image)resources.GetObject("buttonSalir.BackgroundImage");
            buttonSalir.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.ForeColor = SystemColors.ControlText;
            buttonSalir.Location = new Point(30, 340);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(102, 55);
            buttonSalir.TabIndex = 10;
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(540, 316);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 9;
            label2.Text = "Ingresar";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 407);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grupazo AC: Login";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnIngresar;
        private TextBox txtUser;
        private TextBox txtPass;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button buttonSalir;
        private Label label3;
        private Label label4;
    }
}
