using QuanLyDaQuy.DTO;
using QuanLyDaQuy.Phieu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DAO
{
    public class PhieuBanHangDAO
    {
        private static PhieuBanHangDAO instance { get; set; }  
        public static PhieuBanHangDAO Instance { get { if(instance == null) instance = new PhieuBanHangDAO(); return instance; }
            set { instance = value; }
        }
        public PhieuBanHangDAO() { }

        public void InsertCT_PhieuBanHang(int MaPhieuBH , int MaSP , int SL , int DonGia , int ThanhTien)
        {
            string query = "insert into CT_PHIEUBANHANG " +
                "( MaPhieuBH , MaSP , SL , DonGia, ThanhTien) values" +
                $"({MaPhieuBH},{MaSP},{SL},{DonGia},{ThanhTien})";

            DAO.DataProvider.Instance.ExecuteQuery(query);
        }
        public string getMaxMaPhieuBH_toString()
        {
            return DataProvider.Instance.ExecuteScalar("select max(MaPhieuBH) from PHIEUBANHANG").ToString();

        }

        public DataTable getSP_FULL(int maSP)
        {
            string query = @"SELECT LSP.TenLSP, DVT.DVT,  SP.DonGiaBan
                FROM SANPHAM SP
                INNER JOIN LOAISANPHAM LSP ON SP.MaLSP = LSP.MaLSP
                INNER JOIN DONVITINH DVT ON LSP.MaDVT = DVT.MaDVT
                WHERE SP.MaSP = @MaSP";

            object[] parameters = new object[] { maSP };

            // Lấy cột loại sp, dvt & đơn giá để autofill sau khi chọn sản phẩm
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);
            return dataTable;
        }
        
        public int insertCT_PhieuBH(int maPhieuBH , int maSP , int soLuong , float donGia , float thanhTien)
        {
            string insertQuery = $"INSERT INTO CT_PHIEUBANHANG (MaPhieuBH, MaSP, SL, DonGia, ThanhTien) VALUES ( {maPhieuBH}, {maSP}, {soLuong}, {donGia}, {thanhTien} )";


            return DataProvider.Instance.ExecuteNonQuery(insertQuery);
        }
        public int insertPhieuBH(int MaPhieuBH , string NgayLap , float TongTien)
        {
            string query = "insert into PHIEUBANHANG " +
                "( MaKH , NgayLap , TongTien ) values" +
                $"({MaPhieuBH},'{NgayLap}',{TongTien})";

            return DataProvider.Instance.ExecuteNonQuery(query);

        }
    }
}
