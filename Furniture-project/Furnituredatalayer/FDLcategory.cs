using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Furnituredatalayer
{
        
  public class FDLcategory
    {

        //loading category list from database

        public DataTable getcategories()
        {
            DataTable dt = new DataTable();
            string sql = "select * from tblcategory";

            using (SqlConnection con = conncet.GetConnection())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = sql;

                    // parameter


                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        dt = new DataTable();
                        da.Fill(dt);
                        return dt;

                    }
                }
            }
        }



    }
}
