using QuanLyDaQuy.Phieu;
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
        public double DonGia;
        public double ThanhTien;

        public CT_PhieuMuaHang(int maPhieuMH, int maSP, int sL, double donGia, double thanhTien)
        {
            MaPhieuMH = maPhieuMH;
            MaSP = maSP;
            SL = sL;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }
        public void Perform_Insert()
        {
            DAO.DataProvider.Instance.ExecuteQuery("insert into CT_PHIEUMUAHANG (MaPhieuMH, MaSP, SL, DonGia, ThanhTien) values" +
                                        "(" + MaPhieuMH + ", " + MaSP + ", " + SL + ", " + DonGia + ", " + ThanhTien + ")");
        }
    }
}
