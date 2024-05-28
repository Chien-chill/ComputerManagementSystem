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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DoAn
{
    public partial class FormKhachHang : Form
    {
        bool CheckClickBtnSua = false;
        Functions f = new Functions();
        public FormKhachHang()
        {
            InitializeComponent();
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = false;
            pnKH.Visible = true;
            pnKH.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnSuaKH.Enabled = false;
            btnTimKiemKH.Enabled = false;
        }
        bool checkError = false;
        public void CheckInputTxt()
        {
            int songuyen = 0;
            DateTime date = new DateTime(2023, 11, 22);
            if (txtMaKH.Text == "")
            {
                f.ErrorWarning(errorProvider1,txtMaKH,"Chưa nhập mã khách hàng");
                checkError = true;
            }
            else if (txtTenKH.Text == "")
            {
                f.ErrorWarning(errorProvider1,txtTenKH,"Chưa nhập tên khách hàng");
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
            else if (txtBank.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtBank, "Chưa nhập bảo hành");
                checkError = true;

            }
        }

        public void ResetTextBox()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtCCCD.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            dtpNgaySinh.Value = new DateTime(2023,11,22);
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtBank.Text = "";
            txtGhiChu.Text = "";
            radHaiLong.Checked = false;
            radRatHaiLong.Checked = false;
            radTe.Checked = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            clear_whitespace();
            checkError = false;
            CheckInputTxt();
            if (!checkError)
            {
                if (checkClickdtg)
                {
                    checkClickdtg = false;
                    if (f.Select_TblCheck("MaKH","KhachHang","MaKH",txtMaKH.Text) && txtMaKH.Text != dtgKH.Rows[numrow].Cells[0].Value.ToString())
                    {
                        f.ErrorWarning(errorProvider1, txtMaKH, "Mã khách hàng đã tồn tại");
                    }
                    else
                    {
                        string GioiTinh = string.Empty;
                        string FeedBack = string.Empty;
                        if (radNam.Checked == true)
                        {
                            GioiTinh = "Nam";
                        }
                        else if (radNu.Checked == true)
                        {
                            GioiTinh = "Nữ";
                        }
                        if (radRatHaiLong.Checked == true)
                        {
                            FeedBack = "Rất hài lòng";
                        }
                        else if (radHaiLong.Checked == true)
                        {
                            FeedBack = "Hài lòng";
                        }
                        else if (radTe.Checked == true)
                        {
                            FeedBack = "Tệ";
                        }
                        string[] field = { "MaKH", "TenKH", "CCCD", "GioiTinhKH", "NgaySinhKH", "DiaChiKH", "DienThoaiKH", "FeedBack", "Bank", "GhiChu" };
                        SqlParameter[] parameter = new SqlParameter[]
                        {
                            new SqlParameter("@1",txtMaKH.Text),
                            new SqlParameter("@2",txtTenKH.Text),
                            new SqlParameter("@3",txtCCCD.Text),
                            new SqlParameter("@4",GioiTinh),
                            new SqlParameter("@5",dtpNgaySinh.Value.ToShortDateString()),
                            new SqlParameter("@6",txtDiaChi.Text),
                            new SqlParameter("@7",txtDienThoai.Text),
                            new SqlParameter("@8",FeedBack),
                            new SqlParameter("@9",txtBank.Text),
                            new SqlParameter("@10",txtGhiChu.Text)
                        };
                        string[] fieldCondition = { "MaKH" };
                        SqlParameter[] parameterCondition = new SqlParameter[]
                        {
                            new SqlParameter("@11",dtgKH.Rows[numrow].Cells[0].Value.ToString())
                        };
                        f.UpdateDataTable("KhachHang",field,parameter,fieldCondition,parameterCondition);
                        dtgKH.DataSource = f.ReadData("KhachHang","1","1");
                        
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn dòng để sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetTextBox();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            pnKH.Visible = false;
            btnThemKH.Enabled = true;
            btnSuaKH.Enabled = true;
            btnXoaKH.Enabled = true;
            btnTimKiemKH.Enabled = true;
            ResetTextBox();
        }
        public void clear_whitespace()
        {
            TextBox[] txt = {txtMaKH, txtTenKH, txtDiaChi, txtDienThoai, txtBank, txtGhiChu, txtCCCD};
            f.clear_whitespace(txt);
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            btnThemKH.Enabled = true;
            btnSuaKH.Enabled = true;
            btnXoaKH.Enabled = true;
            btnTimKiemKH.Enabled = true;
            pnKH.Visible = false;
            dtgKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgKH.DataSource = dtgKH.DataSource = f.ReadData("KhachHang", "1", "1");
            ;

        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = true;
            pnKH.Visible = true;
            btnThemKH.Enabled = false;
            pnKH.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.Visible = true;
            btnLuu.Visible = false;
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (checkClickdtg)
            {
                string[] fieldCondition = { "MaKH" };
                SqlParameter[] parameterCondition = new SqlParameter[]
                {
                    new SqlParameter("@1",dtgKH.Rows[numrow].Cells[0].Value.ToString())
                };
                f.DeleteDataTable("KhachHang",fieldCondition,parameterCondition);
                dtgKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgKH.DataSource = f.ReadData("KhachHang","1","1");
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng để xoá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            checkClickdtg = false;
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            pnInputSearch.Visible = true;
        }
        int numrow;
        bool checkClickdtg = false;

        private void dtgKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            if (CheckClickBtnSua && numrow >= 0)
            {
                if(dtgKH.Rows[numrow].Cells[4].Value.ToString() == "Nam")
                {
                    radNam.Checked = true;
                }    
                else if(dtgKH.Rows[numrow].Cells[4].Value.ToString()=="Nữ")
                {
                    radNu.Checked = true;
                }
                if(dtgKH.Rows[numrow].Cells[7].Value.ToString().Trim() == "Rất hài lòng")
                {
                    radRatHaiLong.Checked = true;
                }
                else if (dtgKH.Rows[numrow].Cells[7].Value.ToString().Trim() == "Hài lòng")
                {
                    radHaiLong.Checked = true;
                }
                else if (dtgKH.Rows[numrow].Cells[7].Value.ToString().Trim() == "Tệ")
                {
                    radTe.Checked = true;
                }
                string date = dtgKH.Rows[numrow].Cells[3].Value.ToString(); 
                string[] Split = date.Split('/');
                dtpNgaySinh.Value = new DateTime(int.Parse(Split[2]), int.Parse(Split[1]), int.Parse(Split[0]));
                txtMaKH.Text = dtgKH.Rows[numrow].Cells[0].Value.ToString();
                txtTenKH.Text = dtgKH.Rows[numrow].Cells[1].Value.ToString();
                txtCCCD.Text = dtgKH.Rows[numrow].Cells[2].Value.ToString();
                txtDiaChi.Text = dtgKH.Rows[numrow].Cells[5].Value.ToString();
                txtDienThoai.Text = dtgKH.Rows[numrow].Cells[6].Value.ToString();
                txtBank.Text = dtgKH.Rows[numrow].Cells[8].Value.ToString();
                txtGhiChu.Text = dtgKH.Rows[numrow].Cells[9].Value.ToString();
            }
            checkClickdtg = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            clear_whitespace();
            checkError = false;
            CheckInputTxt();
            if (!checkError)
            {
                if (f.Select_TblCheck("MaKH", "KhachHang", "MaKH", txtMaKH.Text))
                {
                    f.ErrorWarning(errorProvider1, txtMaKH, "Mã khách hàng đã tồn tại");
                }
                else
                {
                    string GioiTinh=string.Empty;
                    string FeedBack=string.Empty;
                    if (radNam.Checked == true)
                    {
                        GioiTinh = "Nam";
                    }
                    else if (radNu.Checked == true)
                    {
                        GioiTinh = "Nữ";
                    }
                    if (radRatHaiLong.Checked == true)
                    {
                        FeedBack = "Rất hài lòng";
                    }
                    else if (radHaiLong.Checked == true)
                    {
                        FeedBack = "Hài lòng";
                    }
                    else if (radTe.Checked == true)
                    {
                        FeedBack = "Tệ";
                    }
                    SqlParameter[] parameter = new SqlParameter[]
                       {
                            new SqlParameter("@1",txtMaKH.Text),
                            new SqlParameter("@2",txtTenKH.Text),
                            new SqlParameter("@3",txtCCCD.Text),
                            new SqlParameter("@4",dtpNgaySinh.Value.ToShortDateString()),
                            new SqlParameter("@5",GioiTinh),
                            new SqlParameter("@6",txtDiaChi.Text),
                            new SqlParameter("@7",txtDienThoai.Text),
                            new SqlParameter("@8",FeedBack),
                            new SqlParameter("@9",txtBank.Text),
                            new SqlParameter("@10",txtGhiChu.Text)
                       };
                    f.InsertDataIntoTable("KhachHang(MaKH, TenKH, CCCD, NgaySinhKH, GioiTinhKH, DiaChiKH, DienThoaiKH, FeedBack, Bank, GhiChu)",parameter);
                    ResetTextBox();
                    dtgKH.DataSource = f.ReadData("KhachHang","1","1");
                }
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                lblTimKiem.Visible = false;
            }
            else
            {
                lblTimKiem.Visible = true;
            }
            string[] fieldCondition = { "MaKH", "TenKH", "DiaChiKH", "DienThoaiKH", "GioiTinhKH","NgaySinhKH","Bank","FeedBack","CCCD","GhiChu" };
            SqlParameter[] parameterCondition = new SqlParameter[]
            {
                new SqlParameter("@1","%"+txtTimKiem.Text+"%")
            };
            dtgKH.DataSource = f.SelectCondition("KhachHang",fieldCondition,parameterCondition);
        }

        private void lblTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
        }

        private void txtTimKiem_MouseLeave(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                lblTimKiem.Visible = true;
            }
        }

        private void btnXTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            pnInputSearch.Visible = false;
            FormKhachHang_Load(sender, e);
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            lblTimKiem.Visible = false;
        }
    }
}
