using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Bd
{
    public class Conexion
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;
        
        public Conexion()
        {
            try
            {
                cnn = new SqlConnection("Data Source=.;Initial Catalog=OnBreak;Integrated Security=True");
                cnn.Open();
                Console.WriteLine("no se encontro conexion");
            }
            catch(Exception ex)
            {
                   Console.WriteLine("no s")             
            }
        }

    }
}
