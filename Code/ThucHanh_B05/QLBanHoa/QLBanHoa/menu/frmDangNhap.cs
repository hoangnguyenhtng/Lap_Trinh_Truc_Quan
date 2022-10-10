using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHoa.menu
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        string strconnect = "Data Source=TRANHUYHIEP;Initial Catalog=BanHang;Integrated Security=True";

        SqlConnection sqlConnection = new SqlConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = classes.ReadData("");
        }
    }
}
