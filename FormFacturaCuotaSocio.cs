using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class FormFacturaCuotaSocio : Form
    {

        public string? nombreSocio;
        public string? dniSocio;
        public string? formaDePagoSocio;
        public string? montoSocio;
        public DateTime fecha = System.DateTime.Now;

        public FormFacturaCuotaSocio(string nombre, string dni, string formaDePago, string monto)
        {
            InitializeComponent();
            nombreSocio = nombre;
            dniSocio = dni;
            formaDePagoSocio = formaDePago;
            montoSocio = monto;
        }

        private void FormFacturaCuotaSocio_Load(object sender, EventArgs e)
        {
            label11.Text = nombreSocio;
            label13.Text = dniSocio;
            label14.Text = formaDePagoSocio;
            label12.Text = "$" + montoSocio;
            label15.Text = fecha.ToString();
            this.ControlBox = false;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            buttonImprimir.Visible = false;
            label8.Visible = false;
            buttonVolver.Visible = false;
            label20.Visible = false;

            PrintDocument pd = new PrintDocument();

            try
            {
                pd.PrintPage += new PrintPageEventHandler(imprimirForm1);

                pd.Print();
            }

            catch (Exception)
            {
                MessageBox.Show("ERROR: No hay ninguna impresora conectada para imprimir", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonImprimir.Visible = true;
                label8.Visible = true;
                buttonVolver.Visible = true;
                label20.Visible = true;
                return;
            }


            buttonImprimir.Visible = true;
            label8.Visible = true;
            buttonVolver.Visible = true;
            label20.Visible = true;

            MessageBox.Show("Impresion exitosa.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void imprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e?.Graphics?.DrawImage(img, p);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
