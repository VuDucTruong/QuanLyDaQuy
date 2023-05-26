using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class CT_PhieuMuaHang
    {
        public int MaPhieuMH;
        public int MaSP;
        public int SL;
        public float DonGia;
        public float ThanhTien;

        public CT_PhieuMuaHang(int maPhieuMH, int maSP, int sL, float donGia, float thanhTien)
        {
            MaPhieuMH = maPhieuMH;
            MaSP = maSP;
            SL = sL;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }
    }
}
