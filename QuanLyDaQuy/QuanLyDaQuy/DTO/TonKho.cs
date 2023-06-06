using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class TonKho
    {
        public DateTime Thang;
        public int MaSP;
        public int SLTonDau;
        public int SLTonCuoi;
        public int SLMuaVao;
        public int SLBanRa;

        public TonKho(DateTime thang, int maSP, int sLTonDau, int sLTonCuoi, int sLMuaVao, int sLBanRa)
        {
            Thang = thang;
            MaSP = maSP;
            SLTonDau = sLTonDau;
            SLTonCuoi = sLTonCuoi;
            SLMuaVao = sLMuaVao;
            SLBanRa = sLBanRa;
        }
    }
}
