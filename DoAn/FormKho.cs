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

namespace DoAn
{
    public partial class FormKho : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\QuanLyMayTinh\DoAn\DatabaseQuanLy.mdf;Integrated Security=True");
        bool CheckClickBtnSua = false;
        public FormKho()
        {
            InitializeComponent();
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            btnThemKho.Enabled = true;
            btnSuaKho.Enabled = true;
            btnXoaKho.Enabled = true;
            btnTimKiemKho.Enabled = true;
            pnKho.Visible = false;
            dtgKho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            conn.Open();
            string QuerrySelect = "select *  from dbo.Kho";
            SqlCommand cmd = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgKho.DataSource = dt;
            conn.Close();
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = false;
            pnKho.Visible = true;
            pnKho.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnSuaKho.Enabled = false;
            btnTimKiemKho.Enabled = false;
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
            DateTime date = new DateTime(2023, 11, 22);
            if (txtMaMT.Text == "")
            {
                ErrorWarning(errorProvider1, txtMaMT, "Chưa nhập mã máy tính");
            }
            else if (txtMaCT.Text == "")
            {
                ErrorWarning(errorProvider1, txtMaCT, "Chưa nhập mã công ty");
            }
            else if (txtSLT.Text == "")
            {
                ErrorWarning(errorProvider1, txtSLT, "Chưa nhập số lượng tồn");
            }
            else if (int.TryParse(txtSLT.Text, out songuyen) == false || int.Parse(txtSLT.Text) <= 0)
            {
                ErrorWarning(errorProvider1, txtSLT, "Nhập sai định dạng số lượng tồn");
            }
            else if (dtpNgayNhap.Value == date)
            {
                errorProvider1.SetError(dtpNgayNhap, "Chưa nhập ngày nhập");
                checkError = true;
            }
        }
        public void ResetTextBox()
        {
            txtMaMT.Text = "";
            txtMaCT.Text = "";
            dtpNgayNhap.Value = new DateTime(2023, 11, 22);
            txtSLT.Text = "0";
        }

