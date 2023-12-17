using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn
{
   public class PhieuNhap
    {
        private string maPhieuNhap;
        private string ngayLamPhieu;
        private string maCT;
        private string tenCT;
        private string thue;
        private string maMT;
        private string tenMT;
        private int soLuong;
        private double donGia;
        private double thanhTien;
        private string maNV;
        private string ghiChu;

        public string MaPhieuNhap { get => maPhieuNhap; set => maPhieuNhap = value; }
        public string NgayLamPhieu { get => ngayLamPhieu; set => ngayLamPhieu = value; }
        public string MaCT { get => maCT; set => maCT = value; }
        public string TenCT { get => tenCT; set => tenCT = value; }
        public string Thue { get => thue; set => thue = value; }
        public string MaMT { get => maMT; set => maMT = value; }
        public string TenMT { get => tenMT; set => tenMT = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public double DonGia { get => donGia; set => donGia = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
