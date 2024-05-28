using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using Aspose.Words;
using ThuVienWinform.Report.AsposeWordExtension;
using Aspose.Words.Tables;
using Aspose.Words.Fields;
using DevExpress.XtraReports.Parameters;

namespace DoAn
{
    public partial class FormNhap : Form
    {
            PhieuNhap phieuNhap;
            bool CheckClickBtnSua = false;
            Functions f = new Functions();
        public FormNhap()
        {
            InitializeComponent();
        }

        private void btnThemNhap_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = false;
            pnNhap.Visible= true;
            pnNhap.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnSuaNhap.Enabled = false;
            dtpPhieuNhap.Enabled = false;
            lblDatePhieuNhap.Text= DateTime.Now.ToShortDateString();
            if(dtgPhieuNhap.DataSource == null)
            {
                txtMaCT.Enabled = true;
                txtThue.Enabled = true;
            }
            else
            {
                txtMaCT.Enabled = false;
                txtThue.Enabled = false;
            }
            txtMaNV.Text = f.SelectTemp();
        }
        private void FormNhap_Load(object sender, EventArgs e)
        {
            pnNhap.Visible = false;
            lblDateNow.Text = DateTime.Now.ToShortDateString();
            btnThemNhap.Enabled = true;
            btnSuaNhap.Enabled = true;
            btnXoaNhap.Enabled = true;
            btnInNhap.Enabled = true;
        }
        public void clear_whitespace ()
        {
            TextBox[] txt = { txtMaCT, txtMaMT, txtThue, txtMaNV, txtSoLuong, txtGhiChu };
            f.clear_whitespace(txt);
        }
        bool check = false;
        bool CheckData;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int songuyen = 0;
            errorProvider1.Clear();
            clear_whitespace();
            CheckData = f.Select_TblCheck("MaPhieuNhap", "PhieuNhap", "MaPhieuNhap", txtMaPhieuNhap.Text);
            if (CheckData && check == false)
            {
                f.ErrorWarning(errorProvider1,txtMaPhieuNhap, "Mã phiếu nhập đã tồn tại");
            }
            else if (txtMaPhieuNhap.Text == "")
            {
                f.ErrorWarning(errorProvider1,txtMaPhieuNhap, "Chưa nhập mã phiếu nhập");
            }
            else if (txtMaCT.Text == "")
            {
                f.ErrorWarning(errorProvider1,txtMaCT, "Chưa nhập mã công ty");
            }
            else if (txtMaMT.Text == "")
            {
                f.ErrorWarning(errorProvider1,txtMaMT, "Chưa nhập mã máy tính");
            }
            else if (txtThue.Text == "")
            {
                f.ErrorWarning(errorProvider1,txtThue, "Chưa nhập mã số thuế");
            }
            else if (txtSoLuong.Text == "")
            {
                f.ErrorWarning(errorProvider1,txtSoLuong, "Chưa nhập số lượng");
            }
            else if (int.TryParse(txtSoLuong.Text, out songuyen) == false || int.Parse(txtSoLuong.Text) <= 0)
            {
                f.ErrorWarning(errorProvider1,txtSoLuong, "Sai định dạng số lượng");
            }
            else if (txtMaNV.Text == "")
            {
               f.ErrorWarning(errorProvider1,txtMaNV, "Chưa nhập mã nhân viên");
            }
            else
            {
                check = true;
                phieuNhap = new PhieuNhap()
                {
                    MaPhieuNhap = txtMaPhieuNhap.Text,
                    NgayLamPhieu = lblDatePhieuNhap.Text,
                    MaCT = txtMaCT.Text,
                    Thue = txtThue.Text,
                    MaMT = txtMaMT.Text,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    MaNV = txtMaNV.Text,
                    GhiChu = txtGhiChu.Text
                };
                dtgPhieuNhap.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                CheckData = f.Select_TblCheck("MaCT", "CongTy", "MaCT", phieuNhap.MaCT);
                if (!CheckData)
                {
                    f.ErrorWarning(errorProvider1,txtMaCT, "Mã công ty không tồn tại");
                }
                else
                {
                    CheckData = f.Select_TblCheck("MaMT", "MayTinh", "MaMT", phieuNhap.MaMT);
                    if (!CheckData)
                    {
                        f.ErrorWarning(errorProvider1,txtMaMT, "Mã máy tính không tồn tại");
                    }
                    else
                    {
                        phieuNhap.TenMT = Convert.ToString(f.Select_GetValue("TenMT", "MayTinh", "MaMT", phieuNhap.MaMT));
                        phieuNhap.TenCT = Convert.ToString(f.Select_GetValue("TenCT","CongTy","MaCT",phieuNhap.MaCT));
                        phieuNhap.DonGia = Convert.ToDouble(f.Select_GetValue("DonGia", "MayTinh", "MaMT", phieuNhap.MaMT));
                        phieuNhap.ThanhTien = phieuNhap.DonGia * phieuNhap.SoLuong;
                        SqlParameter[] parameters = new SqlParameter[]
                        {
                            new SqlParameter("@ParameterName1", phieuNhap.MaPhieuNhap),
                            new SqlParameter("@ParameterName2", phieuNhap.NgayLamPhieu),
                            new SqlParameter("@ParameterName3", phieuNhap.MaCT),
                            new SqlParameter("@ParameterName4", phieuNhap.TenCT),
                            new SqlParameter("@ParameterName5", phieuNhap.Thue),
                            new SqlParameter("@ParameterName6", phieuNhap.MaMT),
                            new SqlParameter("@ParameterName7", phieuNhap.TenMT),
                            new SqlParameter("@ParameterName8", phieuNhap.SoLuong),
                            new SqlParameter("@ParameterName9", phieuNhap.DonGia),
                            new SqlParameter("@ParameterName10", phieuNhap.ThanhTien),
                            new SqlParameter("@ParameterName11", phieuNhap.MaNV),
                            new SqlParameter("@ParameterName12", phieuNhap.GhiChu)
                        };
                        f.InsertDataIntoTable("PhieuNhap(MaPhieuNhap,NgayLamPhieu,MaCT,TenCT,Thue,MaMT,TenMT,SoLuong,DonGia,ThanhTien,MaNV,GhiChu)", parameters);

                        txtMaPhieuNhap.Enabled = false;
                        txtMaCT.Enabled = false;
                        txtThue.Enabled = false;
                        txtMaMT.Text = "";
                        txtSoLuong.Text = "";
                        txtGhiChu.Text = "";
                        dtgPhieuNhap.DataSource = f.ReadData("PhieuNhap","MaPhieuNhap",txtMaPhieuNhap.Text);
                    }
                }
            }
        }
        private void btnSuaNhap_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = true;
            pnNhap.Visible = true;
            btnThemNhap.Enabled = false;
            btnXoaNhap.Enabled = false;
            pnNhap.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.Visible = true;
            btnLuu.Visible = false;
            dtpPhieuNhap.Enabled=false;
            txtMaNV.Text = f.SelectTemp();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            pnNhap.Visible = false;
            btnThemNhap.Enabled = true;
            btnSuaNhap.Enabled = true;
            btnXoaNhap.Enabled = true;
            dtpPhieuNhap.Enabled = true;
            txtMaMT.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
        }
            int numrow;
            bool checkClickdtg = false;
        private void dtgPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            if(CheckClickBtnSua && numrow >=0)
            {
             txtMaCT.Enabled = true;
             txtThue.Enabled = true;
            txtMaPhieuNhap.Text= dtgPhieuNhap.Rows[numrow].Cells[0].Value.ToString();
            txtMaCT.Text= dtgPhieuNhap.Rows[numrow].Cells[2].Value.ToString();
            txtThue.Text= dtgPhieuNhap.Rows[numrow].Cells[4].Value.ToString();
            txtMaMT.Text= dtgPhieuNhap.Rows[numrow].Cells[5].Value.ToString();
            txtSoLuong.Text= dtgPhieuNhap.Rows[numrow].Cells[7].Value.ToString();
            txtMaNV.Text= dtgPhieuNhap.Rows[numrow].Cells[10].Value.ToString();
            txtGhiChu.Text= dtgPhieuNhap.Rows[numrow].Cells[11].Value.ToString();
            }
            checkClickdtg = true; 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int songuyen = 0;
            errorProvider1.Clear();
            clear_whitespace();
            if (txtMaCT.Text == "")
            {
                f.ErrorWarning(errorProvider1,txtMaCT, "Chưa nhập mã công ty");
            }
            else if (txtMaMT.Text == "")
            {
                f.ErrorWarning(errorProvider1,txtMaMT, "Chưa nhập mã máy tính");
            }
            else if (txtThue.Text == "")
            {
                 f.ErrorWarning(errorProvider1,txtThue, "Chưa nhập mã số thuế");
            }
            else if (txtSoLuong.Text == "")
            {
                f.ErrorWarning(errorProvider1,txtSoLuong, "Chưa nhập số lượng");
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
                CheckData = f.Select_TblCheck("MaCT","CongTy","MaCT",txtMaCT.Text);
                if (!CheckData)
                {
                    f.ErrorWarning(errorProvider1, txtMaCT, "Mã công ty không tồn tại");
                }
                else
                {
                     CheckData = f.Select_TblCheck("MaMT","MayTinh","MaMT",txtMaMT.Text);
                    if (!CheckData)
                    {
                        f.ErrorWarning(errorProvider1, txtMaMT, "Mã máy tính không tồn tại");
                    }
                    else
                    {
                        if (checkClickdtg)
                        {
                            checkClickdtg = false;
                            string TenMT = Convert.ToString(f.Select_GetValue("TenMT", "MayTinh", "MaMT", txtMaMT.Text));
                            string TenCT = Convert.ToString(f.Select_GetValue("TenCT", "CongTy", "MaCT", txtMaCT.Text));
                            double DonGia = Convert.ToDouble(f.Select_GetValue("DonGia", "MayTinh", "MaMT", txtMaMT.Text));
                            double ThanhTien = DonGia * int.Parse(txtSoLuong.Text);
                            string[] field = { "MaMT", "TenMT", "DonGia", "SoLuong", "ThanhTien", "MaNV", "GhiChu" };
                            SqlParameter[] parameters = new SqlParameter[] {
                                new SqlParameter("@ParameterName1",txtMaMT.Text),
                                new SqlParameter("@ParameterName2",TenMT),
                                new SqlParameter("@ParameterName3",DonGia),
                                new SqlParameter("@ParameterName4",txtSoLuong.Text),
                                new SqlParameter("@ParameterName5",ThanhTien),
                                new SqlParameter("@ParameterName6",txtMaNV.Text),
                                new SqlParameter("@ParameterName7",txtGhiChu.Text)
                            };
                            string[] fieldCondition = { "MaPhieuNhap", "MaCT", "MaMT", "Thue", "SoLuong", "MaNV", "GhiChu" };
                            SqlParameter[] parametersCondition = new SqlParameter[] {
                                new SqlParameter("@ParameterName1a",txtMaPhieuNhap.Text),
                                new SqlParameter("@ParameterName2a",dtgPhieuNhap.Rows[numrow].Cells[2].Value.ToString()),
                                new SqlParameter("@ParameterName3a",dtgPhieuNhap.Rows[numrow].Cells[5].Value.ToString()),
                                new SqlParameter("@ParameterName4a",dtgPhieuNhap.Rows[numrow].Cells[4].Value.ToString()),
                                new SqlParameter("@ParameterName5a",dtgPhieuNhap.Rows[numrow].Cells[7].Value.ToString()),
                                new SqlParameter("@ParameterName6a",dtgPhieuNhap.Rows[numrow].Cells[10].Value.ToString()),
                                new SqlParameter("@ParameterName7a",dtgPhieuNhap.Rows[numrow].Cells[11].Value.ToString())
                            };
                            f.UpdateDataTable("PhieuNhap", field, parameters, fieldCondition, parametersCondition);
                            string[] field1 = { "MaCT", "TenCT" };
                            SqlParameter[] parameters1 = new SqlParameter[]{
                                new SqlParameter("@ParameterName1b",txtMaCT.Text),
                                new SqlParameter("@ParameterName2b",TenCT)
                            };
                            string[] fieldCondition1 = { "MaPhieuNhap" };
                            SqlParameter[] parametersCondition1 = new SqlParameter[]{
                                new SqlParameter("@ParameterName1c",txtMaPhieuNhap.Text)
                            };
                            f.UpdateDataTable("PhieuNhap", field1, parameters1,fieldCondition1, parametersCondition1);
                            string[] field2 = { "Thue"};
                            SqlParameter[] parameters2 = new SqlParameter[]{
                                new SqlParameter("@ParameterName1d",txtThue.Text)
                            };
                            string[] fieldCondition2 = { "MaPhieuNhap" };
                            SqlParameter[] parametersCondition2 = new SqlParameter[]{
                                new SqlParameter("@ParameterName1c",txtMaPhieuNhap.Text)
                            };
                            f.UpdateDataTable("PhieuNhap", field2, parameters2, fieldCondition2, parametersCondition2);
                            dtgPhieuNhap.DataSource = f.ReadData("PhieuNhap","MaPhieuNhap",txtMaPhieuNhap.Text);
                            txtMaCT.Enabled = false;
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
        private void btnXoaNhap_Click(object sender, EventArgs e)
        {
            if(checkClickdtg)
            {
                
                checkClickdtg = false;
                SqlParameter[] parametersCondition = new SqlParameter[]
                         {
                            new SqlParameter("@ParameterName1", txtMaPhieuNhap.Text),
                            new SqlParameter("@ParameterName2", dtgPhieuNhap.Rows[numrow].Cells[2].Value.ToString()),
                            new SqlParameter("@ParameterName3", dtgPhieuNhap.Rows[numrow].Cells[4].Value.ToString()),
                            new SqlParameter("@ParameterName4", dtgPhieuNhap.Rows[numrow].Cells[5].Value.ToString()),
                            new SqlParameter("@ParameterName5", dtgPhieuNhap.Rows[numrow].Cells[7].Value.ToString()),
                            new SqlParameter("@ParameterName6", dtgPhieuNhap.Rows[numrow].Cells[10].Value.ToString()),
                            new SqlParameter("@ParameterName7", dtgPhieuNhap.Rows[numrow].Cells[11].Value.ToString())
                         };
                string[] fieldCondition = {"MaPhieuNhap","MaCT","Thue","MaMT","SoLuong","MaNV","GhiChu"};
                f.DeleteDataTable("PhieuNhap",fieldCondition,parametersCondition);
                dtgPhieuNhap.DataSource = f.ReadData("PhieuNhap", "MaPhieuNhap", txtMaPhieuNhap.Text); ;
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng để xoá","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            } 
                
        }
        private void dtpPhieuNhap_ValueChanged(object sender, EventArgs e)
        {
            dtgPhieuNhap.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgPhieuNhap.DataSource = f.ReadData("PhieuNhap", "NgayLamPhieu", dtpPhieuNhap.Text); ;
                btnThemNhap.Enabled = false;
                btnSuaNhap.Enabled = false;
                btnXoaNhap.Enabled = false;
                btnInNhap.Enabled = false;
        }

        private void btnInNhap_Click(object sender, EventArgs e)
        {
            if (dtgPhieuNhap.DataSource != null)
            {
                    double TongSoTien = 0;
                    var Today = DateTime.Now;
                    Document PhieuNhap = new Document(@"TemplateWord\\Mau_Phieu_Nhap.doc");
                    string DiaChi = Convert.ToString(f.Select_GetValue("DiaChiCT","CongTy","MaCT", dtgPhieuNhap.Rows[0].Cells[2].Value.ToString()));
                    string DienThoai = Convert.ToString(f.Select_GetValue("DienThoaiCT", "CongTy", "MaCT", dtgPhieuNhap.Rows[0].Cells[2].Value.ToString()));
                    string Bank = Convert.ToString(f.Select_GetValue("BANK", "CongTy", "MaCT", dtgPhieuNhap.Rows[0].Cells[2].Value.ToString()));
                    string TenNV = Convert.ToString(f.Select_GetValue("TenNV", "NhanVien", "MaNV", dtgPhieuNhap.Rows[0].Cells[10].Value.ToString()));
                    PhieuNhap.MailMerge.Execute(new[] { "Ngay_Thang_Nam" }, new[] { string.Format("Nam Định , ngày {0} tháng {1} năm {2}", Today.Day, Today.Month, Today.Year) });
                    PhieuNhap.MailMerge.Execute(new[] { "Ma_Nhap" }, new[] { dtgPhieuNhap.Rows[0].Cells[0].Value.ToString() });
                    PhieuNhap.MailMerge.Execute(new[] { "Ma_Cong_Ty" }, new[] { dtgPhieuNhap.Rows[0].Cells[2].Value.ToString() });
                    PhieuNhap.MailMerge.Execute(new[] { "Ten_Cong_Ty" }, new[] { dtgPhieuNhap.Rows[0].Cells[3].Value.ToString() });
                    PhieuNhap.MailMerge.Execute(new[] { "THUE" }, new[] { dtgPhieuNhap.Rows[0].Cells[4].Value.ToString() });
                    PhieuNhap.MailMerge.Execute(new[] { "Dia_Chi" }, new[] { DiaChi });
                    PhieuNhap.MailMerge.Execute(new[] { "SDT" }, new[] { DienThoai });
                    PhieuNhap.MailMerge.Execute(new[] { "BANK" }, new[] { Bank });
                    PhieuNhap.MailMerge.Execute(new[] { "Ma_Nhan_Vien" }, new[] { dtgPhieuNhap.Rows[0].Cells[10].Value.ToString() });
                    PhieuNhap.MailMerge.Execute(new[] { "Ten_Nhan_Vien" }, new[] { TenNV });

                    int count = dtgPhieuNhap.Rows.Count;
                    Table ThongTin = PhieuNhap.GetChild(NodeType.Table, 0, true) as Table;
                    int row = 1;
                    ThongTin.InsertRows(row, row, count - 1);
                    for (int i = 0; i < count; i++)
                    {
                        ThongTin.PutValue(row, 0, dtgPhieuNhap.Rows[i].Cells[5].Value.ToString());
                        ThongTin.PutValue(row, 1, dtgPhieuNhap.Rows[i].Cells[6].Value.ToString());
                        ThongTin.PutValue(row, 2, dtgPhieuNhap.Rows[i].Cells[7].Value.ToString());
                        ThongTin.PutValue(row, 3, dtgPhieuNhap.Rows[i].Cells[8].Value.ToString());
                        ThongTin.PutValue(row, 4, dtgPhieuNhap.Rows[i].Cells[9].Value.ToString());
                        ThongTin.PutValue(row, 5, dtgPhieuNhap.Rows[i].Cells[11].Value.ToString());
                        TongSoTien += double.Parse(dtgPhieuNhap.Rows[i].Cells[9].Value.ToString());
                        row++;
                    }
                    PhieuNhap.MailMerge.Execute(new[] { "Tong_So_Tien" }, new[] { TongSoTien.ToString() });
                    PhieuNhap.SaveAndOpenFile("PhieuNhap.doc");
                    for(int i=0;i<count;i++)
                    {
                    string[] field_Kho = { "MaMT", "MaCT" };
                    SqlParameter[] pr_Kho = new SqlParameter[]
                        {
                            new SqlParameter("@1",dtgPhieuNhap.Rows[i].Cells[5].Value.ToString()),
                            new SqlParameter("@2",dtgPhieuNhap.Rows[i].Cells[2].Value.ToString())
                        };
                    if (f.Select_TblChecks("MaMT", "Kho",field_Kho, pr_Kho))
                    {
                       int SoLuongTon = Convert.ToInt16(f.Select_GetValues("SoLuongTon", "Kho", field_Kho, pr_Kho))+ int.Parse(dtgPhieuNhap.Rows[i].Cells[7].Value.ToString());
                        MessageBox.Show($"1 .{SoLuongTon}");
                        SqlParameter[] parameters = new SqlParameter[]
                        {
                            new SqlParameter("@11",SoLuongTon)
                        };
                        string[] field = {"SoLuongTon"};
                        f.UpdateDataTable("Kho", field, parameters, field_Kho, pr_Kho);
                        MessageBox.Show($"2. {f.Select_GetValues("SoLuongTon","Kho", field_Kho, pr_Kho)}");

                    }
                    else
                    {
                        double DonGiaNhap = Convert.ToDouble(f.Select_GetValue("DonGia", "MayTinh", "MaMT", dtgPhieuNhap.Rows[i].Cells[5].Value.ToString()));
                        double DonGiaBan = DonGiaNhap * 1.1;
                        SqlParameter[] parametersInsert = new SqlParameter[]
                        {
                            new SqlParameter("@3",dtgPhieuNhap.Rows[i].Cells[5].Value.ToString()),
                            new SqlParameter("@4",dtgPhieuNhap.Rows[i].Cells[6].Value.ToString()),
                            new SqlParameter("@5",dtgPhieuNhap.Rows[i].Cells[7].Value.ToString()),
                            new SqlParameter("@6",dtgPhieuNhap.Rows[0].Cells[2].Value.ToString()),
                            new SqlParameter("@7",dtgPhieuNhap.Rows[0].Cells[3].Value.ToString()),
                            new SqlParameter("@8",lblDatePhieuNhap.Text),
                            new SqlParameter("@9",DonGiaNhap),
                            new SqlParameter("@10",DonGiaBan)
                        };
                        f.InsertDataIntoTable("Kho(MaMT,TenMT,SoLuongTon,MaCT,TenCT,NgayNhap,DonGiaNhap,DonGiaBan)", parametersInsert);
                    }
                    }
                    
                }
            else
            {
                MessageBox.Show("Chưa nhập thông tin phiếu nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            FormNhap_Load(sender, e);
            check = false;
            txtMaPhieuNhap.Enabled = true;
            dtgPhieuNhap.DataSource = null;
        }
    }
}
