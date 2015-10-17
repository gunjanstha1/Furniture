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

   
 
    public partial class updatestock : Form
    {
        FDLcategory fdlcat = new FDLcategory();
        FDLproduct fdlprod = new FDLproduct();
        public updatestock()
        {
            InitializeComponent();
        }

        private void updatestock_Load(object sender, EventArgs e)
        {
            // loading category list into drop down list

            DataTable dt = fdlcat.getcategories();
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.NewRow();

                ddlstockcategory.DataSource = dt;
                ddlstockcategory.DisplayMember = "Categoryname";
                ddlstockcategory.ValueMember = "Categoryid";
            }

        }

        private void btncancelupdatestock_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnupdatestock_Click(object sender, EventArgs e)
        {
            //code for updating the data in database
            //int i = fdlprod.updateProduct(Convert.ToInt32(ddlstockcategory.Text), txtstocknameupdate.Text, Convert.ToInt32(txtstockquantityupdate.Text), Convert.ToInt32(txtstockpriceupdate.Text));
            //if(i>0)
            //{
            //    MessageBox.Show("product Updated Success!!");
            //    stock obj = new stock();
            //    obj.MdiParent = MdiParent;
            //    obj.Show();
            //    Hide();
            //}

        }
    }
}
