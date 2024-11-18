using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Datos;

namespace TP1.Datos
{
    internal class Actividad
    {
        public DataTable asignar_Actividad(string nombreAct, string dniCliente)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("AsignarActividad", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("nombreAct", MySqlDbType.VarChar).Value = nombreAct;
                comando.Parameters.Add("dniCliente", MySqlDbType.VarChar).Value = dniCliente;

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

        public DataTable verificar_SiEsSocio(string dni)
        {
            DataTable tablaSocios = new DataTable();
            MySqlDataReader resultado;
            MySqlConnection sqlCon1 = new MySqlConnection();

            try
            {
                string query;
                sqlCon1 = Conexion.getInstancia().CrearConexion();
                query = $"Select * from Socio as s where s.dni = {dni};";

                MySqlCommand comando = new MySqlCommand(query, sqlCon1);
                comando.CommandType = CommandType.Text;
                sqlCon1.Open();

                resultado = comando.ExecuteReader();

                tablaSocios.Load(resultado);

                return tablaSocios;
            }

            catch (Exception)
            {
                Console.WriteLine("Error al conectar a la base de datos");
                throw;
            }

            finally
            {
                if (sqlCon1.State == ConnectionState.Open)
                { sqlCon1.Close(); };
            }
        }
    }
}
