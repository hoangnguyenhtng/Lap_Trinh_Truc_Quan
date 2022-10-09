using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH4_CoSoDuLieu
{
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            InitializeComponent();
        }

        classes.DataBaseProcess dataBaseProcess = new classes.DataBaseProcess();

        private void hienChiTiet(bool hien)
        {
            txtMaSP.Enabled = hien;
            txtTenSP.Enabled = hien;
            dtpNgayHH.Enabled = hien;
            dtpNgaySX.Enabled = hien;
            txtDonVi.Enabled = hien;
            txtDonGia.Enabled = hien;
            txtGhiChu.Enabled = hien;
            //Ẩn hiện 2 nút Lưu và Hủy
            btnLuu.Enabled = hien;
            btnHuy.Enabled = hien;
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            dgvMatHang.DataSource = dataBaseProcess.DataReader("select * from tblMatHang");
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            hienChiTiet(false);
        }
    }
}
