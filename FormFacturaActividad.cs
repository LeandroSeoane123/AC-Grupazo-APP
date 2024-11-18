using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Datos;

namespace TP1
{
    public partial class FormFacturaActividad : Form
    {
        public string? nombreCliente;
        public string? dniCliente;
        public string? actividadCliente;
        public string? montoCliente;
        public string? formaDePagoCliente;
        public DateTime fecha = System.DateTime.Now;

        public FormFacturaActividad(string dni, string actividad, string formaDePago, string monto)
        {
            InitializeComponent();
            dniCliente = dni;
            actividadCliente = actividad;
            formaDePagoCliente = formaDePago;
            montoCliente = monto;
        }

        private void FormFacturaActividad_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = $"Select CONCAT(nombre, ' ', apellido) from Cliente as c where '{dniCliente}' = c.dni";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        nombreCliente = reader.GetString(0);
                    }
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Error al conectar a la base de datos");
                throw;
            }

            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }

            label11.Text = nombreCliente;
            label13.Text = dniCliente;
            label14.Text = actividadCliente;
            label15.Text = "$" + montoCliente;
            label16.Text = fecha.ToString(); ;
            label12.Text = formaDePagoCliente;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            buttonImprimir.Visible = false;
            label18.Visible = false;
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
                label18.Visible = true;
                buttonVolver.Visible = true;
                label20.Visible = true;
                return;
            }


            buttonImprimir.Visible = true;
            label18.Visible = true;
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

