using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class DonViTinh
    {
        public int MaDVT;
        public string DVT;

        public DonViTinh(int maDVT, string dVT)
        {
            MaDVT = maDVT;
            DVT = dVT;
        }
        public DonViTinh(DataRow data)
        {
            MaDVT = (int)data["MaDVT"];
            DVT = data["DVT"].ToString();
        }
    }
}
