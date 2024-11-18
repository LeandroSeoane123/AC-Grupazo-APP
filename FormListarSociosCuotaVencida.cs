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
    public partial class FormListarSociosCuotaVencida : Form
    {
        public FormListarSociosCuotaVencida()
        {
            InitializeComponent();
        }

        private void FormListarSociosCuotaVencida_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        public void cargarGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            DataTable tabla = new DataTable();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("listarSociosCuotaVencida", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                sqlCon.Open();

                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

                adaptador.Fill(tabla);

                dataGridView1.DataSource = tabla;

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

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
