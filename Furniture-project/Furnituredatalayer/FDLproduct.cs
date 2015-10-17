using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Furnituredatalayer
{
   public class FDLproduct
    {


        //TO ADD NEW PRODUCT AS PER CATEGORY...
        public int Addproduct (int Categoryid, string ProductName, int Quantity, int Price )
        {
            using (SqlConnection con = conncet.GetConnection())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "insert into tblproduct(Categoryid,Productname,Quantity,Price) values (@categoryid,@productname,@quantity,@price)";

                    cmd.Parameters.AddWithValue("@categoryid", Categoryid);
                    cmd.Parameters.AddWithValue("@productname", ProductName);
                    cmd.Parameters.AddWithValue("@quantity", Quantity);
                    cmd.Parameters.AddWithValue("@price", Price);

                    try
                    {
                      return  cmd.ExecuteNonQuery();
                    }

                    catch(Exception ex)

                    { throw ex; }

                }
            }
        }




        //TO SHOW NEW PRODUCTS IN THE GRID VIEW IN STOCK...
          public DataTable getallproduct()
          {

            //DataTable dt = null;
              using (SqlConnection con = conncet.GetConnection())
              {
                  using (SqlCommand cmd = con.CreateCommand())
                  {
                      cmd.CommandText = "select tblcategory.Categoryname, tblproduct.Productname, tblproduct.Quantity, tblproduct.Price from tblcategory Inner Join tblproduct on tblcategory.Categoryid=tblproduct.Categoryid ";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {

                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;

                    }                    
                  }
              }
          }

        //to Update the product in the stock
        //public int updateProduct(int Categoryid, string ProductName, int Quantity, int Price)
        //{
        //    using (SqlConnection con = conncet.GetConnection())
        //    {
        //        using (SqlCommand cmd = con.CreateCommand())
        //        {
        //            cmd.CommandText = "update tblproduct set Categoryid=@categoryid, Productname=@productname, Quantity=@quantity, Price=@price where Categoryid=@categoryid";

        //            cmd.Parameters.AddWithValue("@categoryid", Categoryid);
        //            cmd.Parameters.AddWithValue("@productname", ProductName);
        //            cmd.Parameters.AddWithValue("@quantity", Quantity);
        //            cmd.Parameters.AddWithValue("@price", Price);

        //            try
        //            {
        //                return cmd.ExecuteNonQuery();
        //            }

        //            catch (Exception ex)

        //            { throw ex; }

        //        }
        //    }
        //}



        // search product by product name andcategory
        public DataTable searchProductByProductName(int categoryId, string prodctName)
        {
            
            using(SqlConnection con = conncet.GetConnection())
            {
                using (SqlCommand cmd = con.CreateCommand())
                {
                    prodctName=string.IsNullOrWhiteSpace(prodctName) ? "" : prodctName;
                    cmd.CommandText = "select tblcategory.Categoryname, tblproduct.Productname, tblproduct.Quantity, tblproduct.Price from tblcategory "+ 
                        "Inner Join tblproduct on tblcategory.Categoryid=tblproduct.Categoryid where tblproduct.Categoryid=" + categoryId + " and tblproduct.Productname like '%" + prodctName + "%'";
                    using (SqlDataAdapter da=new SqlDataAdapter(cmd))
                    {
                        DataTable searchProductDataTable = new DataTable();
                        da.Fill(searchProductDataTable);
                        return searchProductDataTable;
                    }
                }
            }



        }




    }
}
