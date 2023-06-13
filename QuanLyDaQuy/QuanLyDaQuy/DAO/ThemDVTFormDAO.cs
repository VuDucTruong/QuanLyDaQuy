using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DAO
{
    public class ThemDVTFormDAO
    {
        private static ThemDVTFormDAO instance;
        public static ThemDVTFormDAO Instance
        {
            get { if (instance == null) instance = new ThemDVTFormDAO(); return instance; }
            private set { instance = value; }
        }
        private ThemDVTFormDAO() { }
        public int insertDVT(string DVT)
        {
            string query = string.Format("insert into DONVITINH values ( N'{0}')", DVT);
            int data = DataProvider.Instance.ExecuteNonQuery(query);
            return data;
        }
        public int getMaDVTLonNhat()
        {
            int maDVT = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("select max(MaDVT) from DONVITINH"));
            return maDVT;
        }
    }
}
