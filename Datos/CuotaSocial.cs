using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Datos
{
    internal class CuotaSocial
    {
        public DataTable pagar_Cuota(string dni, string formaDePago, string montoAPagar)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            DateTime fechaVencimiento = DateTime.Now;
            fechaVencimiento = fechaVencimiento.AddMonths(1);

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("PagarCuota", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("dniSocio", MySqlDbType.VarChar).Value = dni;
                comando.Parameters.Add("formaDePago", MySqlDbType.VarChar).Value = formaDePago;
                comando.Parameters.Add("montoAPagar", MySqlDbType.VarChar).Value = montoAPagar;
                comando.Parameters.Add("fechaVencimiento", MySqlDbType.VarChar).Value = fechaVencimiento.ToString("yyyy-MM-dd");

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

