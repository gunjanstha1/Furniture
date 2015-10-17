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
    public partial class adminmaster : Form
    {
        public adminmaster()
        {
            InitializeComponent();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock.stock obj = new Stock.stock();
            obj.MdiParent = this;
            obj.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales obj = new sales();
            obj.MdiParent = this;
            obj.Show();
        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase obj = new Purchase();
            obj.MdiParent = this;
            obj.Show();
        }

        private void partyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            party obj = new party();
            obj.MdiParent = this;
            obj.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void monthlyWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empoyee.monthlyworker obj = new Empoyee.monthlyworker();
            obj.MdiParent = this;
            obj.Show();
        }

        private void thekkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empoyee.thekkaworker obj = new Empoyee.thekkaworker();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
