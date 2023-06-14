using QuanLyDaQuy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DAO
{
    internal class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return instance; }
            private set { instance = value; }
        }

        public int Insert_SanPham(string TenSP, int MaLSP, double DonGiaMua, double SoLuongTon)
        {
            string query = string.Format("insert into SANPHAM ( TenSP , MaLSP , DonGiaMua , SoLuongTon) values ( N'{0}' , {1} , {2} , {3} )",
                                        TenSP, MaLSP, DonGiaMua, SoLuongTon);
            int data = DataProvider.Instance.ExecuteNonQuery(query);
            return data;
        }

        public int GetNew_MaSP()
        {
            int id = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("select max(MaSP) from SANPHAM")) + 1;
            return id;
        }
    }
}
