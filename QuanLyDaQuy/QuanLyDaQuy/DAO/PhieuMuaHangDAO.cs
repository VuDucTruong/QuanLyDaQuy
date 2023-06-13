using QuanLyDaQuy.DAO;
using QuanLyDaQuy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DAO
{
    public class PhieuMuaHangDAO
    {
        private static PhieuMuaHangDAO instance;
        public static PhieuMuaHangDAO Instance
        {
            get { if (instance == null) instance = new PhieuMuaHangDAO(); return instance; }
            private set { instance = value; }
        }
        private PhieuMuaHangDAO() { }
        public int updateSLT(int maSP, int soLuong)
        {
            string updateQuery = $"UPDATE SANPHAM SET SoLuongTon = SoLuongTon + {soLuong} WHERE MaSP = {maSP}";
            int affectedRows = DataProvider.Instance.ExecuteNonQuery(updateQuery);
            return affectedRows;
        }
        public int getSoPhieuLonNhat()
        {
            if (!int.TryParse(DataProvider.Instance.ExecuteScalar("select max(MaPhieuMH) from PHIEUMUAHANG").ToString(),
                out int soPhieu))
            {
                soPhieu = 0;
            }
            return soPhieu;
        }
        public DataTable GetLoaiSanPhamFull()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From LOAISANPHAM");
            return data;
        }
        public DataTable GetSanPhamFull()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From SANPHAM");
            return data;
        }
        public DataTable GetDonViTinhFull()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From DONVITINH");
            return data;
        }
        public DataTable GetNhaCungCapFull()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From NHACUNGCAP");
            return data;
        }
    }
}
