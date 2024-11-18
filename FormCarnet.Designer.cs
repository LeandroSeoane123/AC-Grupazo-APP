namespace TP1
{
    partial class FormCarnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarnet));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(19, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(178, 166);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(222, 12);
            label1.Name = "label1";
            label1.Size = new Size(250, 34);
            label1.TabIndex = 1;
            label1.Text = "Athletic Club Grupazo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 202);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(222, 61);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 3;
            label3.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(222, 98);
            label4.Name = "label4";
            label4.Size = new Size(106, 25);
            label4.TabIndex = 4;
            label4.Text = "N° de socio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(222, 135);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 5;
            label5.Text = "Socio desde:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-7, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 253);
            panel2.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(222, 174);
            label7.Name = "label7";
            label7.Size = new Size(115, 25);
            label7.TabIndex = 8;
            label7.Text = "N° de carnet:";
            // 
            // FormCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 243);
            Controls.Add(panel2);
            Name = "FormCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AC Grupazo: Carnet de socio";
            Load += FormCarnet_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Label label7;
    }
}