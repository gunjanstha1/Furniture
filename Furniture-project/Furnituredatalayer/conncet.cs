using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace Furnituredatalayer
{
   public class conncet
    {
        private static string connectionstr = ConfigurationSettings.AppSettings["dataconnection"];
        public static string Connectionstr
        {
            get { return connectionstr; }
            set { connectionstr = value; }

        }
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(conncet.Connectionstr);

            if (con.State != ConnectionState.Open )
            {
                con.Open();
            }
            return con;
        }


    }
}
