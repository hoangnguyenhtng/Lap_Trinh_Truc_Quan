using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHoa.menu
{
    public partial class frmHDBan : Form
    {
        classes.CommonFunctions commonFunction = new classes.CommonFunctions();
        classes.ConnectData connectData = new classes.ConnectData();
        public frmHDBan()
        {
            InitializeComponent();
            DataTable dtNhanVien = connectData.ReadData("Select * from tblNhanVien");
            DataTable dtKh = connectData.ReadData("select * from tblKhachHang");
            DataTable dtHang = connectData.ReadData("select * from tblHang");
            DataTable dtHDBan = connectData.ReadData("select * from tblHDBan");
            commonFunction.FillComboBox(cboMaNV, dtNhanVien, "MaNhanVien", "MaKhach");
            commonFunction.FillComboBox(cboMaKhach, dtKh, "MaKhach", "MaKhach");
            commonFunction.FillComboBox(cboMaHang, dtHang, "MaHang", "MaHang");
            commonFunction.FillComboBox(cboMaHD, dtHDBan, "MaHDBan", "MaHDBan");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void frmHDBan_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dtHDBan = connectData.ReadData("select * from tblHDBan where MaHDBan='" + cboMaHD.Text + "'");
            DataTable dtChiTietHDBan = connectData.ReadData("select tblChiTietHDBan.MaHang, TenHang, tblChiTietHDBan.SoLuong, " +
                "DonGiaBan, GiamGia, ThanhTien from tblChiTietHDBan inner join tblHang on tblChiTietHDBan.MaHang = tblHang.MaHang" +
                " where MaHDBan='" + cboMaHD.Text + "'");
            txtMaHD.Text = cboMaHD.Text;
            dateNgayBan.Text = dtHDBan.Rows[0]["NgayBan"].ToString();
            cboMaNV.SelectedValue = dtHDBan.Rows[0]["MaNhanVien"];
            cboMaKhach.SelectedValue = dtHDBan.Rows[0]["MaKhach"];
            dgvChiTietHD.DataSource = dtChiTietHDBan;
            txtTongTien.Text = dtHDBan.Rows[0]["TongTien"].ToString(); 

        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNV = connectData.ReadData("select TenNhanVien from tblNhanVien" +
                    " where MaNhanVien='" + cboMaNV + "'");
                txtTenNhanVien.Text = dtNV.Rows[0]["TenKhach"].ToString();
            }
            catch
            {

            }

        }

        private void cboMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtKH = connectData.ReadData("select * from tblKhach where " +
                    "MaKach = '" + cboMaKhach.SelectedValue + "'");
                txtTenKhach.Text = dtKH.Rows[0]["TenNhanVien"].ToString();
                txtDiaChi.Text = dtKH.Rows[0]["DonGiaBan"].ToString();
            } catch
            {

            }

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) )
            {
                MessageBox.Show("Bạn chỉ nhập sô nguyên!");
                e.Handled = true;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            float sl, dg, gg, tt;
            if(txtGiamGia.Text.Trim() == "")
            {
                gg = 0;
            } 
            else
            {
                gg = float.Parse(txtGiamGia.Text);
            }
            if(txtSoLuong.Text.Trim() == "")
            {
                sl = 0;
            }
            else
            {
                sl = float.Parse(txtSoLuong.Text);
            }
            dg = float.Parse(txtDonGia.Text);
            tt = dg * sl * ((1 - gg) / 100);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = commonFunction.AutoCode("tblHDBan", "MaHDBan", "HDB" +
                DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() +
                DateTime.Now.Year.ToString());
        }
        void ResetValue()
        {
            txtMaHD.Text = "";
            dateNgayBan.Text = "";
            cboMaHang.Text = "";
            cboMaKhach.Text = "";
            txtTenHang.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtDonGia.Text = "";
            txtGiamGia.Text = "";
            txtMaHD.Text = "";
            txtTongTien.Text = "";
            txtThanhTien.Text = "";
            dgvChiTietHD.DataSource = null;
        }
    }
}
