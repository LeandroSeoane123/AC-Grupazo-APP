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
    public partial class FormAsignarActividades : Form
    {
        public string monto = "";
        public string nombreActAux = "";
        public FormAsignarActividades()
        {
            InitializeComponent();
        }

        private void AsignarActividades_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            cargarGrilla();
        }

        public void cargarGrilla()
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();
                query = "Select nombre, cupo, precio from Actividad order by nombre;";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();

                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvActividad.Rows.Add();
                        dtgvActividad.Rows[renglon].Cells[0].Value = reader.GetString(0);
                        dtgvActividad.Rows[renglon].Cells[1].Value = reader.GetInt32(1);
                        dtgvActividad.Rows[renglon].Cells[2].Value = "$" + reader.GetDecimal(2);
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA MOSTRAR");
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

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void buttonAsigAct_Click(object sender, EventArgs e)
        {

            if (comboBoxAct.Text == "" || textBoxDNIAct.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (Convert.ToInt64(textBoxDNIAct.Text) >= 1000000 && Convert.ToInt64(textBoxDNIAct.Text) <= 100000000)
                {
                    DataTable tablaSocios = new DataTable();
                    Datos.Actividad dato1 = new Datos.Actividad();
                    tablaSocios = dato1.verificar_SiEsSocio(textBoxDNIAct.Text);

                    if (tablaSocios.Rows.Count > 0)
                    {
                        MessageBox.Show("ERROR:\nLas asignaciones y pagos de actividades son solo para no socios.\nUsted acaba de ingresar un DNI perteneciente a un socio.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataTable tablaAsignarActividad = new DataTable();
                        Datos.Actividad dato2 = new Datos.Actividad();

                        tablaAsignarActividad = dato2.asignar_Actividad(comboBoxAct.Text, textBoxDNIAct.Text);

                        if (tablaAsignarActividad.Rows.Count > 0)
                        {
                            MessageBox.Show("ERROR: no se pudo asignar la actividad.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("Por favor verifique si:\n-El dni ingresado corresponde a un cliente registrado.\n-El cliente no esta registrado ya en la actividad que le desea asignar.\n-La actividad que quiere asignar tiene cupos disponibles.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Asignacion exitosa.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            MySqlConnection sqlCon = new MySqlConnection();
                            try
                            {
                                string query;
                                sqlCon = Conexion.getInstancia().CrearConexion();
                                query = $"Select a.precio from Actividad as a where '{comboBoxAct.Text}' = a.nombre";

                                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                                comando.CommandType = CommandType.Text;
                                sqlCon.Open();

                                MySqlDataReader reader;
                                reader = comando.ExecuteReader();

                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        monto = reader.GetString(0);
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

                            FormPagarActividad pagar = new FormPagarActividad(textBoxDNIAct.Text, comboBoxAct.Text, monto);
                            pagar.ShowDialog();
                            this.Hide();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("El DNI ingresado no esta en el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void textBoxDNIAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
