using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class PhieuBanHang
    {
        public int MaPhieuBH;
        public int MaKH;
        public DateTime NgayLap;
        public float TongTien;

        public PhieuBanHang(int maPhieuBH, int maKH, DateTime ngayLap, float tongTien)
        {
            MaPhieuBH = maPhieuBH;
            MaKH = maKH;
            NgayLap = ngayLap;
            TongTien = tongTien;
        }
    }
}
