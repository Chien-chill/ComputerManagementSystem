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
    public partial class FormKhachHang : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\QuanLyMayTinh\DoAn\DatabaseQuanLy.mdf;Integrated Security=True");
        bool CheckClickBtnSua = false;
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void radHaiLong_CheckedChanged(object sender, EventArgs e)
        {

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
        public void ErrorWarning(ErrorProvider error, TextBox txt, string message)
        {
            error.SetError(txt, message);
            txt.Focus();
            checkError = true;
            conn.Close();
        }
       public void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
        }
        public void CheckInputTxt()
        {
            int songuyen = 0;
            DateTime date = new DateTime(2023, 11, 22);
            if (txtMaKH.Text == "")
            {
                ErrorWarning(errorProvider1, txtMaKH, "Chưa nhập mã khách hàng");
            }
            else if (txtTenKH.Text == "")
            {
                ErrorWarning(errorProvider1, txtTenKH, "Chưa nhập tên khách hàng");
            }
            else if (txtCCCD.Text == "")
            {
                ErrorWarning(errorProvider1, txtCCCD, "Chưa nhập số căn cước");
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
                ErrorWarning(errorProvider1, txtDiaChi, "Chưa nhập địa chỉ");
            }
            else if (txtDienThoai.Text == "")
            {
                ErrorWarning(errorProvider1, txtDienThoai, "Chưa nhập số điện thoại");
            }
            else if (int.TryParse(txtDienThoai.Text, out songuyen) == false || int.Parse(txtDienThoai.Text) <= 0)
            {
                ErrorWarning(errorProvider1, txtDienThoai, "Sai định dạng số điện thoại");
            }
            else if (txtBank.Text == "")
            {
                ErrorWarning(errorProvider1, txtBank, "Chưa nhập bảo hành");
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
                conn.Open();
                string QuerryCheckMa = "select MaKH from dbo.KhachHang where MaKH = '" + txtMaKH.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerryCheckMa, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true && txtMaKH.Text != dtgKH.Rows[numrow].Cells[0].Value.ToString())
                {
                    ErrorWarning(errorProvider1, txtMaKH, "Mã khách hàng đã tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
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
                    conn.Open();
                    string QuerryUpdate = " Update dbo.KhachHang set MaKH = '" + txtMaKH.Text + "',TenKH = N'" + txtTenKH.Text + "',CCCD ='" + txtCCCD.Text + "',GioiTinhKH =N'" + GioiTinh + "',NgaySinhKH ='" + dtpNgaySinh.Value.ToShortDateString() + "',DiaChiKH =N'" + txtDiaChi.Text + "',DienThoaiKH = N'" + txtDienThoai.Text + "'," +
                        "FeedBack = N'" + FeedBack + "',Bank=N'" + txtBank.Text + "',GhiChu=N'" + txtGhiChu.Text + "' where MaKH = N'" + dtgKH.Rows[numrow].Cells[0].Value.ToString() + "'";
                    SqlCommand cmd1 = new SqlCommand(QuerryUpdate, conn);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    conn.Open();
                    string QuerrySelect = "select *  from dbo.KhachHang";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelect, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgKH.DataSource = dt;
                    conn.Close();
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
            txtMaKH.Text = txtMaKH.Text.Trim();
            txtTenKH.Text = txtTenKH.Text.Trim();
            txtDiaChi.Text = txtDiaChi.Text.Trim();
            txtDienThoai.Text = txtDienThoai.Text.Trim();
            txtBank.Text = txtBank.Text.Trim();
            txtGhiChu.Text = txtGhiChu.Text.Trim();
            txtCCCD.Text = txtCCCD.Text.Trim();
            Regex trimmer = new Regex(@"\s\s+"); // Xoá khoảng trắng thừa trong chuỗi 
            txtMaKH.Text = trimmer.Replace(txtMaKH.Text, " ");
            txtTenKH.Text = trimmer.Replace(txtTenKH.Text, " ");
            txtDiaChi.Text = trimmer.Replace(txtDiaChi.Text, " ");
            txtDienThoai.Text = trimmer.Replace(txtDienThoai.Text, " ");
            txtBank.Text = trimmer.Replace(txtBank.Text, " ");
            txtGhiChu.Text = trimmer.Replace(txtGhiChu.Text, " ");
            txtCCCD.Text = trimmer.Replace(txtCCCD.Text, " ");
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            btnThemKH.Enabled = true;
            btnSuaKH.Enabled = true;
            btnXoaKH.Enabled = true;
            btnTimKiemKH.Enabled = true;
            pnKH.Visible = false;
            dtgKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            conn.Open();
            string QuerrySelect = "select *  from dbo.KhachHang";
            SqlCommand cmd = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgKH.DataSource = dt;
            conn.Close();
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
                string QuerryDelete = "delete from  dbo.KhachHang where MaKH = '" + dtgKH.Rows[numrow].Cells[0].Value.ToString() + "'"; 
                conn.Open();
                SqlCommand cmd = new SqlCommand(QuerryDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dtgKH.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                conn.Open();
                string QuerrySelect = "select *  from dbo.KhachHang";
                SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgKH.DataSource = dt;
                conn.Close();
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
                conn.Open();
                string QuerryCheckMa = "select MaKH from dbo.KhachHang where MaKH = '" + txtMaKH.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerryCheckMa, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    ErrorWarning(errorProvider1, txtMaKH, "Mã khách hàng đã tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
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
                    conn.Open();
                    string QuerryInsert = "insert into dbo.KhachHang(MaKH,TenKH,CCCD,NgaySinhKH,GioiTinhKH,DiaChiKH,DienThoaiKH,FeedBack,Bank,GhiChu)" +
                        "values ('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'"+txtCCCD.Text+"','"+dtpNgaySinh.Value.ToShortDateString() +"',N'"+ GioiTinh+"',N'" + txtDiaChi.Text + "','" +
                        txtDienThoai.Text + "',N'" + FeedBack + "',N'" + txtBank.Text + "',N'" + txtGhiChu.Text + "')";
                    SqlCommand cmd1 = new SqlCommand(QuerryInsert, conn);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    conn.Open();
                    string QuerrySelect = "select *  from dbo.KhachHang";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelect, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgKH.DataSource = dt;
                    conn.Close();
                }
            }
        }
        private void dtgKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            string QuerrySelect = "select *  from dbo.KhachHang where MaKH LIKE '%" + txtTimKiem.Text + "%'" +
              "or TenKH LIKE N'%" + txtTimKiem.Text + "%'" +
              "or DiaChiKH LIKE N'%" + txtTimKiem.Text + "%'" +
              "or DienThoaiKH LIKE N'%" + txtTimKiem.Text + "%'" +
              "or GioiTinhKH LIKE N'%" + txtTimKiem.Text + "%'" +
              "or NgaySinhKH LIKE N'%" + txtTimKiem.Text + "%'" +
              "or Bank LIKE N'%" + txtTimKiem.Text + "%'" +
              "or FeedBack LIKE N'%" + txtTimKiem.Text + "%'" +
              "or CCCD LIKE N'%" + txtTimKiem.Text + "%'" +
              "or GhiChu LIKE N'%" + txtTimKiem.Text + "%'";
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgKH.DataSource = dt;
            conn.Close();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
