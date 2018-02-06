using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Quanlythuvien
{
    public partial class frmDocgia : Form
    {
        public frmDocgia()
        {
            InitializeComponent();
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {

        }

        private void frmDocgia_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
           // con.ConnectionString = Laydulieu
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }
    }
}
