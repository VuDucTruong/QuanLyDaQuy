using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class LoaiSanPham
    {
        public int MaLSP;
        public string TenLSP;
        public float LoiNhuan;
        public int MaDVT;

        public LoaiSanPham(int maLSP, string tenLSP, float loiNhuan, int maDVT)
        {
            MaLSP = maLSP;
            TenLSP = tenLSP;
            LoiNhuan = loiNhuan;
            MaDVT = maDVT;
        }
        public LoaiSanPham(DataRow data)
        {
            MaLSP =(int) data["MaLSP"];
            TenLSP = data["TenLSP"].ToString();
            LoiNhuan = (float)data["LoiNhuan"];
            MaDVT = (int)data["MaDVT"];
        }
    }
}
