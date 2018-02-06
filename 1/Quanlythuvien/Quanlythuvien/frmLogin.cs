using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlythuvien
{
    public partial class frmLogin : Form
    {
        public static bool isThanhCong = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDN = txtUserName.Text;
            string pass = txtPassword.Text;
            if(tenDN == "admin" && pass == "admin")
            {
                isThanhCong = true;
                frmMain frmMain = new frmMain();
                frmMain.ShowDialog();
                this.Close();
            }
            else
            {
                isThanhCong = false;
                this.Close();
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
