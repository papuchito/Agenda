using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace agenda12
{
    internal class Conexion
    {
        public static SqlConnection Connection()
        {
            SqlConnection cn = new SqlConnection("Data Source=LAPTOP-HQ961OQ0\\PAPUCHITO;Initial Catalog=REGISTRO;Integrated Security=True");
            cn.Open();
            return cn;
        }
    }
}
