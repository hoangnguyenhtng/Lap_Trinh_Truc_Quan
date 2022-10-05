using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_BaiTapTiengAnh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bàiĐiềnTừ1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaiTapDienTu formBaiTapDienTu = new FormBaiTapDienTu();
            formBaiTapDienTu.MdiParent = this;
            formBaiTapDienTu.Show();
        }
    }
}