        private void btnSuaKho_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = true;
            pnKho.Visible = true;
            pnKho.BackColor = Color.FromArgb(255, 255, 128);
            btnThemKho.Enabled = false;
            btnSua.Visible = true;
            btnLuu.Visible = false;
        }
        public void clear_whitespace()
        {
            txtMaMT.Text = txtMaMT.Text.Trim();
            txtMaCT.Text = txtMaCT.Text.Trim();
            txtSLT.Text = txtSLT.Text.Trim();
            Regex trimmer = new Regex(@"\s\s+"); // Xoá khoảng trắng thừa trong chuỗi 
            txtMaMT.Text = trimmer.Replace(txtMaMT.Text, " ");
            txtMaCT.Text = trimmer.Replace(txtMaCT.Text, " ");
            txtSLT.Text = trimmer.Replace(txtSLT.Text, " ");

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
                    conn.Open();
                    string QuerryCheckMaMTMT = "select MaMT from dbo.MayTinh where MaMT = '" + txtMaMT.Text + "'";
                    SqlCommand cmd = new SqlCommand(QuerryCheckMaMTMT, conn);
                    SqlDataReader dta1 = cmd.ExecuteReader();
                    if (!dta1.Read())
                    {
                        ErrorWarning(errorProvider1, txtMaMT, "Mã máy tính không tồn tại");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        string QuerrySelectTenMT = "select TenMT from dbo.MayTinh where MaMT = '" + txtMaMT.Text + "'";
                        SqlCommand cmd2 = new SqlCommand(QuerrySelectTenMT, conn);
                        object GetTenMT = cmd2.ExecuteScalar();
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd4 = new SqlCommand("select MaCT from dbo.CongTy where MaCT ='" + txtMaCT.Text + "'", conn);
                        SqlDataReader dta2 = cmd4.ExecuteReader();
                        if (!dta2.Read())
                        {
                            errorProvider1.SetError(txtMaCT, "Mã công ty không tồn tại");
                            conn.Close();
                        }
                        else
                        {
                            conn.Close();
                            conn.Open();
                            string QuerrySelectTenCT = "select TenCT from dbo.CongTy where MaCT = '" + txtMaCT.Text + "'";
                            SqlCommand cmd3 = new SqlCommand(QuerrySelectTenCT, conn);
                            object GetTenCT = cmd3.ExecuteScalar();
                            conn.Close();
                            conn.Open();
                            string QuerrySelectDonGia = "select DonGia from dbo.MayTinh where MaMT = '" + txtMaMT.Text + "'";
                            SqlCommand cmd5 = new SqlCommand(QuerrySelectDonGia, conn);
                            object GetDonGia = cmd5.ExecuteScalar();
                            conn.Close();
                            double DonGiaNhap = Convert.ToDouble(GetDonGia);
                            double DonGiaBan = DonGiaNhap * 1.1;
                            string TenMT = Convert.ToString(GetTenMT);
                            string TenCT = Convert.ToString(GetTenCT);
                            
                            String QuerryUpdate = " Update dbo.Kho set MaMT = '" + txtMaMT.Text + "',TenMT =N'" + TenMT + "',MaCT ='" + txtMaCT.Text + "',TenCT=N'" + TenCT + "'," +
                                "SoLuongTon = " + int.Parse(txtSLT.Text) + ", NgayNhap = '" + dtpNgayNhap.Value.ToShortDateString() + "',DonGiaNhap=" + DonGiaNhap + ",DonGiaBan= " + DonGiaBan + " where " +
                                "MaMT = '" + dtgKho.Rows[numrow].Cells[0].Value.ToString() + "'" +
                                "and MaCT = '" + dtgKho.Rows[numrow].Cells[3].Value.ToString() + "'" +
                                "and SoLuongTon= " + int.Parse(dtgKho.Rows[numrow].Cells[2].Value.ToString()) + "" +
                                "and NgayNhap ='" + dtgKho.Rows[numrow].Cells[5].Value.ToString() + "'";
                            conn.Open();
                              SqlCommand cmd6 = new SqlCommand(QuerryUpdate, conn);
                            cmd6.ExecuteNonQuery();
                            conn.Close();
                            string QuerrySelect = "select *  from dbo.Kho";
                            SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd1);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dtgKho.DataSource = dt;
                            conn.Close();
                        }
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
            pnKho.Visible = false;
            btnThemKho.Enabled = true;
            btnSuaKho.Enabled = true;
            btnXoaKho.Enabled = true;
            btnTimKiemKho.Enabled = true;
            ResetTextBox();
        }
        int numrow;
        bool checkClickdtg = false;

        private void dtgKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            if (CheckClickBtnSua && numrow >= 0)
            {
                string date = dtgKho.Rows[numrow].Cells[5].Value.ToString();
                string[] Split = date.Split('/');
                dtpNgayNhap.Value = new DateTime(int.Parse(Split[2]), int.Parse(Split[1]), int.Parse(Split[0]));
                txtMaMT.Text = dtgKho.Rows[numrow].Cells[0].Value.ToString();
                txtMaCT.Text = dtgKho.Rows[numrow].Cells[3].Value.ToString();
                txtSLT.Text = dtgKho.Rows[numrow].Cells[2].Value.ToString();
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
                string QuerryCheckMaMT = "select MaMT from dbo.MayTinh where MaMT = '" + txtMaMT.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerryCheckMaMT, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (!dta.Read())
                {
                    ErrorWarning(errorProvider1, txtMaMT, "Mã máy tính không tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string QuerrySelectTenMT = "select TenMT from dbo.MayTinh where MaMT = '" + txtMaMT.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelectTenMT, conn);
                    object GetTenMT = cmd2.ExecuteScalar();
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd4 = new SqlCommand("select MaCT from dbo.CongTy where MaCT ='" + txtMaCT.Text + "'", conn);
                    SqlDataReader dta2 = cmd4.ExecuteReader();
                    if (!dta2.Read())
                    {
                        errorProvider1.SetError(txtMaCT, "Mã công ty không tồn tại");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        string QuerrySelectTenCT = "select TenCT from dbo.CongTy where MaCT = '" + txtMaCT.Text + "'";
                        SqlCommand cmd3 = new SqlCommand(QuerrySelectTenCT, conn);
                        object GetTenCT = cmd3.ExecuteScalar();
                        conn.Close();
                        conn.Open();
                        string QuerrySelectDonGia = "select DonGia from dbo.MayTinh where MaMT = '" + txtMaMT.Text + "'";
                        SqlCommand cmd5 = new SqlCommand(QuerrySelectDonGia, conn);
                        object GetDonGia = cmd5.ExecuteScalar();
                        conn.Close();
                        double DonGiaNhap = Convert.ToDouble(GetDonGia);
                        double DonGiaBan = DonGiaNhap * 1.1;
                        string TenMT = Convert.ToString(GetTenMT);
                        string TenCT = Convert.ToString(GetTenCT);
                        conn.Open();
                        String QuerryInsert = " insert into dbo.Kho(MaMT,TenMT,MaCT,TenCT,SoLuongTon,NgayNhap,DonGiaNhap,DonGiaBan) values ('" + txtMaMT.Text + "',N'" + TenMT + "','" + txtMaCT.Text + "'," +
                            "N'" + TenCT + "'," + int.Parse(txtSLT.Text) + ",'" + dtpNgayNhap.Value.ToShortDateString() + "',"+DonGiaNhap+","+DonGiaBan+")";
                        SqlCommand cmd1 = new SqlCommand(QuerryInsert, conn);
                        cmd1.ExecuteNonQuery();
                        conn.Close();
                        ResetTextBox();
                        conn.Open();
                        string QuerrySelect = "select *  from dbo.Kho";
                        SqlCommand cmd6 = new SqlCommand(QuerrySelect, conn);
                        SqlDataAdapter da = new SqlDataAdapter(cmd6);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtgKho.DataSource = dt;
                        conn.Close();
                    }
                }
            }
        }

        private void btnXoaKho_Click(object sender, EventArgs e)
        {
            if (checkClickdtg)
            {
                string QuerryDelete = "delete from  dbo.Kho where " +
                            "MaMT = '"+ dtgKho.Rows[numrow].Cells[0].Value.ToString()+"'" +
                            "and MaCT = '"+ dtgKho.Rows[numrow].Cells[3].Value.ToString()+"'" +
                            "and SoLuongTon= " + int.Parse(dtgKho.Rows[numrow].Cells[2].Value.ToString()) +
                            "and NgayNhap ='" + dtgKho.Rows[numrow].Cells[5].Value.ToString() + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(QuerryDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                dtgKho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                conn.Open();
                string QuerrySelect = "select *  from dbo.Kho";
                SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgKho.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng để xoá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            checkClickdtg = false;
        }

        private void btnTimKiemKho_Click(object sender, EventArgs e)
        {
            pnInputSearch.Visible = true;
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
            string QuerrySelect = "select *  from dbo.Kho where MaMT LIKE '%" + txtTimKiem.Text + "%'" +
              "or TenMT LIKE N'%" + txtTimKiem.Text + "%'" +
              "or MaCT LIKE N'%" + txtTimKiem.Text + "%'" +
              "or TenCT LIKE N'%" + txtTimKiem.Text + "%'" +
              "or SoLuongTon LIKE N'%" + txtTimKiem.Text + "%'" +
              "or NgayNhap LIKE N'%" + txtTimKiem.Text + "%'";
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgKho.DataSource = dt;
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

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            lblTimKiem.Visible = false;
        }

        private void btnXTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            pnInputSearch.Visible = false;
            FormKho_Load(sender, e);
        }

        private void pnKho_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
