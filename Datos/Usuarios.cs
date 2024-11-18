using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using MySqlX.XDevAPI;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TP1.Datos
{
    internal class Usuarios
    {
        // creamos un metodo que retorne una tabla con la informacion
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);// el comando es un elemento que almacena en este caso el nombre del procedimiento almacenado y la referencia a la conexion


                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu; // definimos los parametros que tiene el procedure
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu; // definimos los parametros que tiene el procedure


                sqlCon.Open(); // abrimos la conexion

                resultado = comando.ExecuteReader(); // almacenamos el resulatdo en la variable

                tabla.Load(resultado); // cargamos la tabla con elresultado

                return tabla; // de esta forma esta asociado el metodo con el procedure que estaalmacenado en MySQL
            }

            catch (Exception)
            {
                MessageBox.Show("Error fatal: no se pudo establecer conexion con la base de datos.\nEl programa se cerrara.", "MENSAJES DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
                throw;
            }

            finally // como proceso final
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }
    }
}
