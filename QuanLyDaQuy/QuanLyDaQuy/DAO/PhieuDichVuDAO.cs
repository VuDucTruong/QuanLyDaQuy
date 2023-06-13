using QuanLyDaQuy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DAO
{
    internal class PhieuDichVuDAO
    {

        private static PhieuDichVuDAO instance;

        public static PhieuDichVuDAO Instance
        {
            get { if (instance == null) instance = new PhieuDichVuDAO(); return instance; }
            private set { instance = value; }
        }

        public PhieuDichVuDAO() { }

        public DataTable GetNew_MaPhieuDV()
        {
            DataTable latestID = DAO.DataProvider.Instance.ExecuteQuery("select TOP(1) MaPhieuDV from PHIEUDICHVU ORDER BY MaPhieuDV DESC");
            return latestID;
        }

        public DataTable GetAll_KhachHang()
        {
            DataTable data_kh = DAO.DataProvider.Instance.ExecuteQuery("select * from KHACHHANG");
            return data_kh;
        }

        public DataTable GetAll_DichVu()
        {
            DataTable data_dv = DAO.DataProvider.Instance.ExecuteQuery("select * from DICHVU");
            return data_dv;
        }

        public DataTable Get_SoTienTraTruoc()
        {
            DataTable ThamSo = DAO.DataProvider.Instance.ExecuteQuery("select GiaTri from THAMSO where TenThamSo = 'SoTienTraTruoc'");
            return ThamSo; 
        }


    }
}
