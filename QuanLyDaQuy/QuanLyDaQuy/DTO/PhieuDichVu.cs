using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class PhieuDichVu
    {
        public int MaPhieuDV;
        public int MaKH;
        public DateTime NgayLap;
        public float TongTien;
        public float TraTruoc;
        public float ConLai;
        public string TinhTrang;

        public PhieuDichVu(int maPhieuDV, int maKH, DateTime ngayLap, float tongTien, float traTruoc, float conLai, string tinhTrang)
        {
            MaPhieuDV = maPhieuDV;
            MaKH = maKH;
            NgayLap = ngayLap;
            TongTien = tongTien;
            TraTruoc = traTruoc;
            ConLai = conLai;
            TinhTrang = tinhTrang;
        }
    }
}
