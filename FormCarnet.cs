using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1.Datos;

namespace TP1
{
    public partial class FormCarnet : Form
    {

        string? nombreSocio;
        string? dniSocio;
        int? numeroDeSocio;
        DateTime fechaIngresoSocio;
        int? numeroCarnetSocio;

        public FormCarnet(string dni, string nombre)
        {
            InitializeComponent();
            dniSocio = dni;
            nombreSocio = nombre;
        }

        private void FormCarnet_Load(object sender, EventArgs e)
        {
            cargarDatosDeSocio();
            label2.Text = nombreSocio;
            label3.Text = "DNI: " + dniSocio;
            label4.Text = "N° de Socio: " + numeroDeSocio.ToString();
            label5.Text = "Socio desde: " + fechaIngresoSocio.ToString("dd/MM/yyyy");
            label7.Text = "N° de carnet: " + numeroCarnetSocio.ToString();
        }

        void cargarDatosDeSocio()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = $"Select numero_socio, fecha_ingreso, numero_carnet from Socio as s where '{dniSocio}' = s.dni";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        numeroDeSocio = reader.GetInt32(0);
                        fechaIngresoSocio = reader.GetDateTime(1);
                        numeroCarnetSocio = reader.GetInt32(2);
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
        }

    }
}
