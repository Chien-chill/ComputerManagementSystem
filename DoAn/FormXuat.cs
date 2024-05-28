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
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlTypes;


namespace DoAn
{
    public partial class FormXuat : Form
    {
        Functions f = new Functions();
        PhieuXuat phieuXuat;
        bool CheckClickBtnSua = false;
        public FormXuat()
        {
            InitializeComponent();
        }
        private void FormXuat_Load(object sender, EventArgs e)
        {
            pnXuat.Visible = false;
            lblDateNow.Text = DateTime.Now.ToShortDateString();
            btnThemXuat.Enabled =true;
            btnSuaXuat.Enabled = true;
            btnXoaXuat.Enabled = true;
            btnInPhieuXuat.Enabled = true;
        }
        private void btnThemXuat_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = false;
            pnXuat.Visible = true;
            pnXuat.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnSuaXuat.Enabled = false;
            dtpPhieuXuat.Enabled = false;
            lblDatePhieuXuat.Text = DateTime.Now.ToShortDateString();
            if (dtgPhieuXuat.DataSource == null)
            {
                txtMaKH.Enabled = true;
                txtThue.Enabled = true;
            }
            else
            {
                txtMaKH.Enabled = false;
                txtThue.Enabled = false;
            }
            txtMaNV.Text = f.SelectTemp();
        }
        public void clear_whitespace()
        {
            TextBox[] txt = {txtMaPhieuXuat, txtMaKH, txtMaMT, txtThue, txtSoLuong, txtMaNV};
            f.clear_whitespace(txt);
        }
        bool check = false;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int songuyen = 0;
            errorProvider1.Clear();
            clear_whitespace();
            if (f.Select_TblCheck("MaPhieuXuat","PhieuXuat","MaPhieuXuat",txtMaPhieuXuat.Text) && !check)
            {
                f.ErrorWarning(errorProvider1,txtMaPhieuXuat, "Mã phiếu xuất đã tồn tại");
            }
            else if (txtMaPhieuXuat.Text == "")
            {
                f.ErrorWarning(errorProvider1,txtMaPhieuXuat, "Chưa nhập mã phiếu xuất");
            }
            else if (txtMaKH.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMaKH, "Chưa nhập mã khách hàng");
            }
            else if (txtMaMT.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMaMT, "Chưa nhập mã máy tính");
            }
            else if (txtThue.Text == "")
            {
                f.ErrorWarning(errorProvider1,txtThue, "Chưa nhập mã số thuế");
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
                phieuXuat = new PhieuXuat()
                {
                    MaPhieuXuat = txtMaPhieuXuat.Text,
                    NgayLamPhieu = lblDatePhieuXuat.Text,
                    MaKH = txtMaKH.Text,
                    Thue = txtThue.Text,
                    MaMT = txtMaMT.Text,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    MaNV = txtMaNV.Text,
                    GhiChu = txtGhiChu.Text
                };
                dtgPhieuXuat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (!f.Select_TblCheck("MaKH","KhachHang","MaKH",phieuXuat.MaKH))
                {
                    f.ErrorWarning(errorProvider1, txtMaKH, "Mã khách hàng không tồn tại");
                }
                else
                {
                    if (!f.Select_TblCheck("MaMT", "Kho", "MaMT", phieuXuat.MaMT))
                    {
                        f.ErrorWarning(errorProvider1,txtMaMT, "Mã máy tính không còn trong kho");
                    }
                    else
                    {
                        phieuXuat.TenMT = Convert.ToString(f.Select_GetValue("TenMT", "MayTinh", "MaMT", phieuXuat.MaMT));
                        phieuXuat.TenKH = Convert.ToString(f.Select_GetValue("TenKH", "KhachHang", "MaKH", phieuXuat.MaKH));
                        phieuXuat.DonGia = Convert.ToDouble(f.Select_GetValue("DonGiaBan", "Kho", "MaMT", phieuXuat.MaMT));
                        phieuXuat.ThanhTien = phieuXuat.DonGia * phieuXuat.SoLuong;
                        SqlParameter[] parameters = new SqlParameter[]
                        {
                            new SqlParameter("@1",phieuXuat.MaPhieuXuat),
                            new SqlParameter("@2",phieuXuat.NgayLamPhieu),
                            new SqlParameter("@3",phieuXuat.MaKH),
                            new SqlParameter("@4",phieuXuat.TenKH),
                            new SqlParameter("@5", phieuXuat.Thue),
                            new SqlParameter("@6",phieuXuat.MaMT),
                            new SqlParameter("@7", phieuXuat.TenMT),
                            new SqlParameter("@8",phieuXuat.SoLuong),
                            new SqlParameter("@9",phieuXuat.DonGia),
                            new SqlParameter("@10",phieuXuat.ThanhTien),
                            new SqlParameter("@11", phieuXuat.MaNV ),
                            new SqlParameter("@12",phieuXuat.GhiChu )
                        };
                        f.InsertDataIntoTable("PhieuXuat(MaPhieuXuat, NgayLamPhieu, MaKH, TenKH, Thue, MaMT, TenMT, SoLuong, DonGia, ThanhTien, MaNV, GhiChu)", parameters);
                        txtMaPhieuXuat.Enabled = false;
                        txtMaKH.Enabled = false;
                        txtThue.Enabled=false;
                        txtMaMT.Text = "";
                        txtSoLuong.Text = "";
                        txtGhiChu.Text = "";
                        dtgPhieuXuat.DataSource = f.ReadData("PhieuXuat", "MaPhieuXuat", txtMaPhieuXuat.Text);
                    }
                }
            }
        }

        private void btnSuaXuat_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = true;
            pnXuat.Visible = true;
            pnXuat.BackColor = Color.FromArgb(255, 255, 128);
            btnThemXuat.Enabled = false;
            btnSua.Visible = true;
            btnLuu.Visible = false;
            dtpPhieuXuat.Enabled = false;
            txtMaNV.Text = f.SelectTemp();
        }
        private void dtpPhieuNhap_ValueChanged(object sender, EventArgs e)
        {
            dtgPhieuXuat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgPhieuXuat.DataSource = f.ReadData("PhieuXuat","NgayLamPhieu",dtpPhieuXuat.Text);
            btnThemXuat.Enabled = false;
            btnSuaXuat.Enabled = false;
            btnXoaXuat.Enabled = false;
            btnInPhieuXuat.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            pnXuat.Visible = false;
            btnThemXuat.Enabled = true;
            btnSuaXuat.Enabled = true;
            btnXoaXuat.Enabled = true;
            dtpPhieuXuat.Enabled = true;
            txtMaMT.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
        }
        int numrow;
        bool checkClickdtg = false;

        private void dtgPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            if (CheckClickBtnSua && numrow >=0)
            {
                txtMaKH.Enabled = true;
                txtThue.Enabled = true;
                txtMaPhieuXuat.Text = dtgPhieuXuat.Rows[numrow].Cells[0].Value.ToString();
                txtMaKH.Text = dtgPhieuXuat.Rows[numrow].Cells[2].Value.ToString();
                txtThue.Text = dtgPhieuXuat.Rows[numrow].Cells[4].Value.ToString();
                txtMaMT.Text = dtgPhieuXuat.Rows[numrow].Cells[5].Value.ToString();
                txtSoLuong.Text = dtgPhieuXuat.Rows[numrow].Cells[7].Value.ToString();
                txtMaNV.Text = dtgPhieuXuat.Rows[numrow].Cells[10].Value.ToString();
                txtGhiChu.Text = dtgPhieuXuat.Rows[numrow].Cells[11].Value.ToString();
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
            else if (txtThue.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtThue, "Chưa nhập thuế");
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
                if (!f.Select_TblCheck("MaKH","KhachHang","MaKH",txtMaKH.Text))
                {
                    f.ErrorWarning(errorProvider1, txtMaKH, "Mã khách hàng không tồn tại");
                }
                else
                {
                    if (!f.Select_TblCheck("MaMT","Kho","MaMT",txtMaMT.Text))
                    {
                        f.ErrorWarning(errorProvider1, txtMaMT, "Mã máy tính không còn trong kho");
                    }
                    else
                    {
                        if (checkClickdtg)
                        {
                            checkClickdtg = false;

                            string TenMT = Convert.ToString(f.Select_GetValue("TenMT", "MayTinh", "MaMT", txtMaMT.Text));
                            string TenKH = Convert.ToString(f.Select_GetValue("TenKH", "KhachHang", "MaKH", txtMaKH.Text));
                            double DonGia = Convert.ToDouble(f.Select_GetValue("DonGiaBan", "Kho", "MaMT", txtMaMT.Text));
                            double ThanhTien = DonGia * int.Parse(txtSoLuong.Text);
                            string[] field1 = { "TenMT", "DonGia", "ThanhTien", "MaMT", "SoLuong", "MaNV", "GhiChu" };
                            SqlParameter[] parameter1 = new SqlParameter[]
                            {
                                new SqlParameter("@1",TenMT),
                                new SqlParameter("@2",DonGia),
                                new SqlParameter("@3",ThanhTien),
                                new SqlParameter("@4",txtMaMT.Text),
                                new SqlParameter("@5", int.Parse(txtSoLuong.Text)),
                                new SqlParameter("@6",txtMaNV.Text),
                                new SqlParameter("@7",txtGhiChu.Text)
                            };
                            string[] fieldCondition1 = { "MaPhieuXuat", "MaKH", "Thue", "MaMT", "SoLuong", "MaNV", "GhiChu" };
                            SqlParameter[] parameterCondition1 = new SqlParameter[]
                            {
                                new SqlParameter("@8",txtMaPhieuXuat.Text),
                                new SqlParameter("@9",dtgPhieuXuat.Rows[numrow].Cells[2].Value.ToString()),
                                new SqlParameter("@10",dtgPhieuXuat.Rows[numrow].Cells[4].Value.ToString()),
                                new SqlParameter("@11",dtgPhieuXuat.Rows[numrow].Cells[5].Value.ToString()),
                                new SqlParameter("@12",dtgPhieuXuat.Rows[numrow].Cells[7].Value.ToString()),
                                new SqlParameter("@13",dtgPhieuXuat.Rows[numrow].Cells[10].Value.ToString()),
                                new SqlParameter("@14",dtgPhieuXuat.Rows[numrow].Cells[11].Value.ToString())
                            };
                            f.UpdateDataTable("PhieuXuat", field1, parameter1, fieldCondition1, parameterCondition1);
                            string[] field2 = { "MaKH", "TenKH", "Thue" };
                            SqlParameter[] parameter2 = new SqlParameter[]
                            {
                                new SqlParameter("@15",txtMaKH.Text),
                                new SqlParameter("@16",TenKH),
                                new SqlParameter("@17",txtThue.Text)
                            };
                            string[] fieldCondition2 = { "MaPhieuXuat" };
                            SqlParameter[] parameterCondition2 = new SqlParameter[]
                            {
                                new SqlParameter ("@18",txtMaPhieuXuat.Text)
                            };
                            f.UpdateDataTable("PhieuXuat", field2, parameter2, fieldCondition2, parameterCondition2);

                            dtgPhieuXuat.DataSource = f.ReadData("PhieuXuat", "MaPhieuXuat", txtMaPhieuXuat.Text);
                            txtMaKH.Enabled = false;
                            txtThue.Enabled = false;
                        }
                else
                {
                    MessageBox.Show("Chưa chọn dòng để sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    }
                }
            }
        }

        private void btnXoaXuat_Click(object sender, EventArgs e)
        {
            if(checkClickdtg)
            {
                
                checkClickdtg = false;
                string[] fieldCondition = { "MaPhieuXuat", "MaKH", "Thue", "MaMT", "SoLuong", "MaNV", "GhiChu" };
                SqlParameter[] parameterCondition = new SqlParameter[]
                {
                    new SqlParameter("@1",txtMaPhieuXuat.Text),
                    new SqlParameter("@2",dtgPhieuXuat.Rows[numrow].Cells[2].Value.ToString()),
                    new SqlParameter("@3", dtgPhieuXuat.Rows[numrow].Cells[4].Value.ToString()),
                    new SqlParameter("@4",dtgPhieuXuat.Rows[numrow].Cells[5].Value.ToString()),
                    new SqlParameter("@5", dtgPhieuXuat.Rows[numrow].Cells[7].Value.ToString()),
                    new SqlParameter("@6",dtgPhieuXuat.Rows[numrow].Cells[10].Value.ToString()),
                    new SqlParameter("@7",dtgPhieuXuat.Rows[numrow].Cells[11].Value.ToString())
                };
                f.DeleteDataTable("PhieuXuat", fieldCondition, parameterCondition);
                dtgPhieuXuat.DataSource = f.ReadData("PhieuXuat", "MaPhieuXuat", txtMaPhieuXuat.Text);
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng để xoá","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            } 
                
        }

        private void btnInPhieuXuat_Click(object sender, EventArgs e)
        {
            if (dtgPhieuXuat.DataSource != null)
            {
                double TongSoTien = 0;
                var Today = DateTime.Now;
                Document PhieuXuat = new Document(@"TemplateWord\\Mau_Phieu_Xuat.doc");
                string DiaChi = Convert.ToString(f.Select_GetValue("DiaChiKH","KhachHang","MaKH", dtgPhieuXuat.Rows[0].Cells[2].Value.ToString()));
                string DienThoai = Convert.ToString(f.Select_GetValue("DienThoaiKH", "KhachHang", "MaKH", dtgPhieuXuat.Rows[0].Cells[2].Value.ToString()));
                string Bank = Convert.ToString(f.Select_GetValue("BANK", "KhachHang", "MaKH", dtgPhieuXuat.Rows[0].Cells[2].Value.ToString()));
                string TenNV = Convert.ToString(f.Select_GetValue("TenNV","NhanVien","MaNV", dtgPhieuXuat.Rows[0].Cells[10].Value.ToString()));
                PhieuXuat.MailMerge.Execute(new[] { "Ngay_Thang_Nam" }, new[] { string.Format("Nam Định , ngày {0} tháng {1} năm {2}", Today.Day, Today.Month, Today.Year) });
                PhieuXuat.MailMerge.Execute(new[] { "Ma_Xuat" }, new[] { dtgPhieuXuat.Rows[0].Cells[0].Value.ToString() });
                PhieuXuat.MailMerge.Execute(new[] { "Ma_Khach_Hang" }, new[] { dtgPhieuXuat.Rows[0].Cells[2].Value.ToString() });
                PhieuXuat.MailMerge.Execute(new[] { "Ten_Khach_Hang" }, new[] { dtgPhieuXuat.Rows[0].Cells[3].Value.ToString() });
                PhieuXuat.MailMerge.Execute(new[] { "THUE" }, new[] { dtgPhieuXuat.Rows[0].Cells[4].Value.ToString() });
                PhieuXuat.MailMerge.Execute(new[] { "Dia_Chi" }, new[] { DiaChi });
                PhieuXuat.MailMerge.Execute(new[] { "SDT" }, new[] { DienThoai });
                PhieuXuat.MailMerge.Execute(new[] { "BANK" }, new[] { Bank });
                PhieuXuat.MailMerge.Execute(new[] { "Ma_Nhan_Vien" }, new[] { dtgPhieuXuat.Rows[0].Cells[10].Value.ToString() });
                PhieuXuat.MailMerge.Execute(new[] { "Ten_Nhan_Vien" }, new[] { TenNV });

                int count = dtgPhieuXuat.Rows.Count;
                Table ThongTin = PhieuXuat.GetChild(NodeType.Table, 0, true) as Table;
                int row = 1;
                ThongTin.InsertRows(row, row, count - 1);
                for (int i = 0; i < count; i++)
                {
                    ThongTin.PutValue(row, 0, dtgPhieuXuat.Rows[i].Cells[5].Value.ToString());
                    ThongTin.PutValue(row, 1, dtgPhieuXuat.Rows[i].Cells[6].Value.ToString());
                    ThongTin.PutValue(row, 2, dtgPhieuXuat.Rows[i].Cells[7].Value.ToString());
                    ThongTin.PutValue(row, 3, dtgPhieuXuat.Rows[i].Cells[8].Value.ToString());
                    ThongTin.PutValue(row, 4, dtgPhieuXuat.Rows[i].Cells[9].Value.ToString());
                    ThongTin.PutValue(row, 5, dtgPhieuXuat.Rows[i].Cells[11].Value.ToString());
                    TongSoTien += double.Parse(dtgPhieuXuat.Rows[i].Cells[9].Value.ToString());
                    row++;
                }
                PhieuXuat.MailMerge.Execute(new[] { "Tong_So_Tien" }, new[] { TongSoTien.ToString() });
                PhieuXuat.SaveAndOpenFile("PhieuXuat.doc");
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin phiếu xuất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            FormXuat_Load(sender, e);
            check = false;
            txtMaPhieuXuat.Enabled = true;
            dtgPhieuXuat.DataSource = null;
        }
    }
}
