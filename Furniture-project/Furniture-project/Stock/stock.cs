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
using System.Data.SqlClient;



namespace Furniture_project.Stock
{
    public partial class stock : Form
    {
        //FDLproduct fdlprodforSearh = new FDLproduct();
        FDLproduct fdlprod = new FDLproduct();


        public stock()
        {
            InitializeComponent();
        }

        private void btnsearchstock_Click(object sender, EventArgs e)
        {
            
                Int32 selectedCategoryId = Convert.ToInt32(ddlsearchstockcategory.SelectedValue.ToString());
                string productName = txtsearchstock.Text.ToString();
                var seachedDataTable = fdlprod.searchProductByProductName(selectedCategoryId, productName);
                seachedDataTable = (seachedDataTable.Rows.Count > 0) ? seachedDataTable : null;
                dataGridViewstock.AutoGenerateColumns = false;
                dataGridViewstock.DataSource = seachedDataTable;
           
        }

        private void btnaddstock_Click(object sender, EventArgs e)
        {
            addstock obj = new addstock();
            obj.MdiParent = MdiParent;
            obj.Show();
            Hide();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        FDLcategory fdlcat = new FDLcategory();

        private void stock_Load(object sender, EventArgs e)
        {
            loadgrid();

            // loading category list into drop down list

            DataTable dt = fdlcat.getcategories();
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.NewRow();
                ////row["Categoryname"] = "Select Category";
                //dt.Rows.InsertAt(row, 0);

                ddlsearchstockcategory.DataSource = dt;
                ddlsearchstockcategory.DisplayMember = "Categoryname";
                ddlsearchstockcategory.ValueMember = "Categoryid";
            }
        }

        //MAKING A FUNCTION TO SHOW THE DATA IN THE GRID OF STOCK


        public void loadgrid()
        {
            DataTable dt = fdlprod.getallproduct();
            if (dt.Rows.Count > 0)
            {
                dataGridViewstock.AutoGenerateColumns = false;
                dataGridViewstock.DataSource = dt;

            }
        }



        private void dataGridViewstock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewstock_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridViewstock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (MessageBox.Show("Are You Sure ??", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("delete");
            }
            //}

            if (e.ColumnIndex == 4)
            {
                updatestock update = new updatestock();

                update.ddlstockcategory.Text = dataGridViewstock.CurrentRow.Cells[0].Value.ToString();
                update.txtstocknameupdate.Text = dataGridViewstock.CurrentRow.Cells[1].Value.ToString();
                update.txtstockquantityupdate.Text = dataGridViewstock.CurrentRow.Cells[2].Value.ToString();
                update.txtstockpriceupdate.Text = dataGridViewstock.CurrentRow.Cells[3].Value.ToString();

                update.MdiParent = MdiParent;
                update.Show();


            }

        }
    }
}
