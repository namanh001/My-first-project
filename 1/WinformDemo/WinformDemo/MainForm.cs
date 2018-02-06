using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinformDemo.FORMs;
using WinformDemo.UCs;

namespace WinformDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap frmDangNhap = new DangNhap();
            frmDangNhap.ShowDialog();

            if(DangNhap.isThanhCong)
            {
                // Lấy dữ liệu ở đây và đổ vào datagridview bên kia
                try
                {
                    DataTable dt = new DataTable();
                    sqlQuery truyvanDL = new sqlQuery();
                    dt = truyvanDL.LayDuLieu("SELECT * FROM SinhVien");

                    ucDSSV ucDanhSachSV = new ucDSSV(dt);
                    ucDanhSachSV.Dock = DockStyle.Fill;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(ucDanhSachSV);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ucPicture ucAnh = new ucPicture();
            ucAnh.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ucAnh);
        }
    }
}
