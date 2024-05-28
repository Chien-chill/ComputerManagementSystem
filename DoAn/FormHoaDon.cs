using Aspose.Words.Tables;
using Aspose.Words;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVienWinform.Report.AsposeWordExtension;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DoAn
{
    public partial class FormHoaDon : Form
    {
        HoaDon hoaDon;
        bool CheckClickBtnSua = false;
        Functions f = new Functions();  
        public FormHoaDon()
        {
            InitializeComponent();
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = false;
            pnHD.Visible = true;
            pnHD.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnSuaHD.Enabled = false;
            dtpHD.Enabled = false;
            if (dtgHD.DataSource == null)
            {
                txtMaKH.Enabled = true;
            }
            else
            {
                txtMaKH.Enabled = false;
            }
            lblDateHD.Text = DateTime.Now.ToShortDateString();
            txtMaNV.Text = f.SelectTemp();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            pnHD.Visible = false;
            lblDateNow.Text = DateTime.Now.ToShortDateString();
            btnThemHD.Enabled = true;
            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;
            btnInPhieuHD.Enabled = true;
            btnInPhieuHD.Visible = true;
            btnBaoCao.Visible = false;
        }
        public void clear_whitespace()
        {
            TextBox[] txt = {txtMaHD,txtMaKH,txtMaMT,txtSoLuong,txtMaNV};
            f.clear_whitespace(txt);
        }
        
        bool check = false;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int songuyen = 0;
            errorProvider1.Clear();
            clear_whitespace();
            if (f.Select_TblCheck("MaHD","HoaDon","MaHD",txtMaHD.Text) && check == false)
            {
                f.ErrorWarning(errorProvider1, txtMaHD, "Mã hoá đơn đã tồn tại");
            }
            else if (txtMaHD.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMaHD, "Chưa nhập mã hoá đơn");
            }
            else if (txtMaKH.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMaKH, "Chưa nhập mã khách hàng");
            }
            else if (txtMaMT.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMaMT, "Chưa nhập mã máy tính");
            }
            else if (txtSoLuong.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtSoLuong, "Chưa nhập số lượng");
            }
            else if (int.TryParse(txtSoLuong.Text, out songuyen) == false || int.Parse(txtSoLuong.Text) <= 0)
            {
                f.ErrorWarning(errorProvider1, txtSoLuong, "Sai định dạng số lượng");
            }
            else if (txtMaNV.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMaNV, "Chưa nhập mã nhân viên");
            }
            else
            {
                check = true;
                hoaDon = new HoaDon()
                {
                    MaHoaDon = txtMaHD.Text,
                    NgayBan = lblDateHD.Text,
                    MaKH = txtMaKH.Text,
                    MaMT = txtMaMT.Text,
                    GiamGia=int.Parse(txtDiemTT.Text)/10,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    MaNV = txtMaNV.Text,
                    GhiChu = txtGhiChu.Text
                };
                dtgHD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
               
                if (!f.Select_TblCheck("MaKH","KhachHang","MaKH", hoaDon.MaKH))
                {
                    f.ErrorWarning(errorProvider1, txtMaKH, "Mã khách hàng không tồn tại");
                }
                else
                {
                    if (!f.Select_TblCheck("MaMT","Kho","MaMT", hoaDon.MaMT))
                    {
                        f.ErrorWarning(errorProvider1, txtMaMT, "Mã máy tính không còn trong kho");
                    }
                    else
                    {
                        hoaDon.TenMT = Convert.ToString(f.Select_GetValue("TenMT","MayTinh","MaMT",hoaDon.MaMT));
                        hoaDon.TenKH = Convert.ToString(f.Select_GetValue("TenKH", "KhachHang", "MaKH", hoaDon.MaKH));
                        hoaDon.DonGia = Convert.ToDouble(f.Select_GetValue("DonGiaBan", "Kho", "MaMT", hoaDon.MaMT));
                        hoaDon.ThanhTien = hoaDon.DonGia * hoaDon.SoLuong;
                        SqlParameter[] parameter = new SqlParameter[]
                        {
                            new SqlParameter("@1",hoaDon.MaHoaDon),
                            new SqlParameter("@2",hoaDon.NgayBan ),
                            new SqlParameter("@3",hoaDon.MaKH ),
                            new SqlParameter("@4",hoaDon.TenKH ),
                            new SqlParameter("@5",hoaDon.GiamGia),
                            new SqlParameter("@6",hoaDon.MaMT),
                            new SqlParameter("@7",hoaDon.TenMT),
                            new SqlParameter("@8",hoaDon.SoLuong),
                            new SqlParameter("@9",hoaDon.DonGia),
                            new SqlParameter("@10",hoaDon.ThanhTien),
                            new SqlParameter("@11",hoaDon.MaNV ),
                            new SqlParameter("@12",hoaDon.GhiChu )
                        };

                        f.InsertDataIntoTable("HoaDon(MaHD, NgayBan, MaKH, TenKH, GiamGia, MaMT, TenMT, SoLuongMua, DonGia, ThanhTien, MaNV, GhiChu)", parameter);
                        txtMaHD.Enabled = false;
                        txtMaKH.Enabled = false;
                        txtMaMT.Text = "";
                        txtSoLuong.Text = "";
                        txtGhiChu.Text = "";
                        dtgHD.DataSource = f.ReadData("HoaDon", "MaHD", txtMaHD.Text);
                    }
                }
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = true;
            pnHD.Visible = true;
            pnHD.BackColor = Color.FromArgb(255, 255, 128);
            btnThemHD.Enabled = false;
            btnSua.Visible = true;
            btnLuu.Visible = false;
            dtpHD.Enabled = false;
            txtMaNV.Text = f.SelectTemp();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            pnHD.Visible = false;
            btnThemHD.Enabled = true;
            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;
            dtpHD.Enabled = true;
            txtMaMT.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
        }
        int numrow;
        bool checkClickdtg = false;

        private void dtgHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            if (CheckClickBtnSua && numrow >= 0)
            {
                txtMaKH.Enabled = true;
                txtMaHD.Text = dtgHD.Rows[numrow].Cells[0].Value.ToString();
                txtMaKH.Text = dtgHD.Rows[numrow].Cells[1].Value.ToString();
                txtMaMT.Text = dtgHD.Rows[numrow].Cells[3].Value.ToString();
                txtSoLuong.Text = dtgHD.Rows[numrow].Cells[5].Value.ToString();
                txtMaNV.Text = dtgHD.Rows[numrow].Cells[9].Value.ToString();
                txtGhiChu.Text = dtgHD.Rows[numrow].Cells[11].Value.ToString();
            }
            checkClickdtg = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int songuyen = 0;
            errorProvider1.Clear();
            clear_whitespace();
            if (txtMaKH.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMaKH, "Chưa nhập mã khách hàng");
            }
            else if (txtMaMT.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMaMT, "Chưa nhập mã máy tính");
            }
            else if (txtSoLuong.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtSoLuong, "Chưa nhập số lượng");
            }
            else if (int.TryParse(txtSoLuong.Text, out songuyen) == false || int.Parse(txtSoLuong.Text) <= 0)
            {
                f.ErrorWarning(errorProvider1, txtSoLuong, "Sai định dạng số lượng");
            }
            else if (txtMaNV.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMaNV, "Chưa nhập mã nhân viên");
            }
            else
            {
                if (checkClickdtg)
                {
                    checkClickdtg = false;
                    if (!f.Select_TblCheck("MaKH","KhachHang","MaKH", txtMaKH.Text))
                    {
                            f.ErrorWarning(errorProvider1, txtMaKH, "Mã khách hàng không tồn tại");
                    }
                    else
                    {
                        if (!f.Select_TblCheck("MaMT","Kho","MaMT", txtMaMT.Text))
                        {
                            f. ErrorWarning(errorProvider1, txtMaMT, "Mã máy tính không còn trong kho");
                        }
                        else
                        {
                            string TenMT = Convert.ToString(f.Select_GetValue("TenMT","MayTinh","MaMT",txtMaMT.Text));
                            string TenKH = Convert.ToString(f.Select_GetValue("TenKH","KhachHang","MaKH",txtMaKH.Text));
                            double DonGia = Convert.ToDouble(f.Select_GetValue("DonGiaBan","Kho","MaMT", txtMaMT.Text));
                            double ThanhTien = DonGia * int.Parse(txtSoLuong.Text);
                            int GiamGia = int.Parse(txtDiemTT.Text)/10;

                            string[] field1 = { "TenMT", "DonGia", "ThanhTien", "MaMT", "SoLuongMua", "MaNV", "GhiChu" };
                            SqlParameter[] parameter1 = new SqlParameter[]
                            {
                                new SqlParameter("@1",TenMT),
                                new SqlParameter("@2",DonGia),
                                new SqlParameter("@3",ThanhTien),
                                new SqlParameter("@4",txtMaMT.Text),
                                new SqlParameter("@5",int.Parse(txtSoLuong.Text)),
                                new SqlParameter("@6",txtMaNV.Text),
                                new SqlParameter("@7",txtGhiChu.Text)

                            };
                            string[] fieldCondition1 = { "MaHD", "MaKH", "GiamGia", "MaMT", "SoLuongMua", "MaNV", "GhiChu" };
                            SqlParameter[] parameterCondition1 = new SqlParameter[]
                            {
                                new SqlParameter ("@8",txtMaHD.Text),
                                new SqlParameter ("@9",dtgHD.Rows[numrow].Cells[1].Value.ToString()),
                                new SqlParameter ("@10",dtgHD.Rows[numrow].Cells[7].Value.ToString()),
                                new SqlParameter ("@11", dtgHD.Rows[numrow].Cells[3].Value.ToString()),
                                new SqlParameter ("@12",dtgHD.Rows[numrow].Cells[5].Value.ToString()),
                                new SqlParameter ("@13",dtgHD.Rows[numrow].Cells[9].Value.ToString()),
                                new SqlParameter ("@14",dtgHD.Rows[numrow].Cells[11].Value.ToString())
                            };
                            f.UpdateDataTable("HoaDon", field1, parameter1, fieldCondition1, parameterCondition1);
                            string[] field2 = { "MaKH", "TenKH", "GiamGia" };
                            SqlParameter[] parameter2 = new SqlParameter[]
                            {
                                new SqlParameter("@15",txtMaKH.Text),
                                new SqlParameter("@16",TenKH),
                                new SqlParameter("@17",GiamGia)
                            };
                            string[] fieldCondition2 = { "MaHD" };
                            SqlParameter[] parameterCondition2 = new SqlParameter[]
                            {
                                new SqlParameter("@18",txtMaHD.Text)
                            };
                            f.UpdateDataTable("HoaDon", field2, parameter2, fieldCondition2, parameterCondition2);
                            dtgHD.DataSource = f.ReadData("HoaDon", "MaHD", txtMaHD.Text);
                            txtMaKH.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn dòng để sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (checkClickdtg)
            {
                checkClickdtg = false;
                string[] fieldCondition = { "MaHD", "MaKH", "GiamGia", "MaMT", "SoLuongMua", "MaNV", "GhiChu" };
                SqlParameter[] parameterCondition = new SqlParameter[]
                {
                    new SqlParameter("@1",txtMaHD.Text),
                    new SqlParameter("@2",dtgHD.Rows[numrow].Cells[1].Value.ToString()),
                    new SqlParameter("@3",dtgHD.Rows[numrow].Cells[7].Value.ToString()),
                    new SqlParameter("@4",dtgHD.Rows[numrow].Cells[3].Value.ToString()),
                    new SqlParameter("@5",dtgHD.Rows[numrow].Cells[5].Value.ToString()),
                    new SqlParameter("@6",dtgHD.Rows[numrow].Cells[9].Value.ToString()),
                    new SqlParameter("@7",dtgHD.Rows[numrow].Cells[11].Value.ToString())
                };
                f.DeleteDataTable("HoaDon", fieldCondition, parameterCondition);
                dtgHD.DataSource = f.ReadData("HoaDon", "MaHD", txtMaHD.Text);
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng để xoá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnInPhieuHD_Click(object sender, EventArgs e)
        {
            if (dtgHD.DataSource != null)
            {
                double TongSoTien = 0;
                var Today = DateTime.Now;
                Document HoaDon = new Document(@"TemplateWord\\Mau_Hoa_Don.doc");
                string NgaySinh = Convert.ToString(f.Select_GetValue("NgaySinhKH","KhachHang","MaKH", dtgHD.Rows[0].Cells[1].Value.ToString()));
                string GioiTinh = Convert.ToString(f.Select_GetValue("GioiTinhKH","KhachHang","MaKH", dtgHD.Rows[0].Cells[1].Value.ToString()));
                string DiaChi = Convert.ToString(f.Select_GetValue("DiaChiKH", "KhachHang", "MaKH", dtgHD.Rows[0].Cells[1].Value.ToString()));
                string DienThoai = Convert.ToString(f.Select_GetValue("DienThoaiKH", "KhachHang", "MaKH", dtgHD.Rows[0].Cells[1].Value.ToString()));
                string Bank = Convert.ToString(f.Select_GetValue("BANK", "KhachHang", "MaKH", dtgHD.Rows[0].Cells[1].Value.ToString()));
                string TenNV = Convert.ToString(f.Select_GetValue("TenNV","NhanVien","MaNV", dtgHD.Rows[0].Cells[9].Value.ToString()));
                double DiemThanThiet = Convert.ToDouble(f.Select_GetValue("DiemThanThiet","KhachHang","MaKH", dtgHD.Rows[0].Cells[1].Value.ToString()));
                HoaDon.MailMerge.Execute(new[] { "Ngay_Thang_Nam" }, new[] { string.Format("Nam Định , ngày {0} tháng {1} năm {2}", Today.Day, Today.Month, Today.Year) });
                HoaDon.MailMerge.Execute(new[] { "Ma_HD" }, new[] { dtgHD.Rows[0].Cells[0].Value.ToString() });
                HoaDon.MailMerge.Execute(new[] { "Ma_KH" }, new[] { dtgHD.Rows[0].Cells[1].Value.ToString() });
                HoaDon.MailMerge.Execute(new[] { "Ten_KH" }, new[] { dtgHD.Rows[0].Cells[2].Value.ToString() });
                HoaDon.MailMerge.Execute(new[] { "Dia_Chi" }, new[] { DiaChi });
                HoaDon.MailMerge.Execute(new[] { "Ngay_Sinh" }, new[] { NgaySinh });
                HoaDon.MailMerge.Execute(new[] { "Gioi_Tinh" }, new[] { GioiTinh });
                HoaDon.MailMerge.Execute(new[] { "SDT" }, new[] { DienThoai });
                HoaDon.MailMerge.Execute(new[] { "BANK" }, new[] { Bank });
                HoaDon.MailMerge.Execute(new[] { "Ma_Nhan_Vien" }, new[] { dtgHD.Rows[0].Cells[9].Value.ToString() });
                HoaDon.MailMerge.Execute(new[] { "Ten_Nhan_Vien" }, new[] { TenNV });
                HoaDon.MailMerge.Execute(new[] { "Diem_TT" }, new[] { DiemThanThiet.ToString() });

                int count = dtgHD.Rows.Count;
                Table ThongTin = HoaDon.GetChild(NodeType.Table, 0, true) as Table;
                int row = 1;
                ThongTin.InsertRows(row, row, count - 1);
                for (int i = 0; i < count; i++)
                {
                    string LoaiHang = Convert.ToString(f.Select_GetValue("LoaiHang","MayTinh","MaMT", dtgHD.Rows[i].Cells[3].Value.ToString()));
                    string BaoHanh = Convert.ToString(f.Select_GetValue("BaoHanh", "MayTinh", "MaMT", dtgHD.Rows[i].Cells[3].Value.ToString()));
                    string CPU = Convert.ToString(f.Select_GetValue("CPU", "MayTinh", "MaMT", dtgHD.Rows[i].Cells[3].Value.ToString()));
                    string RAM1 = Convert.ToString(f.Select_GetValue("RAM1", "MayTinh", "MaMT", dtgHD.Rows[i].Cells[3].Value.ToString()));
                    string RAM2 = Convert.ToString(f.Select_GetValue("RAM2", "MayTinh", "MaMT", dtgHD.Rows[i].Cells[3].Value.ToString()));
                    string Card = Convert.ToString(f.Select_GetValue("Card", "MayTinh", "MaMT", dtgHD.Rows[i].Cells[3].Value.ToString()));
                    string ManHinh = Convert.ToString(f.Select_GetValue("ManHinh", "MayTinh", "MaMT", dtgHD.Rows[i].Cells[3].Value.ToString()));
                    string DungLuong = Convert.ToString(f.Select_GetValue("DungLuong", "MayTinh", "MaMT", dtgHD.Rows[i].Cells[3].Value.ToString()));
                    ThongTin.PutValue(row, 0, dtgHD.Rows[i].Cells[3].Value.ToString());
                    ThongTin.PutValue(row, 1, dtgHD.Rows[i].Cells[4].Value.ToString());
                    ThongTin.PutValue(row, 2, LoaiHang +", "+CPU+", "+RAM1+"+"+RAM2+", "+Card+", "+ManHinh+", "+DungLuong);
                    ThongTin.PutValue(row, 3, dtgHD.Rows[i].Cells[5].Value.ToString());
                    ThongTin.PutValue(row, 4, BaoHanh);
                    ThongTin.PutValue(row, 5, dtgHD.Rows[i].Cells[6].Value.ToString());
                    ThongTin.PutValue(row, 6, dtgHD.Rows[i].Cells[8].Value.ToString());
                    ThongTin.PutValue(row, 7, dtgHD.Rows[i].Cells[9].Value.ToString());
                    TongSoTien += double.Parse(dtgHD.Rows[i].Cells[8].Value.ToString());
                    row++;
                    DiemThanThiet += (double.Parse(dtgHD.Rows[i].Cells[5].Value.ToString()) * 10);
                }
                HoaDon.MailMerge.Execute(new[] { "Tong_So_Tien" }, new[] { TongSoTien.ToString() });
                HoaDon.MailMerge.Execute(new[] { "Giam_Gia" }, new[] { dtgHD.Rows[0].Cells[7].Value.ToString() });
                double TienThanhToan;
                double GiamGia = (100 - double.Parse(dtgHD.Rows[0].Cells[7].Value.ToString()))/100;
                TienThanhToan = TongSoTien * GiamGia;
                HoaDon.MailMerge.Execute(new[] { "Thanh_Toan" }, new[] { TienThanhToan.ToString() });
                HoaDon.SaveAndOpenFile("HoaDon.doc");
                string[] field = { "DiemThanThiet" };
                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("@1",DiemThanThiet)
                };
                string[] fieldCondition = { "MaKH" };
                SqlParameter[] parameterCondition = new SqlParameter[]
                {
                    new SqlParameter("@2",dtgHD.Rows[0].Cells[1].Value.ToString())
                };
                f.UpdateDataTable("KhachHang",field,parameter,fieldCondition,parameterCondition);
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dtpHD_ValueChanged(object sender, EventArgs e)
        {
            dtgHD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgHD.DataSource = f.ReadData("HoaDon","NgayBan",dtpHD.Text);
            btnThemHD.Enabled = false;
            btnSuaHD.Enabled = false;
            btnXoaHD.Enabled = false;
            btnInPhieuHD.Visible = false;
            btnBaoCao.Visible = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            FormHoaDon_Load(sender, e);
            check = false;
            txtMaHD.Enabled = true;
            dtgHD.DataSource = null;
            btnInPhieuHD.Visible = true;
            btnBaoCao.Visible = false;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (dtgHD.DataSource != null)
            {
                double TongSoTien = 0;
                Document BaoCao = new Document(@"TemplateWord\\Mau_Bao_Cao_Doanh_Thu.doc");
                BaoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam" }, new[] { dtpHD.Text });
                int count = dtgHD.Rows.Count;
                Table ThongTin = BaoCao.GetChild(NodeType.Table, 0, true) as Table;
                int row = 1;
                ThongTin.InsertRows(row, row, count - 1);
                for (int i = 0; i < count; i++)
                {
                    ThongTin.PutValue(row, 0, dtgHD.Rows[i].Cells[0].Value.ToString());
                    ThongTin.PutValue(row, 1, dtgHD.Rows[i].Cells[1].Value.ToString());
                    ThongTin.PutValue(row, 2, dtgHD.Rows[i].Cells[3].Value.ToString());
                    ThongTin.PutValue(row, 3, dtgHD.Rows[i].Cells[5].Value.ToString());
                    ThongTin.PutValue(row, 4, dtgHD.Rows[i].Cells[6].Value.ToString());
                    ThongTin.PutValue(row, 5, dtgHD.Rows[i].Cells[8].Value.ToString());
                    ThongTin.PutValue(row, 6, dtgHD.Rows[i].Cells[9].Value.ToString());
                    ThongTin.PutValue(row, 7, dtgHD.Rows[i].Cells[11].Value.ToString());
                    TongSoTien += double.Parse(dtgHD.Rows[i].Cells[8].Value.ToString());
                    row++;
                }
                BaoCao.MailMerge.Execute(new[] { "Tong_So_Tien" }, new[] { TongSoTien.ToString() });
                BaoCao.SaveAndOpenFile("DoanhThu.doc");
            }
        }
        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            if (f.Select_TblCheck("MaKH","KhachHang","MaKH",txtMaKH.Text))
            {
            string DiemTT = Convert.ToString(f.Select_GetValue("DiemThanThiet","KhachHang","MaKH",txtMaKH.Text));
            txtDiemTT.Text = DiemTT;
            }
        }
    }
}