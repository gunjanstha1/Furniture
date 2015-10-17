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


namespace Furniture_project.Sales
{
    public partial class productlist : Form
    {
        public productlist()
        {
            InitializeComponent();
        }
        FDLproduct fdlprod = new FDLproduct();
        private void productlist_Load(object sender, EventArgs e)
        {
            DataTable dt = fdlprod.getallproduct();
            if (dt.Rows.Count > 0)
            {
                dataGridViewsalesproductlist.AutoGenerateColumns = false;
                dataGridViewsalesproductlist.DataSource = dt;

            }
        }

        private void dataGridViewsalesproductlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                Billing bill = new Billing();


                bill.MdiParent = MdiParent;
                bill.Show();
                Hide();

            }
        }
    }
}
