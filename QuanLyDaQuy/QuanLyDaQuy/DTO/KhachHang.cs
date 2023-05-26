using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class KhachHang
    {
        public int MaKH;
        public string TenKH;
        public string SDT;

        public KhachHang(int maKH, string tenKH, string sDT)
        {
            MaKH = maKH;
            TenKH = tenKH;
            SDT = sDT;
        }
        public KhachHang(DataRow row)
        {
            MaKH = (int)row["MaKH"];
            TenKH = row["TenKH"].ToString();
            SDT = row["SDT"].ToString();
        }
    }
}
