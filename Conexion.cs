using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Testing2
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            bool isOpen = false;
            SqlConnection Conn = new SqlConnection("Data source=Ruben-PC\\SQLEXPRESS; Initial Catalog=DB_Testing; Integrated Security=SSPI");
            do
            {
                try
                {
                    Conn.Open();
                    isOpen = true;
                }
                catch (Exception error)
                {
                }
            }
            while (!isOpen);
            return Conn;
        }
    }
}
