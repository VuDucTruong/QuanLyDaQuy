using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class CT_PhieuBanHang
    {
        public int MaPhieuBH;
        public int MaSP;
        public int SL;
        public int DonGia;
        public int ThanhTien;

        public CT_PhieuBanHang(int maPhieuBH, int maSP, int sL, int donGia, int thanhTien)
        {
            MaPhieuBH = maPhieuBH;
            MaSP = maSP;
            SL = sL;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }
    }
}
