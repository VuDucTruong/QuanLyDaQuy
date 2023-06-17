using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DAO
{
    public class TonKhoDAO
    {
        private static TonKhoDAO instance { get; set; }    
        public static TonKhoDAO Instance { get { if(instance == null) instance = new TonKhoDAO(); return instance; }
            set { instance = value; }
        }

        public DataTable LoadTonKho_Thang()
        {
            string query = string.Format("select distinct YEAR(Thang) from TONKHO");
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable;
        }
    }
}
