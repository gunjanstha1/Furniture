using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_project.Sales
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void dataGridViewBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Billing_FormClosing(object sender, FormClosingEventArgs e)
        {
            sales obj = new sales();
            obj.MdiParent = MdiParent;
            obj.Show();
            Hide();
        }

        private void dataGridViewBilling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                productlist obj = new productlist();
                obj.MdiParent = MdiParent;
                obj.Show();

            }
        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }
    }
}
