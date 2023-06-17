using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace QuanLyDaQuy.DAO
{
    public class DonViTinhDAO
    {
        private static DonViTinhDAO instance;
        public static DonViTinhDAO Instance
        {
            get { if (instance == null) instance = new DonViTinhDAO(); return instance; }
            private set { instance = value; }
        }
        private DonViTinhDAO() { }
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
        public int updateDVT(string DVT , int ID)
        {
            string query = string.Format("update DONVITINH set DVT = N'{0}' where MaDVT = {1}", DVT, ID);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public int getMaDVT_byDVT(string DVT)
        {
            int DVT_id = (int)DataProvider.Instance.ExecuteScalar(string.Format("select * from DONVITINH where DVT = N'{0}'", DVT));
            return DVT_id;
        }
    }
}
