using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furniture_project.Party
{
    public partial class Addparty : Form
    {
        public Addparty()
        {
            InitializeComponent();
        }

        private void lbladdpartyname_Load(object sender, EventArgs e)
        {

        }

        private void Addparty_FormClosed(object sender, FormClosedEventArgs e)
        {
            party obj = new party();
            obj.MdiParent = MdiParent;
            obj.Show();
            
           

        }
    }
}
