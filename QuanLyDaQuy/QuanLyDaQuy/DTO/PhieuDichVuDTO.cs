using System;
using System.Collections.Generic;
using System.Data;
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
        public double TongTien;
        public double TraTruoc;
        public double ConLai;
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
    }
}
