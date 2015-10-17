using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_project
{
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }

        private void btnsalesbilling_Click(object sender, EventArgs e)
        {
            Sales.Billing obj = new Sales.Billing();
            obj.MdiParent = MdiParent;
            obj.Show();
            this.Hide();
        }
    }
}
