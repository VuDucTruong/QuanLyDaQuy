using System;
using System.Collections.Generic;
using System.Linq;
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

        public NhaCungCap(string tenNCC, string diaChi, string sDT)
        {
          
            TenNCC = tenNCC;
            DiaChi = diaChi;
            SDT = sDT;
        }
    }
}
