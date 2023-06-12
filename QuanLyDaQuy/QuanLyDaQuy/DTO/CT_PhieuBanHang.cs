using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void ExecuteInsert()
        {
            try
            {
                string query = "insert into CT_PHIEUBANHANG " +
                "( MaPhieuBH , MaSP , SL , DonGia, ThanhTien) values" +
                $"({MaPhieuBH},{MaSP},{SL},{DonGia},{ThanhTien})";

                DAO.DataProvider.Instance.ExecuteQuery(query);

            }
            catch
            {
                MessageBox.Show("Lỗi chèn dữ liệu CT_PBH");
            }
        }
    }
}
