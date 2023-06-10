using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class NhaCungCap
    {
        public int MaNCC;
        public string TenNCC;
        public string DiaChi;
        public string SDT;

        public NhaCungCap(int maNCC, string tenNCC, string diaChi, string sDT)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            DiaChi = diaChi;
            SDT = sDT;
        }
        public NhaCungCap(DataRow data)
        {
            MaNCC = (int)data["MaNCC"];
            TenNCC = data["TenNCC"].ToString();
            DiaChi = data["DiaChi"].ToString();
            SDT = data["SDT"].ToString();
        }
    }
}
