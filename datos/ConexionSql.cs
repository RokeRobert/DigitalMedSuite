using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace datos
{
    public class ConexionSql
    {

        static string conexionstring = "server= localhost ; database= DigitalMedSuite, integrated security=true";
        SqlConnection conexion = new SqlConnection(conexionstring);

        public int consultalogin(string Usuario,string contrasena)
        {
            int count;
            conexion.Open();
            string Query = "Select Count(*) From Usuario where correo = '" + Usuario + "' and contrasena = '" + contrasena + "'";
            SqlCommand cmd = new SqlCommand(Query, conexion);
            count=Convert.ToInt32(cmd.ExecuteScalar());

            conexion.Close();
            return count;
        }

    }
}
