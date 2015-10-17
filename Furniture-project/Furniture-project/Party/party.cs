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
    public partial class party : Form
    {
        public party()
        {
            InitializeComponent();
        }

        private void btnaddnewparty_Click(object sender, EventArgs e)
        {

            Party.Addparty obj = new Party.Addparty();
            obj.MdiParent = MdiParent;
            obj.Show();
            this.Hide();

            
        }

        private void party_Load(object sender, EventArgs e)
        {

        }
    }
}
