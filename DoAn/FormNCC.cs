using DevExpress.XtraPrinting;
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

namespace DoAn
{
    public partial class FormNCC : Form
    {
        bool CheckClickBtnSua = false;
        Functions f = new Functions();
        public FormNCC()
        {
            InitializeComponent();
        }
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = false;
            pnNCC.Visible = true;
            pnNCC.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnSuaNCC.Enabled = false;
            btnTimKiemNCC.Enabled = false;
        }
        bool checkError = false;
        public void CheckInputTxt()
        {
            int songuyen = 0;

            if (txtMaCT.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtMaCT, "Chưa nhập mã công ty");
                checkError = true;
            }
            else if (txtTenCT.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtTenCT, "Chưa nhập tên công ty");
                checkError = true;
            }
            else if (txtDiaChiCT.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtDiaChiCT, "Chưa nhập địa chỉ");
                    checkError = true;
            }
            else if (txtDienThoaiCT.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtDienThoaiCT, "Chưa nhập số điện thoại");
                checkError = true;
            }
            else if (int.TryParse(txtDienThoaiCT.Text, out songuyen) == false || int.Parse(txtDienThoaiCT.Text) <= 0)
            {
                f.ErrorWarning(errorProvider1, txtDienThoaiCT, "Sai định dạng số điện thoại");
                checkError = true;
            }
            else if (txtEmail.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtEmail, "Chưa nhập Email");
                    checkError = true;
            }
            else if (txtWebsite.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtWebsite, "Chưa nhập Website");
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
            txtMaCT.Text = "";
            txtTenCT.Text = "";
            txtDiaChiCT.Text = "";
            txtDienThoaiCT.Text = "";
            txtBank.Text = "";
            txtGhiChu.Text = "";
            txtEmail.Text = "";
            txtWebsite.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            clear_whitespace();
            checkError = false;
            CheckInputTxt();
            if (!checkError)
            {
                if (f.Select_TblCheck("MaCT","CongTy","MaCT",txtMaCT.Text))
                {
                    f.ErrorWarning(errorProvider1, txtMaCT, "Mã công ty đã tồn tại");
                    checkError = true;
                }
                else
                {
                    SqlParameter[] parameter = new SqlParameter[]
                    {
                        new SqlParameter("@1",txtMaCT.Text),
                        new SqlParameter("@2",txtTenCT.Text),
                        new SqlParameter("@3",txtDiaChiCT.Text),
                        new SqlParameter("@4",txtDienThoaiCT.Text),
                        new SqlParameter("@5",txtEmail.Text),
                        new SqlParameter("@6",txtWebsite.Text),
                        new SqlParameter("@7",txtBank.Text),
                        new SqlParameter("@8",txtGhiChu.Text)
                    };

                    f.InsertDataIntoTable("dbo.CongTy(MaCT,TenCT,DiaChiCT,DienThoaiCT,Email,Website,Bank,GhiChu)", parameter);
                    ResetTextBox();
                    dtgNCC.DataSource = f.ReadData("CongTy","1","1");
                }
            }
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
                    if (f.Select_TblCheck("MaCT", "CongTy", "MaCT", txtMaCT.Text) && txtMaCT.Text != dtgNCC.Rows[numrow].Cells[0].Value.ToString())
                    {
                        f.ErrorWarning(errorProvider1, txtMaCT, "Mã công ty đã tồn tại");
                        checkError = true;
                    }
                    else
                    {
                        string[] field = { "MaCT", "TenCT", "DiaChiCT", "DienThoaiCT", "Email", "Website", "Bank", "GhiChu" };
                        SqlParameter[] parameter = new SqlParameter[]
                     {
                        new SqlParameter("@1",txtMaCT.Text),
                        new SqlParameter("@2",txtTenCT.Text),
                        new SqlParameter("@3",txtDiaChiCT.Text),
                        new SqlParameter("@4",txtDienThoaiCT.Text),
                        new SqlParameter("@5",txtEmail.Text),
                        new SqlParameter("@6",txtWebsite.Text),
                        new SqlParameter("@7",txtBank.Text),
                        new SqlParameter("@8",txtGhiChu.Text)
                     };
                        string[] fieldCondition = { "MaCT" };
                        SqlParameter[] parameterCondition = new SqlParameter[]
                        {
                            new SqlParameter("@9",dtgNCC.Rows[numrow].Cells[0].Value.ToString())
                        };
                        f.UpdateDataTable("CongTy", field, parameter, fieldCondition,parameterCondition);
                        dtgNCC.DataSource = f.ReadData("CongTy", "1", "1");
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
            pnNCC.Visible = false;
            btnThemNCC.Enabled = true;
            btnSuaNCC.Enabled = true;
            btnXoaNCC.Enabled = true;
            btnTimKiemNCC.Enabled = true;
            ResetTextBox();
        }
        public void clear_whitespace()
        {
            TextBox[] txt = {txtMaCT, txtTenCT, txtDiaChiCT, txtDienThoaiCT, txtBank, txtGhiChu, txtEmail, txtWebsite};
            f.clear_whitespace(txt);
        }

        private void FormNCC_Load(object sender, EventArgs e)
        {
            btnThemNCC.Enabled = true;
            btnSuaNCC.Enabled = true;
            btnXoaNCC.Enabled = true;
            btnTimKiemNCC.Enabled = true;
            pnNCC.Visible = false;
            dtgNCC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgNCC.DataSource = f.ReadData("CongTy", "1", "1");
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = true;
            pnNCC.Visible = true;
            btnThemNCC.Enabled = false;
            pnNCC.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.Visible = true;
            btnLuu.Visible = false; 
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (checkClickdtg)
            {
                string[] fieldCondition = { "MaCT" };
                SqlParameter[] parameterCondition = new SqlParameter[]
                {
                    new SqlParameter("@1",dtgNCC.Rows[numrow].Cells[0].Value.ToString())
                };
                f.DeleteDataTable("CongTy", fieldCondition, parameterCondition);
                dtgNCC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtgNCC.DataSource = f.ReadData("CongTy", "1", "1");
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng để xoá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            checkClickdtg = false;
        }

        private void btnTimKiemNCC_Click(object sender, EventArgs e)
        {
            btnThemNCC.Enabled = false;
            pnInputSearch.Visible = true;
        }
        int numrow;
        bool checkClickdtg = false;
        int column;
        private void dtgNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            column = e.ColumnIndex;
            if (CheckClickBtnSua && numrow >= 0)
            {
                txtMaCT.Text = dtgNCC.Rows[numrow].Cells[0].Value.ToString();
                txtTenCT.Text = dtgNCC.Rows[numrow].Cells[1].Value.ToString();
                txtDiaChiCT.Text = dtgNCC.Rows[numrow].Cells[2].Value.ToString();
                txtDienThoaiCT.Text = dtgNCC.Rows[numrow].Cells[3].Value.ToString();
                txtEmail.Text = dtgNCC.Rows[numrow].Cells[4].Value.ToString();
                txtWebsite.Text = dtgNCC.Rows[numrow].Cells[5].Value.ToString();
                txtBank.Text = dtgNCC.Rows[numrow].Cells[6].Value.ToString();
                txtGhiChu.Text = dtgNCC.Rows[numrow].Cells[7].Value.ToString();
            }
            checkClickdtg = true;
            if (column == 5)
            {
                System.Diagnostics.Process.Start(dtgNCC.Rows[numrow].Cells[5].Value.ToString());
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
            string[] fieldCondition = { "MaCT", "TenCT", "DiaChiCT", "DienThoaiCT", "Email", "Website", "Bank", "GhiChu" };
            SqlParameter[] parameterCondition = new SqlParameter[]
           {
                new SqlParameter("@1","%" + txtTimKiem.Text + "%")
           };
            dtgNCC.DataSource = f.SelectCondition("CongTy", fieldCondition, parameterCondition);
        }

        private void lblTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Focus();
        }
        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            lblTimKiem.Visible = false;
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
            FormNCC_Load(sender, e);
        }
    }
}