using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class DichVu
    {
        public int MaDV;
        public string TenDV;
        public double DonGiaDV;

        public DichVu(int maDV, string tenDV, float donGiaDV)
        {
            MaDV = maDV;
            TenDV = tenDV;
            DonGiaDV = donGiaDV;
        }

        public DichVu(DataRow data)
        {
            MaDV = (int)data["MaDV"];
            TenDV = data["TenDV"].ToString();
            DonGiaDV = (double)data["DonGiaDV"];
        }
    }
}
