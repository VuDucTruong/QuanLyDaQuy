using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DAO
{
    public class ThemLSPFormDAO
    {
        private static ThemLSPFormDAO instance;
        public static ThemLSPFormDAO Instance
        {
            get { if (instance == null) instance = new ThemLSPFormDAO(); return instance; }
            private set { instance = value; }
        }
        private ThemLSPFormDAO() { }
        public int getMaLSPLonNhat()
        {
            int maLSP = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("select max(MaLSP) from LOAISANPHAM"));
            return maLSP;
        }
        public int getMaDVT_byDVT(string DVT)
        {
            int DVT_id = (int)DataProvider.Instance.ExecuteScalar(string.Format("select * from DONVITINH where DVT = N'{0}'", DVT));
            return DVT_id;
        }
        public int insertLSP(string LSP, string LoiNhuan, int DVT_id)
        {
            string query = string.Format("insert into LOAISANPHAM values ( N'{0}' , {1} , {2})", LSP, Convert.ToDouble(LoiNhuan), DVT_id);
            int data = DataProvider.Instance.ExecuteNonQuery(query);
            return data;
        }
    }
}
