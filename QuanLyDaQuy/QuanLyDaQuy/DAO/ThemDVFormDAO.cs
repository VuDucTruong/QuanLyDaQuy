using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DAO
{
    public class ThemDVFormDAO
    {
        private static ThemDVFormDAO instance;
        public static ThemDVFormDAO Instance
        {
            get { if (instance == null) instance = new ThemDVFormDAO(); return instance; }
            private set { instance = value; }
        }
        private ThemDVFormDAO() { }

        public int insertDichVu(string dichVu, string donGia)
        {
            string query = string.Format("insert into DICHVU values ( N'{0}' , {1} )", dichVu, Convert.ToDouble(donGia));
            int data = DataProvider.Instance.ExecuteNonQuery(query);
            return data;
        }
        public int getMaDVLonNhat()
        {
            int maDV = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("select max(MaDV) from DICHVU"));
            return maDV;
        }

        public DataTable loadDV()
        {
            string query = "Slelect MaDV as \"Mã dịch vụ\" , TenDV as \"Tên dịch vụ\" , FORMAT(DonGiaDV,'c', 'vi-VN') as \"Đơn giá dịch vụ\" ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}
