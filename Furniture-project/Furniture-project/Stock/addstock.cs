using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Furnituredatalayer;


namespace Furniture_project.Stock
{
    public partial class addstock
        : Form
    {
        public addstock()
        {
            InitializeComponent();
        }

        FDLcategory fdlcat = new FDLcategory();
        FDLproduct fdlprod = new FDLproduct();

        private void addstock_Load(object sender, EventArgs e)
        {

            // loading category list into drop down list
           
            DataTable dt = fdlcat.getcategories();
            if (dt.Rows.Count>0)
            {
                DataRow row = dt.NewRow();
               
                ddlstockcategory.DataSource = dt;
                ddlstockcategory.DisplayMember = "Categoryname";
                ddlstockcategory.ValueMember = "Categoryid";
            }
           

        }

        private void addstock_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stock.stock obj = new Stock.stock();
            obj.MdiParent = MdiParent;
            obj.Show();
            

        }

        
        private void btnaddstock_Click(object sender, EventArgs e)
        {           
                int i = fdlprod.Addproduct(Convert.ToInt32(ddlstockcategory.SelectedValue.ToString()),
             txtstockname.Text, Convert.ToInt32(txtstockquantity.Text), Convert.ToInt32(txtstockprice.Text));

                if (i > 0)
                {
                    MessageBox.Show("Product added to your stock. Thank you.");
                
                    txtstockname.Text = "";
                    txtstockquantity.Text = "";
                    txtstockprice.Text = "";
                    ddlstockcategory.Focus();
                }
            

           
        }

        private void ddlstockcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncanceladdstock_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnewproduct_Click(object sender, EventArgs e)
        {
           
        }
    }
}
