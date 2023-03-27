using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnbd
{
    public class Class1
    {
        SqlConnection conexion = new SqlConnection(@"Server =XX; Database =XX; User ID=XX; PWD=XX");

        public class infoEmpleado
        {
            public string nom { get; set; }

            public string ape { get; set; }
            public string num { get; set; }
        }

        public infoEmpleado empleado(string numero)
        {

            SqlDataReader read;
            try
            {

                conexion.Open();
                SqlCommand command = new SqlCommand("SELECT  [Nombre],[Apellido],[Numero] FROM  [ITSystem].[dbo].[Empleados] where numero='" + numero + "'", conexion);

                command.CommandType = System.Data.CommandType.Text;
                command.ExecuteNonQuery();

                read = command.ExecuteReader();
                if (read.Read())
                {

                    infoEmpleado empl = new Class1.infoEmpleado();

                    empl.nom = read.GetString(0);
                    empl.ape = read.GetString(1);
                    empl.num = read.GetString(2);

                    return empl;

                }
                else
                {
                    conexion.Close();
                    return null;
                }

            }
            catch(Exception ex)
            {

                return null;
            }
        
        }
    }
}
