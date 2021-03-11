using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProyectoInventario
{
    public class connection
    {
        public static SqlConnection getConnection()
        {
            SqlConnection ocon = new SqlConnection("Data Source=DESKTOP-3AO6C47;Initial Catalog=BaseDatosInventario;Integrated Security=True");
            ocon.Open();
            return ocon;
        }
    }
}