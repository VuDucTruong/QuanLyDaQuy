using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class PhieuDichVuDTO
    {
        public int MaPhieuDV;
        public int MaKH;
        public DateTime NgayLap;
        public float TongTien;
        public float TraTruoc;
        public float ConLai;
        public string TinhTrang;

        public PhieuDichVuDTO(int maPhieuDV, int maKH, DateTime ngayLap, float tongTien, float traTruoc, float conLai, string tinhTrang)
        {
            MaPhieuDV = maPhieuDV;
            MaKH = maKH;
            NgayLap = ngayLap;
            TongTien = tongTien;
            TraTruoc = traTruoc;
            ConLai = conLai;
            TinhTrang = tinhTrang;
        }
<<<<<<< HEAD
=======

        public PhieuDichVuDTO(DataRow data)
        {
            MaPhieuDV = (int)data["MaPhieuDV"];
            MaKH = (int)data["MaKH"];
            NgayLap = (DateTime)data["NgayLap"];
            TongTien = (double)data["TongTien"];
            TraTruoc = (double)data["TraTruoc"];
            ConLai = (double)data["ConLai"];
            TinhTrang = data["TinhTrang"].ToString();
        }
>>>>>>> parent of 1f2a574 (Update validating PhieuDichVu)
    }
}
