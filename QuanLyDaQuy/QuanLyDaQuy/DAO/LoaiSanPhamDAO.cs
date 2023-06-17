using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace QuanLyDaQuy.DAO
{
    public class LoaiSanPhamDAO
    {
        private static LoaiSanPhamDAO instance;
        public static LoaiSanPhamDAO Instance
        {
            get { if (instance == null) instance = new LoaiSanPhamDAO(); return instance; }
            private set { instance = value; }
        }
        private LoaiSanPhamDAO() { }
        public int getMaLSPLonNhat()
        {
            int maLSP = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("select max(MaLSP) from LOAISANPHAM"));
            return maLSP;
        }
        
        public int insertLSP(string LSP, string LoiNhuan, int DVT_id)
        {
            string query = string.Format("insert into LOAISANPHAM values ( N'{0}' , {1} , {2})", LSP, Convert.ToDouble(LoiNhuan), DVT_id);
            int data = DataProvider.Instance.ExecuteNonQuery(query);
            return data;
        }

        public DataTable getAllLSP()
        {
            return DataProvider.Instance.ExecuteQuery("select *  from LOAISANPHAM");
        }
        public int updateLSP(string TenLSP , double LoiNhuan , int MaDVT , int ID)
        {
            string query = string.Format("update LOAISANPHAM set TenLSP = N'{0}' , LoiNhuan = {1} , MaDVT = {2} where MaLSP = {3}", TenLSP, LoiNhuan, MaDVT, ID);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int getMaLSPByTenLSP(string TenLSP)
        {
            string sub_query = string.Format("select * from LOAISANPHAM where TenLSP = N'{0}'", TenLSP);
            return (int)DataProvider.Instance.ExecuteScalar(sub_query);
        }
    }
}
