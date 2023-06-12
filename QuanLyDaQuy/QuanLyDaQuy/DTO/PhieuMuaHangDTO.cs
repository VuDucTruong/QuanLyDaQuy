using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class PhieuMuaHangDTO
    {
        public int MaPhieuMH;
        public int MaNCC;
        public DateTime NgayLap;
        public double TongTien;

        public PhieuMuaHangDTO(int maPhieuMH, int maNCC, DateTime ngayLap, double tongTien)
        {
            MaPhieuMH = maPhieuMH;
            MaNCC = maNCC;
            NgayLap = ngayLap;
            TongTien = tongTien;
        }

        public void Perform_Insert()
        {
            DAO.DataProvider.Instance.ExecuteQuery("SET IDENTITY_INSERT dbo.PHIEUMUAHANG ON " +
                "insert into PhieuMuaHang (MaPhieuMH, MaNCC, NgayLap, TongTien) values" +
                                                    "(" + MaPhieuMH + ", " + MaNCC + ", '" + NgayLap.ToString("dd/MM/yyyy") + "'," + TongTien + ") " +
                                                    "SET IDENTITY_INSERT dbo.PHIEUMUAHANG OFF");
        }
    }
}
