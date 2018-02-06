using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDemo.UCs
{
    public partial class ucDSSV : UserControl
    {
        // Khai báo 1 biến toàn cục để lưu trữ bảng dữ liệu
        DataTable m_dataTable = new DataTable();

        public ucDSSV(DataTable dt)
        {
            m_dataTable = dt; // gán cho biến toàn cục            
            InitializeComponent();

            dataGridView1.DataSource = m_dataTable;
        }

        private void ucDSSV_Load(object sender, EventArgs e)
        {
            // Đổ dữ liệu vào trong dataGridview
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy dòng đang được chọn
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dataGridView1.SelectedRows[0].Cells["MaSV"].Value.ToString();
            txtTenSV.Text = dataGridView1.SelectedRows[0].Cells["TenSV"].Value.ToString();
            txtNamSinh.Text = dataGridView1.SelectedRows[0].Cells["NamSinh"].Value.ToString();
            txtQueQuan.Text = dataGridView1.SelectedRows[0].Cells["QueQuan"].Value.ToString();

        }
        public void resetDL()
        {
            DataTable dt = new DataTable();
            sqlQuery truyvanDL = new sqlQuery();
            dt = truyvanDL.LayDuLieu("SELECT * FROM SinhVien");
            dataGridView1.DataSource = dt;
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // Lấy được các giá trị nhập từ các ô text
            string tenSV = txtTenSV.Text;
            string namSinh = txtNamSinh.Text;
            string queQuan = txtQueQuan.Text;
            // Thực hiện câu lệnh truy vấn
            sqlQuery truyvanDL = new sqlQuery();
            string query = "UPDATE SinhVien SET TenSV=N'"+tenSV+"', NamSinh='"+namSinh+"', QueQuan=N'"+queQuan+"' WHERE MaSV='"+txtMaSV.Text+"'";
            truyvanDL.ExecuteNoneQuery(query);
            // Cập nhật lại DataGridview
            resetDL();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtNamSinh.Text = "";
            txtQueQuan.Text = "";
            txtMaSV.Enabled = true;
            

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            // Lấy được các giá trị nhập từ các ô text
            string tenSV = txtTenSV.Text;
            string namSinh = txtNamSinh.Text;
            string queQuan = txtQueQuan.Text;
            // Cập nhật dữ liệu
            sqlQuery truyvanDL = new sqlQuery();
            string query = "insert into SinhVien values('" + txtMaSV.Text + "',N'" + tenSV + "','" + namSinh + "',N'" + queQuan + "')";
            truyvanDL.ExecuteNoneQuery(query);
            // Cập nhật lại DataGridview
            resetDL();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result= MessageBox.Show("Bạn muốn xóa dữ liệu này chứ?", "Xóa dữ liệu",MessageBoxButtons.OKCancel);
            if(result== DialogResult.OK)
            {
                sqlQuery truyvanDL = new sqlQuery();
                string query = "delete from SinhVien Where MaSV='"+txtMaSV.Text+"'";
                truyvanDL.ExecuteNoneQuery(query);
                // Cập nhật lại DataGridview
                resetDL();
            }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}