using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DAO
{
    public class ThemKHFormDAO
    {
        private static ThemKHFormDAO instance;
        public static ThemKHFormDAO Instance
        {
            get { if (instance == null) instance = new ThemKHFormDAO(); return instance; }
            private set { instance = value; }
        }
        private ThemKHFormDAO() { }
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
    }
}
