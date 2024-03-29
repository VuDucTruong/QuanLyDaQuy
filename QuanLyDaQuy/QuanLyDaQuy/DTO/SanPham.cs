﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaQuy.DTO
{
    public class SanPham
    {
        public int MaSP;
        public string TenSP;
        public int MaLSP;
        public double DonGiaBan;
        public double DonGiaMua;
        public int SoLuongTon;

        public SanPham(int maSP, string tenSP, int maLSP, double donGiaBan, double donGiaMua, int soLuongTon)
        {
            MaSP = maSP;
            TenSP = tenSP;
            MaLSP = maLSP;
            DonGiaBan = donGiaBan;
            DonGiaMua = donGiaMua;
            SoLuongTon = soLuongTon;
        }
        
        public SanPham(DataRow data)
        {
            MaSP = (int)data["MaSP"];
            TenSP = data["TenSP"].ToString();
            MaLSP = (int)data["MaLSP"];
            DonGiaBan =(double) data["DonGiaBan"];
            DonGiaMua =(double) data["DonGiaMua"];
            SoLuongTon =(int) data["SoLuongTon"];
        }
    }
}
