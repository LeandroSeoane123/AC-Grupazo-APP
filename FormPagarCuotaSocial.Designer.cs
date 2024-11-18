namespace TP1
{
    partial class FormPagarCuotaSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagarCuotaSocial));
            groupBoxFormaDePago = new GroupBox();
            radioButtonTarjeta = new RadioButton();
            radioButtonEfectivo = new RadioButton();
            label1 = new Label();
            buttonPagar = new Button();
            buttonComprobante = new Button();
            textBoxMonto = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            buttonCarnet = new Button();
            label10 = new Label();
            buttonVolver = new Button();
            label3 = new Label();
            groupBoxFormaDePago.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxFormaDePago
            // 
            groupBoxFormaDePago.BackColor = Color.Transparent;
            groupBoxFormaDePago.Controls.Add(radioButtonTarjeta);
            groupBoxFormaDePago.Controls.Add(radioButtonEfectivo);
            groupBoxFormaDePago.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxFormaDePago.Location = new Point(19, 124);
            groupBoxFormaDePago.Name = "groupBoxFormaDePago";
            groupBoxFormaDePago.Size = new Size(228, 132);
            groupBoxFormaDePago.TabIndex = 0;
            groupBoxFormaDePago.TabStop = false;
            groupBoxFormaDePago.Tag = "";
            groupBoxFormaDePago.Text = "Forma de pago";
            // 
            // radioButtonTarjeta
            // 
            radioButtonTarjeta.AutoSize = true;
            radioButtonTarjeta.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonTarjeta.Location = new Point(47, 80);
            radioButtonTarjeta.Name = "radioButtonTarjeta";
            radioButtonTarjeta.Size = new Size(72, 24);
            radioButtonTarjeta.TabIndex = 2;
            radioButtonTarjeta.TabStop = true;
            radioButtonTarjeta.Text = "Tarjeta";
            radioButtonTarjeta.UseVisualStyleBackColor = true;
            // 
            // radioButtonEfectivo
            // 
            radioButtonEfectivo.AutoSize = true;
            radioButtonEfectivo.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonEfectivo.Location = new Point(47, 37);
            radioButtonEfectivo.Name = "radioButtonEfectivo";
            radioButtonEfectivo.Size = new Size(80, 24);
            radioButtonEfectivo.TabIndex = 1;
            radioButtonEfectivo.TabStop = true;
            radioButtonEfectivo.Text = "Efectivo";
            radioButtonEfectivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(99, 69);
            label1.Name = "label1";
            label1.Size = new Size(304, 37);
            label1.TabIndex = 1;
            label1.Text = "PAGAR CUOTA SOCIAL";
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = Color.Transparent;
            buttonPagar.BackgroundImage = (Image)resources.GetObject("buttonPagar.BackgroundImage");
            buttonPagar.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPagar.FlatStyle = FlatStyle.Popup;
            buttonPagar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPagar.Location = new Point(306, 207);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(145, 61);
            buttonPagar.TabIndex = 4;
            buttonPagar.UseVisualStyleBackColor = false;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // buttonComprobante
            // 
            buttonComprobante.BackColor = Color.Transparent;
            buttonComprobante.BackgroundImage = (Image)resources.GetObject("buttonComprobante.BackgroundImage");
            buttonComprobante.BackgroundImageLayout = ImageLayout.Zoom;
            buttonComprobante.FlatStyle = FlatStyle.Popup;
            buttonComprobante.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonComprobante.ForeColor = Color.Green;
            buttonComprobante.Location = new Point(379, 308);
            buttonComprobante.Name = "buttonComprobante";
            buttonComprobante.Size = new Size(128, 38);
            buttonComprobante.TabIndex = 5;
            buttonComprobante.UseCompatibleTextRendering = true;
            buttonComprobante.UseVisualStyleBackColor = false;
            buttonComprobante.Visible = false;
            buttonComprobante.Click += buttonComprobante_Click;
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(363, 162);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.PlaceholderText = "Monto en $ARS";
            textBoxMonto.Size = new Size(126, 23);
            textBoxMonto.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(253, 163);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 9;
            label2.Text = "Monto a pagar:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonCarnet);
            panel1.Controls.Add(buttonComprobante);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(buttonVolver);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxMonto);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBoxFormaDePago);
            panel1.Controls.Add(buttonPagar);
            panel1.Location = new Point(-7, -31);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 368);
            panel1.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(264, 289);
            label5.Name = "label5";
            label5.Size = new Size(93, 18);
            label5.TabIndex = 32;
            label5.Text = "Generar carnet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(379, 287);
            label4.Name = "label4";
            label4.Size = new Size(130, 18);
            label4.TabIndex = 31;
            label4.Text = "Mostrar comprobante";
            // 
            // buttonCarnet
            // 
            buttonCarnet.BackColor = Color.Transparent;
            buttonCarnet.BackgroundImage = (Image)resources.GetObject("buttonCarnet.BackgroundImage");
            buttonCarnet.BackgroundImageLayout = ImageLayout.Zoom;
            buttonCarnet.FlatStyle = FlatStyle.Popup;
            buttonCarnet.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCarnet.ForeColor = Color.Green;
            buttonCarnet.Location = new Point(245, 308);
            buttonCarnet.Name = "buttonCarnet";
            buttonCarnet.Size = new Size(128, 38);
            buttonCarnet.TabIndex = 30;
            buttonCarnet.UseCompatibleTextRendering = true;
            buttonCarnet.UseVisualStyleBackColor = false;
            buttonCarnet.Visible = false;
            buttonCarnet.Click += buttonCarnet_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(54, 285);
            label10.Name = "label10";
            label10.Size = new Size(55, 22);
            label10.TabIndex = 29;
            label10.Text = "Volver";
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.Transparent;
            buttonVolver.BackgroundImage = (Image)resources.GetObject("buttonVolver.BackgroundImage");
            buttonVolver.BackgroundImageLayout = ImageLayout.Zoom;
            buttonVolver.FlatStyle = FlatStyle.Popup;
            buttonVolver.Font = new Font("Impact", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonVolver.ForeColor = Color.White;
            buttonVolver.Location = new Point(19, 309);
            buttonVolver.Margin = new Padding(3, 2, 3, 2);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(128, 38);
            buttonVolver.TabIndex = 28;
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(404, 248);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 10;
            label3.Text = "Pagar";
            // 
            // FormPagarCuotaSocial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(512, 327);
            Controls.Add(panel1);
            Name = "FormPagarCuotaSocial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grupazo AC: Pagar cuota social";
            Load += FormPagarCuotaSocial_Load;
            groupBoxFormaDePago.ResumeLayout(false);
            groupBoxFormaDePago.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxFormaDePago;
        private RadioButton radioButtonEfectivo;
        private RadioButton radioButtonTarjeta;
        private Label label1;
        private Button buttonPagar;
        private Button buttonComprobante;
        private TextBox textBoxMonto;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label10;
        private Button buttonVolver;
        private Button buttonCarnet;
        private Label label5;
        private Label label4;
    }
}