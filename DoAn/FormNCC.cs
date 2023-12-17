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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\QuanLyMayTinh\DoAn\DatabaseQuanLy.mdf;Integrated Security=True");
        bool CheckClickBtnSua = false;
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
        public void ErrorWarning(ErrorProvider error, TextBox txt, string message)
        {
            error.SetError(txt, message);
            txt.Focus();
            checkError = true;
            conn.Close();
        }
        public void CheckInputTxt()
        {
            int songuyen = 0;

            if (txtMaCT.Text == "")
            {
                ErrorWarning(errorProvider1, txtMaCT, "Chưa nhập mã công ty");
            }
            else if (txtTenCT.Text == "")
            {
                ErrorWarning(errorProvider1, txtTenCT, "Chưa nhập tên công ty");
            }
            else if (txtDiaChiCT.Text == "")
            {
                ErrorWarning(errorProvider1, txtDiaChiCT, "Chưa nhập địa chỉ");
            }
            else if (txtDienThoaiCT.Text == "")
            {
                ErrorWarning(errorProvider1, txtDienThoaiCT, "Chưa nhập số điện thoại");
            }
            else if (int.TryParse(txtDienThoaiCT.Text, out songuyen) == false || int.Parse(txtDienThoaiCT.Text) <= 0)
            {
                ErrorWarning(errorProvider1, txtDienThoaiCT, "Sai định dạng số điện thoại");
            }
            else if (txtEmail.Text == "")
            {
                ErrorWarning(errorProvider1, txtEmail, "Chưa nhập Email");
            }
            else if (txtWebsite.Text == "")
            {
                ErrorWarning(errorProvider1, txtWebsite, "Chưa nhập Website");
            }
            else if (txtBank.Text == "")
            {
                ErrorWarning(errorProvider1, txtBank, "Chưa nhập bảo hành");
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
                conn.Open();
                string QuerryCheckMa = "select MaCT from dbo.CongTy where MaCT = '" + txtMaCT.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerryCheckMa, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    ErrorWarning(errorProvider1, txtMaCT, "Mã công ty đã tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string QuerryInsert = "insert into dbo.CongTy(MaCT,TenCT,DiaChiCT,DienThoaiCT,Email,Website,Bank,GhiChu)" +
                        "values ('" + txtMaCT.Text + "',N'" + txtTenCT.Text + "',N'" + txtDiaChiCT.Text + "','" + 
                        txtDienThoaiCT.Text + "',N'"+txtEmail.Text+"',N'"+txtWebsite.Text+"',N'" + txtBank.Text + "',N'" + txtGhiChu.Text + "')";
                    SqlCommand cmd1 = new SqlCommand(QuerryInsert, conn);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    conn.Open();
                    string QuerrySelect = "select *  from dbo.CongTy";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelect, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgNCC.DataSource = dt;
                    conn.Close();
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
                conn.Open();
                string QuerryCheckMa = "select MaCT from dbo.CongTy where MaCT = '" + txtMaCT.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerryCheckMa, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true && txtMaCT.Text != dtgNCC.Rows[numrow].Cells[0].Value.ToString())
                {
                    ErrorWarning(errorProvider1, txtMaCT, "Mã công ty đã tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string QuerryUpdate = " Update dbo.CongTy set MaCT = '" + txtMaCT.Text + "',TenCT = N'" + txtTenCT.Text + "',DiaChiCT =N'" + txtDiaChiCT.Text + "',DienThoaiCT = N'" + txtDienThoaiCT.Text + "'," +
                        "Email=N'" + txtEmail.Text + "',Website = N'" + txtWebsite.Text + "',Bank=N'" + txtBank.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaCT = '" + dtgNCC.Rows[numrow].Cells[0].Value.ToString() + "'";
                    SqlCommand cmd1 = new SqlCommand(QuerryUpdate, conn);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    conn.Open();
                    string QuerrySelect = "select *  from dbo.CongTy";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelect, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgNCC.DataSource = dt;
                    conn.Close();
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
            txtMaCT.Text = txtMaCT.Text.Trim();
            txtTenCT.Text = txtTenCT.Text.Trim();
            txtDiaChiCT.Text = txtDiaChiCT.Text.Trim();
            txtDienThoaiCT.Text = txtDienThoaiCT.Text.Trim();
            txtBank.Text = txtBank.Text.Trim();
            txtGhiChu.Text = txtGhiChu.Text.Trim();
            txtEmail.Text = txtEmail.Text.Trim();
            txtWebsite.Text = txtWebsite.Text.Trim();
            Regex trimmer = new Regex(@"\s\s+"); // Xoá khoảng trắng thừa trong chuỗi 
            txtMaCT.Text = trimmer.Replace(txtMaCT.Text, " ");
            txtTenCT.Text = trimmer.Replace(txtTenCT.Text, " ");
            txtDiaChiCT.Text = trimmer.Replace(txtDiaChiCT.Text, " ");
            txtDienThoaiCT.Text = trimmer.Replace(txtDienThoaiCT.Text, " ");
            txtBank.Text = trimmer.Replace(txtBank.Text, " ");
            txtGhiChu.Text = trimmer.Replace(txtGhiChu.Text, " ");
            txtEmail.Text = trimmer.Replace(txtEmail.Text, " ");
            txtWebsite.Text = trimmer.Replace(txtWebsite.Text, " ");
        }

        private void FormNCC_Load(object sender, EventArgs e)
        {
            btnThemNCC.Enabled = true;
            btnSuaNCC.Enabled = true;
            btnXoaNCC.Enabled = true;
            btnTimKiemNCC.Enabled = true;
            pnNCC.Visible = false;
            dtgNCC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            conn.Open();
            string QuerrySelect = "select *  from dbo.CongTy";
            SqlCommand cmd = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgNCC.DataSource = dt;
            conn.Close();
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
                string QuerryDelete = "delete from  dbo.CongTy where MaCT = '" + dtgNCC.Rows[numrow].Cells[0].Value.ToString() + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(QuerryDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dtgNCC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                string QuerrySelect = "select *  from dbo.CongTy";
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgNCC.DataSource = dt;
                conn.Close();
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
            string QuerrySelect = "select *  from dbo.CongTy where MaCT LIKE N'%" + txtTimKiem.Text + "%'" +
              "or TenCT LIKE N'%" + txtTimKiem.Text + "%'" +
              "or DiaChiCT LIKE N'%" + txtTimKiem.Text + "%'" +
              "or DienThoaiCT LIKE N'%" + txtTimKiem.Text + "%'" +
              "or Email LIKE N'%" + txtTimKiem.Text + "%'" +
              "or Website LIKE N'%" + txtTimKiem.Text + "%'" +
              "or Bank LIKE N'%" + txtTimKiem.Text + "%'" +
              "or GhiChu LIKE N'%" + txtTimKiem.Text + "%'";
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgNCC.DataSource = dt;
            conn.Close();
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

        private void txtWebsite_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}