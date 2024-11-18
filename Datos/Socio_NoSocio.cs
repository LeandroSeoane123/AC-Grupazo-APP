using MySql.Data.MySqlClient;
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
    internal class Socio_NoSocio
    {

        public void agregarSocio_O_NoSocio(string dni, string tipo_c)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("NuevoSocioONoSocio", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Dni", MySqlDbType.VarChar).Value = dni;
                comando.Parameters.Add("Tipo_c", MySqlDbType.VarChar).Value = tipo_c;

                sqlCon.Open();

                resultado = comando.ExecuteReader();

                tabla.Load(resultado);

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
