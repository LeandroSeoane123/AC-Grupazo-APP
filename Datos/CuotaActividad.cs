using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Datos
{
    internal class CuotaActividad
    {
        public DataTable pagar_CuotaActividad(string dni, string formaDePago, string nombreAct)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("PagarActividad", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("dniNoSocio", MySqlDbType.VarChar).Value = dni;
                comando.Parameters.Add("formaDePago", MySqlDbType.VarChar).Value = formaDePago;
                comando.Parameters.Add("nombreActividad", MySqlDbType.VarChar).Value = nombreAct;

                sqlCon.Open();

                resultado = comando.ExecuteReader();

                tabla.Load(resultado);

                return tabla;
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
