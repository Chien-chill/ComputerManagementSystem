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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\QuanLyMayTinh\DoAn\DatabaseQuanLy.mdf;Integrated Security=True");
        bool CheckClickBtnSua = false;
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
            conn.Open();
            string QuerrySelect = "select *  from dbo.NhanVien";
            SqlCommand cmd = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgNV.DataSource = dt;
            conn.Close();
            conn.Open();
            string QuerrySelect1 = "select *  from dbo.TaiKhoan";
            SqlCommand cmd1 = new SqlCommand(QuerrySelect1, conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dtgTK.DataSource = dt1;
            conn.Close();
            btnInsert.Visible = true;
            btnSave.Visible = false;
            btnDelete.Visible = false;
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
            DateTime date = new DateTime(2023, 11, 25);
            if (txtMaNV.Text == "")
            {
                ErrorWarning(errorProvider1, txtMaNV, "Chưa nhập mã nhân viên");
            }
            else if (txtTenNV.Text == "")
            {
                ErrorWarning(errorProvider1, txtTenNV, "Chưa nhập tên nhân viên");
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
            else if (txtChucVu.Text == "")
            {
                errorProvider1.SetError(txtChucVu, "Chưa chọn chức vụ");
                checkError = true;
            }
            else if (txtLuong.Text == "")
            {
                ErrorWarning(errorProvider1, txtLuong, "Chưa nhập lương");
            }
            else if (int.TryParse(txtLuong.Text, out songuyen) == false || int.Parse(txtLuong.Text) <= 0)
            {
                ErrorWarning(errorProvider1, txtLuong, "Sai định dạng lương");
            }
            else if (txtBank.Text == "")
            {
                ErrorWarning(errorProvider1, txtBank, "Chưa nhập bảo hành");
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
            txtMaNV.Text = txtMaNV.Text.Trim();
            txtTenNV.Text = txtTenNV.Text.Trim();
            txtDiaChi.Text = txtDiaChi.Text.Trim();
            txtDienThoai.Text = txtDienThoai.Text.Trim();
            txtBank.Text = txtBank.Text.Trim();
            txtGhiChu.Text = txtGhiChu.Text.Trim();
            txtCCCD.Text = txtCCCD.Text.Trim();
            txtLuong.Text = txtLuong.Text.Trim();
            txtChucVu.Text = txtChucVu.Text.Trim();
            Regex trimmer = new Regex(@"\s\s+"); // Xoá khoảng trắng thừa trong chuỗi 
            txtMaNV.Text = trimmer.Replace(txtMaNV.Text, " ");
            txtTenNV.Text = trimmer.Replace(txtTenNV.Text, " ");
            txtDiaChi.Text = trimmer.Replace(txtDiaChi.Text, " ");
            txtDienThoai.Text = trimmer.Replace(txtDienThoai.Text, " ");
            txtBank.Text = trimmer.Replace(txtBank.Text, " ");
            txtGhiChu.Text = trimmer.Replace(txtGhiChu.Text, " ");
            txtCCCD.Text = trimmer.Replace(txtCCCD.Text, " ");
            txtLuong.Text = trimmer.Replace(txtLuong.Text, " ");
            txtChucVu.Text = trimmer.Replace(txtChucVu.Text, " ");
        }
        int numrow;
        bool checkClickdtg = false;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
        }
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
                ErrorWarning(errorProvider1, txtTaiKhoan, "Chưa nhập mã nhân viên");
            }
            else if (txtMatKhau.Text == "")
            {
                ErrorWarning(errorProvider1, txtMatKhau, "Chưa nhập mật khẩu");
            }
            else
            {
                conn.Open();
                string QuerryCheckMa = "select MaNV from dbo.NhanVien where MaNV = '" + txtTaiKhoan.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerryCheckMa, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (!dta.Read())
                {
                    ErrorWarning(errorProvider1, txtTaiKhoan, "Mã nhân viên không tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string QuerryCheckMa1 = "select MaNV from dbo.TaiKhoan where MaNV = '" + txtTaiKhoan.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(QuerryCheckMa1, conn);
                    SqlDataReader dta1 = cmd1.ExecuteReader();
                    if (dta1.Read())
                    {
                        ErrorWarning(errorProvider1, txtTaiKhoan, "Tài khoản đã tồn tại");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        string QuerryInsert = "insert into dbo.TaiKhoan(MaNV,MatKhau) values ('" + txtTaiKhoan.Text + "','" + txtMatKhau.Text + "')";
                        SqlCommand cmd2 = new SqlCommand(QuerryInsert, conn);
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        ClearTextBox();
                        conn.Open();
                        string QuerrySelect1 = "select *  from dbo.TaiKhoan";
                        SqlCommand cmd3 = new SqlCommand(QuerrySelect1, conn);
                        SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        dtgTK.DataSource = dt1;
                        conn.Close();
                    }    
                }
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtTaiKhoan.Text == "")
            {
                ErrorWarning(errorProvider1, txtTaiKhoan, "Chưa nhập mã nhân viên");
            }
            else if (txtMatKhau.Text == "")
            {
                ErrorWarning(errorProvider1, txtMatKhau, "Chưa nhập mật khẩu");
            }
            else
            {
                conn.Open();
                string QuerryCheckMa = "select MaNV from dbo.NhanVien where MaNV = '" + txtTaiKhoan.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerryCheckMa, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (!dta.Read())
                {
                    ErrorWarning(errorProvider1, txtTaiKhoan, "Mã nhân viên không tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string QuerryCheckMa1 = "select MaNV from dbo.TaiKhoan where MaNV = '" + txtTaiKhoan.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(QuerryCheckMa1, conn);
                    SqlDataReader dta1 = cmd1.ExecuteReader();
                    if (dta1.Read() && txtTaiKhoan.Text != dtgTK.Rows[numrow1].Cells[0].Value.ToString())
                    {
                        ErrorWarning(errorProvider1, txtTaiKhoan, "Tài khoản đã tồn tại");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        string QuerryUpdate = "update dbo.TaiKhoan set MaNV = '" + txtTaiKhoan.Text + "',MatKhau = '" + txtMatKhau.Text + "' where " +
                            "MaNV = '" + dtgTK.Rows[numrow1].Cells[0].Value.ToString() + "'";
                        SqlCommand cmd2 = new SqlCommand(QuerryUpdate, conn);
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        ClearTextBox();
                        conn.Open();
                        string QuerrySelect1 = "select *  from dbo.TaiKhoan";
                        SqlCommand cmd3 = new SqlCommand(QuerrySelect1, conn);
                        SqlDataAdapter da1 = new SqlDataAdapter(cmd3);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        dtgTK.DataSource = dt1;
                        conn.Close();
                        showbtn();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string QuerryDelete = "delete from  dbo.TaiKhoan where MaNV = '" + dtgTK.Rows[numrow1].Cells[0].Value.ToString() + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(QuerryDelete, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            dtgTK.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            conn.Open();
            string QuerrySelect = "select *  from dbo.TaiKhoan";
            SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgTK.DataSource = dt;
            conn.Close();
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

        private void dtgNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                conn.Open();
                string QuerryCheckMa = "select MaNV from dbo.NhanVien where MaNV = '" + txtMaNV.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerryCheckMa, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true && txtMaNV.Text != dtgNV.Rows[numrow].Cells[0].Value.ToString())
                {
                    ErrorWarning(errorProvider1, txtMaNV, "Mã nhân viên đã tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    string GioiTinh = string.Empty;
                    if (radNam.Checked == true)
                    {
                        GioiTinh = "Nam";
                    }
                    else if (radNu.Checked == true)
                    {
                        GioiTinh = "Nữ";
                    }
                    conn.Open();
                    string QuerryUpdate = " Update dbo.NhanVien set MaNV = '" + txtMaNV.Text + "',TenNV = N'" + txtTenNV.Text + "',CCCD ='" + txtCCCD.Text + "',GioiTinhNV =N'" + GioiTinh + "',NgaySinhNV ='" + dtpNgaySinh.Value.ToShortDateString() + "',DiaChiNV =N'" + txtDiaChi.Text + "',DienThoaiNV = N'" + txtDienThoai.Text + "'," +
                        "Bank=N'" + txtBank.Text + "',GhiChu=N'" + txtGhiChu.Text + "',ChucVu=N'" + txtChucVu.Text + "',Luong =" + double.Parse(txtLuong.Text) + " where MaNV = N'" + dtgNV.Rows[numrow].Cells[0].Value.ToString() + "'";
                    SqlCommand cmd1 = new SqlCommand(QuerryUpdate, conn);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    conn.Open();
                    string QuerrySelect = "select *  from dbo.NhanVien";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelect, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgNV.DataSource = dt;
                    conn.Close();
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
                conn.Open();
                string QuerryCheckMa = "select MaNV from dbo.NhanVien where MaNV = '" + txtMaNV.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerryCheckMa, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    ErrorWarning(errorProvider1, txtMaNV, "Mã nhân viên đã tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    string GioiTinh = string.Empty;
                    if (radNam.Checked == true)
                    {
                        GioiTinh = "Nam";
                    }
                    else if (radNu.Checked == true)
                    {
                        GioiTinh = "Nữ";
                    }
                    conn.Open();
                    string QuerryInsert = "insert into dbo.NhanVien(MaNV,TenNV,CCCD,NgaySinhNV,GioiTinhNV,DiaChiNV,DienThoaiNV,ChucVu,Luong,Bank,GhiChu)" +
                        "values ('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'" + txtCCCD.Text + "','" + dtpNgaySinh.Value.ToShortDateString() + "',N'" + GioiTinh + "',N'" + txtDiaChi.Text + "','" +
                        txtDienThoai.Text + "',N'" + txtChucVu.Text + "'," + double.Parse(txtLuong.Text) + ",N'" + txtBank.Text + "',N'" + txtGhiChu.Text + "')";
                    SqlCommand cmd1 = new SqlCommand(QuerryInsert, conn);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    conn.Open();
                    string QuerrySelect = "select *  from dbo.NhanVien";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelect, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgNV.DataSource = dt;
                    conn.Close();
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
                string QuerryDelete = "delete from  dbo.NhanVien where MaNV = '" + dtgNV.Rows[numrow].Cells[0].Value.ToString() + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(QuerryDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dtgNV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                conn.Open();
                string QuerrySelect = "select *  from dbo.NhanVien";
                SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgNV.DataSource = dt;
                conn.Close();
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
    }
}
