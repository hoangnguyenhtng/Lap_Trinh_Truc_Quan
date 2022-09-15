using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_1
{
    internal class SinhVien
    {
        String hoTen;
        String ngaySinh;
        double dLapTrinh;
        double dCoSoDuLieu;
        double dThietKeWeb;

        public SinhVien()
        {
        }

        public SinhVien(string hoTen, string ngaySinh, double dLapTrinh, double dCoSoDuLieu, double dThietKeWeb)
        {
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.DLapTrinh = dLapTrinh;
            this.DCoSoDuLieu = dCoSoDuLieu;
            this.DThietKeWeb = dThietKeWeb;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public double DLapTrinh { get => dLapTrinh; set => dLapTrinh = value; }
        public double DCoSoDuLieu { get => dCoSoDuLieu; set => dCoSoDuLieu = value; }
        public double DThietKeWeb { get => dThietKeWeb; set => dThietKeWeb = value; }
        

    }
}
