using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDemo.FORMs
{
    public partial class DangNhap : Form
    {
        public static bool isThanhCong = false;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDN = txtUserName.Text;
            string pass = txtPassword.Text;

            if(tenDN=="admin" && pass=="admin")
            {
                isThanhCong = true;
                MessageBox.Show("Đăng nhập thành công");

                this.Close();
            }
            else
            {
                isThanhCong = false;
                MessageBox.Show("Lỗi đăng nhập");
            }
        }
    }
}
