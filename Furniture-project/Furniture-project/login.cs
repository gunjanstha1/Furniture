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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtadmin.Text == "admin" & txtpassword.Text == "admin")
                {
                      adminmaster obj = new adminmaster();
                          obj.Show();
                         this.Hide();                  
            }
            else
                {
                     MessageBox.Show("Invalid User");
                    txtadmin.Text = "";
                    txtpassword.Text = "";
                    txtadmin.Focus();

                }

        }

        private void lbladmin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
