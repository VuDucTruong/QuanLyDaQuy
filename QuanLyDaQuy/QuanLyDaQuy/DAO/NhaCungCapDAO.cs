using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;

        public static NhaCungCapDAO Instance
        {
            get { if (instance == null) instance = new NhaCungCapDAO(); return instance; }
            private set { instance = value; }
        }

        public int Insert_NhaCungCap(string ncc, string address, string phone)
        {
            string query = string.Format("insert into NHACUNGCAP values ( N'{0}' , N'{1}' , '{2}')", ncc, address, phone);
            int data = DataProvider.Instance.ExecuteNonQuery(query);
            return data;
        }
            
        public int GetNew_MaNCC()
        {
            int id = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("select max(MaNCC) from NHACUNGCAP")) + 1;
            return id;
        }
    }
}
