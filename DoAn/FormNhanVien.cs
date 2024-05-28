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
using System.Text.RegularExpressions;
using Aspose.Words;
using ThuVienWinform.Report.AsposeWordExtension;
using Aspose.Words.Tables;
namespace DoAn
{
    public partial class FormNhanVien : Form
    {
        bool CheckClickBtnSua = false;
        Functions f = new Functions();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            btnThemNV.Enabled = true;
            btnSuaNV.Enabled = true;
            btnXoaNV.Enabled = true;
            pnNV.Visible = false;
            dtgNV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgNV.DataSource = f.ReadData("NhanVien", "1", "1");
            dtgTK.DataSource = f.ReadData("TaiKhoan", "1", "1");
            btnInsert.Visible = true;
            btnSave.Visible = false;
            btnDelete.Visible = false;
        }
        bool checkError = false;
        public void CheckInputTxt()
        {
            int songuyen = 0;
            DateTime date = new DateTime(2023, 11, 25);
            if (txtMaNV.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMaNV, "Chưa nhập mã nhân viên");
                checkError = true;
            }
            else if (txtTenNV.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtTenNV, "Chưa nhập tên nhân viên");
                checkError = true;
            }
            else if (txtCCCD.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtCCCD, "Chưa nhập số căn cước");
                    checkError = true;
            }
            else if (radNam.Checked == false && radNu.Checked == false)
            {
                errorProvider1.SetError(radNu, "Chưa chọn giới tính");
                checkError = true;
            }
            else if (dtpNgaySinh.Value == date)
            {
                errorProvider1.SetError(dtpNgaySinh, "Chưa nhập ngày sinh");
                checkError = true;
            }
            else if (2023 - dtpNgaySinh.Value.Year < 18)
            {
                errorProvider1.SetError(dtpNgaySinh, "Yêu cầu trên 18 tuổi");
                checkError = true;
            }
            else if (txtDiaChi.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtDiaChi, "Chưa nhập địa chỉ");
                checkError = true;
            }
            else if (txtDienThoai.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtDienThoai, "Chưa nhập số điện thoại");
                checkError = true;
            }
            else if (int.TryParse(txtDienThoai.Text, out songuyen) == false || int.Parse(txtDienThoai.Text) <= 0)
            {
                f.ErrorWarning(errorProvider1, txtDienThoai, "Sai định dạng số điện thoại");
                checkError = true;
            }
            else if (txtChucVu.Text == "")
            {
                errorProvider1.SetError(txtChucVu, "Chưa chọn chức vụ");
                checkError = true;
            }
            else if (txtLuong.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtLuong, "Chưa nhập lương");
                checkError = true;
            }
            else if (int.TryParse(txtLuong.Text, out songuyen) == false || int.Parse(txtLuong.Text) <= 0)
            {
                f.ErrorWarning(errorProvider1, txtLuong, "Sai định dạng lương");
                checkError = true;
            }
            else if (txtBank.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtBank, "Chưa nhập bảo hành");
                checkError = true;
            }
        }
        public void ResetTextBox()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtCCCD.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            dtpNgaySinh.Value = new DateTime(2023, 11, 25);
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtBank.Text = "";
            txtGhiChu.Text = "";
            txtChucVu.Text = "";
            txtLuong.Text = "";
            
        }
       
        public void clear_whitespace()
        {
            TextBox[] txt = { txtMaNV, txtTenNV, txtDiaChi, txtBank, txtGhiChu, txtCCCD, txtLuong};
            f.clear_whitespace(txt);
        }
        int numrow;
        bool checkClickdtg = false;
        int numrow1;
        public void ClearTextBox()
        {
             txtTaiKhoan.Text = "";
             txtMatKhau.Text = "";
        }
        private void dtgTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow1 = e.RowIndex;
            if(numrow1 >=0)
            {
            txtTaiKhoan.Text = dtgTK.Rows[numrow1].Cells[0].Value.ToString();
            txtMatKhau.Text = dtgTK.Rows[numrow1].Cells[1].Value.ToString();
                btnInsert.Visible = false;
                btnSave.Visible = true;
                btnDelete.Visible = true;
            }
        }
        public void showbtn()
        {
            btnInsert.Visible = true;
            btnSave.Visible = false;
            btnDelete.Visible = false;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtTaiKhoan.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtTaiKhoan, "Chưa nhập mã nhân viên");
            }
            else if (txtMatKhau.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMatKhau, "Chưa nhập mật khẩu");
            }
            else
            {
                if (!f.Select_TblCheck("MaNV", "NhanVien", "MaNV", txtTaiKhoan.Text))
                {
                    f.ErrorWarning(errorProvider1, txtTaiKhoan, "Mã nhân viên không tồn tại");
                }
                else
                {
                    if (f.Select_TblCheck("MaNV","TaiKhoan","MaNV",txtTaiKhoan.Text))
                    {
                        f.ErrorWarning(errorProvider1, txtTaiKhoan, "Tài khoản đã tồn tại");
                    }
                    else
                    {
                        SqlParameter[] parameter = new SqlParameter[]
                        {
                            new SqlParameter("@1",txtTaiKhoan.Text),
                            new SqlParameter("@2",txtMatKhau.Text)
                        };
                        f.InsertDataIntoTable("TaiKhoan(MaNV,MatKhau)", parameter);
                        dtgTK.DataSource = f.ReadData("TaiKhoan", "1", "1");
                        ClearTextBox();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] field = { "MaNV" };
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@1",dtgTK.Rows[numrow1].Cells[0].Value.ToString())
            };
            f.DeleteDataTable("TaiKhoan", field, parameter);
            dtgTK.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgTK.DataSource = f.ReadData("TaiKhoan", "1", "1");
            ClearTextBox();
            showbtn();
        }

        private void btnThemNV_Click_1(object sender, EventArgs e)
        {
            CheckClickBtnSua = false;
            pnNV.Visible = true;
            pnNV.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnSuaNV.Enabled = false;
        }
        private void btnDong_Click_1(object sender, EventArgs e)
        {
            pnNV.Visible = false;
            btnThemNV.Enabled = true;
            btnSuaNV.Enabled = true;
            btnXoaNV.Enabled = true;
            ResetTextBox();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            clear_whitespace();
            checkError = false;
            CheckInputTxt();
            if (!checkError)
            {
                
                if (f.Select_TblCheck("MaNV","NhanVien","MaNV",txtMaNV.Text) && txtMaNV.Text != dtgNV.Rows[numrow].Cells[0].Value.ToString())
                {
                    f.ErrorWarning(errorProvider1, txtMaNV, "Mã nhân viên đã tồn tại");
                }
                else
                {
                    if (checkClickdtg)
                    {
                        checkClickdtg = false;
                        string GioiTinh = string.Empty;
                        if (radNam.Checked == true)
                        {
                            GioiTinh = "Nam";
                        }
                        else if (radNu.Checked == true)
                        {
                            GioiTinh = "Nữ";
                        }
                        string[] field = { "MaNV", "TenNV", "CCCD", "GioiTinhNV", "NgaySinhNV", "Bank", "GhiChu", "ChucVu", "Luong" };
                        SqlParameter[] parameter = new SqlParameter[]
                        {
                            new SqlParameter("@1",txtMaNV.Text),
                            new SqlParameter("@2",txtTenNV.Text),
                            new SqlParameter("@3",txtCCCD.Text),
                            new SqlParameter("@4",GioiTinh),
                            new SqlParameter("@5",dtpNgaySinh.Value.ToShortDateString()),
                            new SqlParameter("@6",txtDiaChi.Text),
                            new SqlParameter("@7",txtDienThoai.Text),
                            new SqlParameter("@8",txtBank.Text),
                            new SqlParameter("@9",txtGhiChu.Text),
                            new SqlParameter("@10",txtChucVu.Text),
                            new SqlParameter("@11",double.Parse(txtLuong.Text))
                        };
                        string[] fieldCondition = { "MaNV" };
                        SqlParameter[] parameterCondition = new SqlParameter[]
                        {
                            new SqlParameter("@12",dtgNV.Rows[numrow].Cells[0].Value.ToString())
                        };
                        f.UpdateDataTable("NhanVien", field, parameter, fieldCondition, parameterCondition);
                        dtgNV.DataSource = f.ReadData("NhanVien","1","1");
                    }
                    else
                    {

                        MessageBox.Show("Chưa chọn dòng để sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetTextBox();
                    }    
                }
            }
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            clear_whitespace();
            checkError = false;
            CheckInputTxt();
            if (!checkError)
            {
                if (f.Select_TblCheck("MaNV", "NhanVien", "MaNV", txtMaNV.Text))
                {
                    f.ErrorWarning(errorProvider1, txtMaNV, "Mã nhân viên đã tồn tại");
                }
                else
                {
                    string GioiTinh = string.Empty;
                    if (radNam.Checked == true)
                    {
                        GioiTinh = "Nam";
                    }
                    else if (radNu.Checked == true)
                    {
                        GioiTinh = "Nữ";
                    }
                    SqlParameter[] parameter = new SqlParameter[]
                       {
                            new SqlParameter("@1",txtMaNV.Text),
                            new SqlParameter("@2",txtTenNV.Text),
                            new SqlParameter("@3",txtCCCD.Text),
                            new SqlParameter("@4",dtpNgaySinh.Value.ToShortDateString()),
                            new SqlParameter("@5",GioiTinh),
                            new SqlParameter("@6",txtDiaChi.Text),
                            new SqlParameter("@7",txtDienThoai.Text),
                            new SqlParameter("@8",txtBank.Text),
                            new SqlParameter("@9",txtGhiChu.Text),
                            new SqlParameter("@10",txtChucVu.Text),
                            new SqlParameter("@11",double.Parse(txtLuong.Text))
                       };
                    f.InsertDataIntoTable("NhanVien(MaNV,TenNV,CCCD,NgaySinhNV,GioiTinhNV,DiaChiNV,DienThoaiNV,ChucVu,Luong,Bank,GhiChu)",parameter);
                    ResetTextBox();
                    dtgNV.DataSource = f.ReadData("NhanVien", "1", "1");
                }
            }
        }

        private void btnSuaNV_Click_1(object sender, EventArgs e)
        {
            CheckClickBtnSua = true;
            pnNV.Visible = true;
            btnThemNV.Enabled = false;
            pnNV.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.Visible = true;
            btnLuu.Visible = false;
        }

        private void btnXoaNV_Click_1(object sender, EventArgs e)
        {
            if (checkClickdtg)
            {
                string[] fieldCondition = { "MaNV" };
                SqlParameter[] parameterCondition = new SqlParameter[]
                {
                    new SqlParameter("@1", dtgNV.Rows[numrow].Cells[0].Value.ToString())
                };
                f.DeleteDataTable("NhanVien", fieldCondition, parameterCondition);
                dtgNV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgNV.DataSource = f.ReadData("NhanVien", "1", "1");
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng để xoá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            checkClickdtg = false;
        }

        private void dtgNV_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            if (CheckClickBtnSua && numrow >= 0)
            {
                if (dtgNV.Rows[numrow].Cells[4].Value.ToString() == "Nam")
                {
                    radNam.Checked = true;
                }
                else if (dtgNV.Rows[numrow].Cells[4].Value.ToString() == "Nữ")
                {
                    radNu.Checked = true;
                }
                string date = dtgNV.Rows[numrow].Cells[3].Value.ToString();
                string[] Split = date.Split('/');
                dtpNgaySinh.Value = new DateTime(int.Parse(Split[2]), int.Parse(Split[1]), int.Parse(Split[0]));
                txtMaNV.Text = dtgNV.Rows[numrow].Cells[0].Value.ToString();
                txtTenNV.Text = dtgNV.Rows[numrow].Cells[1].Value.ToString();
                txtCCCD.Text = dtgNV.Rows[numrow].Cells[2].Value.ToString();
                txtDiaChi.Text = dtgNV.Rows[numrow].Cells[5].Value.ToString();
                txtDienThoai.Text = dtgNV.Rows[numrow].Cells[6].Value.ToString();
                txtChucVu.Text = dtgNV.Rows[numrow].Cells[7].Value.ToString();
                txtLuong.Text = dtgNV.Rows[numrow].Cells[8].Value.ToString();
                txtBank.Text = dtgNV.Rows[numrow].Cells[9].Value.ToString();
                txtGhiChu.Text = dtgNV.Rows[numrow].Cells[10].Value.ToString();
            }
            checkClickdtg = true;
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            if (dtgNV.DataSource != null)
            {
                var Today = DateTime.Now;
                Document BangLuong = new Document(@"TemplateWord\\Mau_Bang_Luong.doc");
                int count = dtgNV.Rows.Count;
                BangLuong.MailMerge.Execute(new[] { "Ngay_Thang_Nam" }, new[] { string.Format("Nam Định , ngày {0} tháng {1} năm {2}", Today.Day, Today.Month, Today.Year) });
                Table ThongTin = BangLuong.GetChild(NodeType.Table, 0, true) as Table;
                int row = 1;
                ThongTin.InsertRows(row, row, count - 1);
                for (int i = 0; i < count; i++)
                {
                    ThongTin.PutValue(row, 0, dtgNV.Rows[i].Cells[0].Value.ToString());
                    ThongTin.PutValue(row, 1, dtgNV.Rows[i].Cells[1].Value.ToString());
                    ThongTin.PutValue(row, 2, dtgNV.Rows[i].Cells[6].Value.ToString());
                    ThongTin.PutValue(row, 3, dtgNV.Rows[i].Cells[7].Value.ToString());
                    ThongTin.PutValue(row, 4, dtgNV.Rows[i].Cells[8].Value.ToString());
                    ThongTin.PutValue(row, 5, dtgNV.Rows[i].Cells[9].Value.ToString());
                    ThongTin.PutValue(row, 6, dtgNV.Rows[i].Cells[10].Value.ToString());
                    row++;
                }
                BangLuong.SaveAndOpenFile("BangLuong.doc");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtTaiKhoan.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtTaiKhoan, "Chưa nhập mã nhân viên");
            }
            else if (txtMatKhau.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMatKhau, "Chưa nhập mật khẩu");
            }
            else
            {

                if (!f.Select_TblCheck("MaNV", "NhanVien", "MaNV", txtTaiKhoan.Text))
                {
                    f.ErrorWarning(errorProvider1, txtTaiKhoan, "Mã nhân viên không tồn tại");
                }
                else
                {

                    if (f.Select_TblCheck("MaNV", "TaiKhoan", "MaNV", txtTaiKhoan.Text) && txtTaiKhoan.Text != dtgTK.Rows[numrow1].Cells[0].Value.ToString())
                    {
                        f.ErrorWarning(errorProvider1, txtTaiKhoan, "Tài khoản đã tồn tại");
                    }
                    else
                    {
                        string[] field = { "MaNV", "MatKhau" };
                        SqlParameter[] parameter = new SqlParameter[]
                        {
                            new SqlParameter("@1",txtTaiKhoan.Text),
                            new SqlParameter("@2",txtMatKhau.Text)
                        };
                        string[] fieldCondition = { "MaNV" };
                        SqlParameter[] parameterCondition = new SqlParameter[]
                        {
                            new SqlParameter("@3", dtgTK.Rows[numrow1].Cells[0].Value.ToString())
                        };
                        f.UpdateDataTable("TaiKhoan", field, parameter, fieldCondition, parameterCondition);
                        dtgTK.DataSource = f.ReadData("TaiKhoan", "1", "1");
                        ClearTextBox();
                        showbtn();
                    }
                }
            }
        }
    }
}
