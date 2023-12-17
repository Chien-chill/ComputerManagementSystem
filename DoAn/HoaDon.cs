using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
    public class HoaDon
    {
        private string maHoaDon;
        private string ngayBan;
        private string maKH;
        private string tenKH;
        private double giamGia;
        private string maMT;
        private string tenMT;
        private int soLuong;
        private double donGia;
        private double thanhTien;
        private string maNV;
        private string ghiChu;

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string NgayBan { get => ngayBan; set => ngayBan = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public double GiamGia { get => giamGia; set => giamGia = value; }
        public string MaMT { get => maMT; set => maMT = value; }
        public string TenMT { get => tenMT; set => tenMT = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
