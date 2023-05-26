using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class ThamSo
    {
        public int MaThamSo;
        public string TenThamSo;
        public float GiaTri;

        public ThamSo(string tenThamSo, float giaTri)
        {
            TenThamSo = tenThamSo;
            GiaTri = giaTri;
        }
    }
}
