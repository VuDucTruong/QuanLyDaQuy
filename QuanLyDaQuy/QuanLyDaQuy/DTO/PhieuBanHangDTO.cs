using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaQuy.DTO
{
    internal class PhieuBanHangDTO
    {
        public int MaPhieuBH;
        public int MaKH;
        public DateTime NgayLap;
        public float TongTien;

        public PhieuBanHangDTO(int maPhieuBH, int maKH, DateTime ngayLap, float tongTien)
        {
            MaPhieuBH = maPhieuBH;
            MaKH = maKH;
            NgayLap = ngayLap;
            TongTien = tongTien;
        }

        public void ExecuteInsert()
        {
            try
            {
                string query = "insert into PHIEUBANHANG " +
                "( MaKH , NgayLap , TongTien ) values" +
                $"({MaKH},{NgayLap},{TongTien})";

                DAO.DataProvider.Instance.ExecuteQuery(query);

            }
            catch
            {
                MessageBox.Show("Lỗi chèn dữ liệu PBH");
            }
        }

    }
}
