using QuanLyDaQuy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public DataTable getPhieuDV_byMaPhieu(int MaPhieuDV)
        {
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery("EXEC [dbo].[loadPhieuDV_byMaPhieuDV] @MaPhieuDV = " + MaPhieuDV);
            return data;
        }
        public DataTable getCTPhieuDV_byMaPhieu(int MaPhieuDV)
        {
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery("EXEC [dbo].[loadCTPhieuDV_byMaPhieuDV] @MaPhieuDV = " + MaPhieuDV);
            return data;
        }
        public void updatePhieuDV(string SoTienTraTruoc, string SoTienConLai, string tinhTrangPhieu, int MaPhieuDV)
        {
            DAO.DataProvider.Instance.ExecuteQuery("update PHIEUDICHVU " +
                                                        "set TraTruoc = " + SoTienTraTruoc + " " +
                                                        "where MaPhieuDV = " + MaPhieuDV);

            DAO.DataProvider.Instance.ExecuteQuery("update PHIEUDICHVU " +
                                                        "set ConLai = " + SoTienConLai + " " +
                                                        "where MaPhieuDV = " + MaPhieuDV);

            DAO.DataProvider.Instance.ExecuteQuery("update PHIEUDICHVU " +
                                                        "set TinhTrang = N'" + tinhTrangPhieu + "' " +
                                                        "where MaPhieuDV = " + MaPhieuDV);
        }
        public void updateCTPhieuDV(DataGridViewRow row, int MaPhieuDV, List<int> MaDVs)
        {
            DAO.DataProvider.Instance.ExecuteQuery("update CT_PHIEUDICHVU " +
                                                            "set TraTruoc = " + row.Cells[6].Value.ToString() + " " +
                                                            "where MaPhieuDV = " + MaPhieuDV + " and MaDV = " + MaDVs[row.Index]);
            DAO.DataProvider.Instance.ExecuteQuery("update CT_PHIEUDICHVU " +
                                                            "set ConLai = " + row.Cells[7].Value.ToString() + " " +
                                                            "where MaPhieuDV = " + MaPhieuDV + " and MaDV = " + MaDVs[row.Index]);
            DAO.DataProvider.Instance.ExecuteQuery("update CT_PHIEUDICHVU " +
                                                            "set TinhTrang = N'" + row.Cells[9].Value.ToString() + "' " +
                                                            "where MaPhieuDV = " + MaPhieuDV + " and MaDV = " + MaDVs[row.Index]);
        }
    }
}
