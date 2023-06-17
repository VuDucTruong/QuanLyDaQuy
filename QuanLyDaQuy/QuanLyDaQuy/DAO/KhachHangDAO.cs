using QuanLyDaQuy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace QuanLyDaQuy.DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            private set { instance = value; }
        }
        private KhachHangDAO() { }
        public int insertKhachHang(string name, string phone)
        {
            string query = string.Format("insert into KHACHHANG values ( N'{0}' , '{1}' )", name, phone);
            int data = DataProvider.Instance.ExecuteNonQuery(query);
            return data;
        }
        public int getMaKHLonNhat()
        {
            int maKH = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("select max(MaKH) from KHACHHANG"));
            return maKH;
        }
        public DataTable getAllKhachHang()
        {
            return DataProvider.Instance.ExecuteQuery("select *  from KHACHHANG");
        }

        public object getKhachHangBySDT(string tenKH , string sdt)
        {
            string query = "SELECT MaKH FROM KHACHHANG WHERE TenKH = @tenKH AND SDT = @soDT";
            object[] parameters = { tenKH, sdt };

            return DataProvider.Instance.ExecuteScalar(query, parameters);
        }

        public object insertKHACHHANG(string tenKH , string sdt)
        {
            string insertQuery = $"INSERT INTO KHACHHANG (TenKH, SDT) VALUES ( '{tenKH}', '{sdt}' ); SELECT SCOPE_IDENTITY();";

            return DataProvider.Instance.ExecuteScalar(insertQuery);
        }

        public int updateKHACHHANG(string TenKH , string SDT , int ID)
        {
            string query = string.Format("update KHACHHANG set TenKH = N'{0}' , SDT = '{1}' where MaKH = {2}", TenKH, SDT, ID);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
