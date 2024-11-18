using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace TP1.Datos
{
    public class Conexion
    {
        private string nombre;
        public string servidor;
        private int puerto;
        private string usuario;
        private string pass;
        private static Conexion? con = null;

        private Conexion()
        {

            nombre = "GrupazoAC_DB";
            servidor = "localhost";
            puerto = 3306;
            usuario = "root";
            pass = "Nadielasabe2024";

            bool correcto = false;
            int mensaje;
            string T_servidor = "localhost";
            string T_puerto = "3306";
            string T_usuario = "root";
            int T_puertoAux;
            string T_clave = "Nadielasabe2024";

            while (correcto != true)
            {
                mensaje = (int)MessageBox.Show("Datos de conexion a la base de datos:" +
                                               "\n\nSERVIDOR: " + T_servidor + "" +
                                               "\nPUERTO: " + T_puerto +
                                               "\nUSUARIO: " + T_usuario +
                                               "\nCLAVE: " + T_clave +
                                               "\n\n¿Son correctos?",
                                               "MENSAJES DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (mensaje != 6)
                {
                    MessageBox.Show("Por favor, ingrese los datos correctos");
                    T_servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                    T_puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                    while (string.IsNullOrEmpty(T_puerto) || !int.TryParse(T_puerto, out T_puertoAux))
                    {
                        MessageBox.Show("No se permiten letras ni espacios en blanco en este campo." +
                                      "\nPor favor ingrese un valor numerico valido.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        T_puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese puerto", "DATOS DE INSTALACIÓN MySQL");

                    }
                    T_usuario = Microsoft.VisualBasic.Interaction.InputBox("ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                    T_clave = Microsoft.VisualBasic.Interaction.InputBox("ingrese clave", "DATOS DE INSTALACIÓN MySQL");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }

            this.servidor = T_servidor;
            this.puerto = Convert.ToInt32(T_puerto);
            this.usuario = T_usuario;
            this.pass = T_clave;
        }

        public MySqlConnection CrearConexion()
        {

            MySqlConnection? cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + servidor +
                ";port=" + puerto +
                ";username=" + usuario +
                ";password=" + pass +
                ";Database=" + nombre;

            }

            catch (Exception)
            {
                Console.WriteLine("Error al conectar a la base de datos");
                cadena = null;
                throw;
            }
            return cadena;
        }
        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}

