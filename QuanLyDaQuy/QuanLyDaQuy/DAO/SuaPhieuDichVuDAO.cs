using QuanLyDaQuy.Phieu;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaQuy.DAO
{
    public class SuaPhieuDichVuDAO
    {
        private static SuaPhieuDichVuDAO instance;
        public static SuaPhieuDichVuDAO Instance
        {
            get { if (instance == null) instance = new SuaPhieuDichVuDAO(); return instance; }
            private set { instance = value; }
        }
        private SuaPhieuDichVuDAO() { }

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
        public void updatePhieuDV(string tinhTrangPhieu, int MaPhieuDV)
        {
            DAO.DataProvider.Instance.ExecuteQuery("update PHIEUDICHVU " +
                                                            "set TinhTrang = N'" + tinhTrangPhieu + "' " +
                                                            "where MaPhieuDV = " + MaPhieuDV);
        }
        public void updateCTPhieuDV(DataGridViewRow row, int MaPhieuDV, List<int> MaDVs)
        {
            DAO.DataProvider.Instance.ExecuteQuery("update CT_PHIEUDICHVU " +
                                                                "set TinhTrang = N'" + row.Cells[9].Value.ToString() + "' " +
                                                                "where MaPhieuDV = " + MaPhieuDV + " and MaDV = " + MaDVs[row.Index]);
        }
    }
}
