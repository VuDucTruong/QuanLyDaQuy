using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class PhieuMuaHang
    {
        public int MaPhieuMH;
        public int MaNCC;
        public DateTime NgayLap;
        public float TongTien;

        public PhieuMuaHang(int maPhieuMH, int maNCC, DateTime ngayLap, float tongTien)
        {
            MaPhieuMH = maPhieuMH;
            MaNCC = maNCC;
            NgayLap = ngayLap;
            TongTien = tongTien;
        }
    }
}
