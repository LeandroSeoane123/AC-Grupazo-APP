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
    internal class Cliente
    {
        public DataTable agregar_NuevoCliente (string dni, string nombre, string apellido, string nacimiento, string tel, string email, string tipo_c)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("NuevoCliente", sqlCon);

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("Dni", MySqlDbType.VarChar).Value = dni;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = apellido;
                comando.Parameters.Add("Nacimiento", MySqlDbType.VarChar).Value = nacimiento;
                comando.Parameters.Add("Tel", MySqlDbType.VarChar).Value = tel;
                comando.Parameters.Add("Email", MySqlDbType.VarChar).Value = email;
                comando.Parameters.Add("Tipo_c", MySqlDbType.VarChar).Value = tipo_c;

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