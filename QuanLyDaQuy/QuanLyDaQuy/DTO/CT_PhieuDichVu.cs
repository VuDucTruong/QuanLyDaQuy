using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    internal class CT_PhieuDichVu
    {
        public int MaPhieuDV;
        public int MaDV;
        public float DonGia;
        public float DonGiaDuocTinh;
        public int SL;
        public float ThanhTien;
        public float TraTruoc;
        public float ConLai;
        public DateTime NgayGiao;
        public string TinhTrang;

        public CT_PhieuDichVu(int maPhieuDV, int maDV, float donGia, float donGiaDuocTinh, int sL, float thanhTien, float traTruoc, float conLai, DateTime ngayGiao, string tinhTrang)
        {
            MaPhieuDV = maPhieuDV;
            MaDV = maDV;
            DonGia = donGia;
            DonGiaDuocTinh = donGiaDuocTinh;
            SL = sL;
            ThanhTien = thanhTien;
            TraTruoc = traTruoc;
            ConLai = conLai;
            NgayGiao = ngayGiao;
            TinhTrang = tinhTrang;
        }
<<<<<<< HEAD
=======

        public CT_PhieuDichVu(DataRow data)
        {
            MaPhieuDV = (int)data["MaPhieuDV"];
            MaDV = (int)data["MaDV"];
            DonGia = (double)data["DonGia"];
            DonGiaDuocTinh = (double)data["DonGiaDuocTinh"];
            SL = (int)data["SL"];
            ThanhTien = (double)data["ThanhTien"];
            TraTruoc = (double)data["TraTruoc"];
            ConLai = (double)data["ConLai"];
            NgayGiao = (DateTime)data["NgayGiao"];
            TinhTrang = data["TinhTrang"].ToString();
        }
>>>>>>> parent of 1f2a574 (Update validating PhieuDichVu)
    }
}
