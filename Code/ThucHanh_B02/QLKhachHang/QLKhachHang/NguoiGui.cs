using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKhachHang
{
    internal class NguoiGui
    {
        private int ma;
        private String ten;
        private String diaChi;
        private double soTienGui;
        private String ngayGui;
        private int thoiGianGui;

        public NguoiGui()
        {
        }

        public NguoiGui(int ma, string ten, string diaChi, double soTienGui, string ngayGui, int thoiGianGui)
        {
            this.ma = ma;
            this.ten = ten;
            this.diaChi = diaChi;
            this.soTienGui = soTienGui;
            this.ngayGui = ngayGui;
            this.thoiGianGui = thoiGianGui;
        }

        public int Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public double SoTienGui { get => soTienGui; set => soTienGui = value; }
        public string NgayGui { get => ngayGui; set => ngayGui = value; }
        public int ThoiGianGui { get => thoiGianGui; set => thoiGianGui = value; }

    }
}
