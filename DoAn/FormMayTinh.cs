using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DoAn
{
    public partial class FormMayTinh : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\QuanLyMayTinh\DoAn\DatabaseQuanLy.mdf;Integrated Security=True");
        bool CheckClickBtnSua = false;
        public FormMayTinh()
        {

            InitializeComponent();
        }

        private void btnThemMT_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = false;
            pnMayTinh.Visible = true;
            pnMayTinh.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnSuaMT.Enabled = false;
        }
        bool checkError = false;
        public void ErrorWarning(ErrorProvider error ,TextBox txt, string  message)
        {
            error.SetError(txt, message);
            txt.Focus();
            checkError = true;
            conn.Close();
        }
        public void CheckInputTxt()
        {
            double sothuc = 0.0;
            int songuyen = 0;
            
            if (txtMaMayTinh.Text == "")    
            {
                ErrorWarning(errorProvider1, txtMaMayTinh, "Chưa nhập mã máy tính");
            }
            else if (txtTenMayTinh.Text == "")
            {
                ErrorWarning(errorProvider1, txtTenMayTinh, "Chưa nhập tên máy tính");
            }
            else if (txtTenHSX.Text == "")
            {
                ErrorWarning(errorProvider1, txtTenHSX, "Chưa nhập tên hãng sản xuất");
            }
            else if (cboLoaiHang.Text == "none")
            {
                errorProvider1.SetError(cboLoaiHang, "Chưa chọn loại hàng");
                checkError = true;
            }
            else if (txtNamRaMat.Text == "")
            {
                ErrorWarning(errorProvider1, txtNamRaMat, "Chưa nhập năm ra mắt");
            }
            else if (int.TryParse(txtNamRaMat.Text, out songuyen) == false || int.Parse(txtNamRaMat.Text) < 2005)
            {
                ErrorWarning(errorProvider1, txtNamRaMat, "Sai định dạng năm ra mắt");
            }
            else if (txtBaoHanh.Text == "")
            {
                ErrorWarning(errorProvider1, txtBaoHanh, "Chưa nhập bảo hành");
            }
            else if (int.TryParse(txtBaoHanh.Text, out songuyen) == false || int.Parse(txtBaoHanh.Text) < 0)
            {
                ErrorWarning(errorProvider1, txtBaoHanh, "Sai định dạng tháng bảo hành");
            }
            else if (txtCPU.Text == "")
            {
                ErrorWarning(errorProvider1, txtCPU, "Chưa nhập thông số CPU");
            }
            else if (cboRAM1.Text == "none" && cboRAM2.Text == "none")
            {
                errorProvider1.SetError(cboRAM1, "Chưa chọn thông số RAM");
                checkError = true;
            }
            else if (txtCard.Text == "")
            {
                ErrorWarning(errorProvider1, txtCard, "Chưa nhập thông số Card");
            }
            else if (txtManHinh.Text == "")
            {
                ErrorWarning(errorProvider1, txtManHinh, "Chưa nhập thông số màn hình");
            }
            else if (txtDungLuong.Text == "")
            {
                ErrorWarning(errorProvider1, txtDungLuong, "Chưa nhập dung lượng");
            }
            else if (txtTrongLuong.Text == "")
            {
                ErrorWarning(errorProvider1, txtTrongLuong, "Chưa nhập trọng lượng");
            }
            else if (double.TryParse(txtTrongLuong.Text, out sothuc) == false || double.Parse(txtTrongLuong.Text) < 0)
            {
                ErrorWarning(errorProvider1, txtTrongLuong, "Sai định dạng trọng lượng");
            }
            else if (cboTinhTrang.Text == "none")
            {
                errorProvider1.SetError(cboTinhTrang, "Chưa chọn tình trạng");
                checkError = true;
            }
            else if (txtDonGia.Text == "")
            {
                ErrorWarning(errorProvider1, txtDonGia, "Chưa nhập đơn giá");
            }
            else if (double.TryParse(txtDonGia.Text, out sothuc) == false || double.Parse(txtDonGia.Text) < 0)
            {
                ErrorWarning(errorProvider1, txtDonGia, "Sai định dạng đơn giá");
            }
        }
        public void ResetTextBox()
        {
            txtMaMayTinh.Text = "";
            txtTenMayTinh.Text = "";
            txtTenHSX.Text = "";
            cboLoaiHang.Text = "none";
            txtBaoHanh.Text = "";
            txtNamRaMat.Text = "";
            txtCPU.Text = "";
            cboRAM1.Text = "none";
            cboRAM2.Text = "none";
            txtManHinh.Text = "";
            txtDungLuong.Text = "";
            txtTrongLuong.Text = "";
            txtDonGia.Text = "";
            txtGhiChu.Text = "";
            cboTinhTrang.Text = "none";
            txtCard.Text = "";
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
                string QuerryCheckMa = "select MaMT from dbo.MayTinh where MaMT = '" + txtMaMayTinh.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerryCheckMa, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    ErrorWarning(errorProvider1, txtMaMayTinh, "Mã máy tính đã tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string QuerryInsert = "insert into dbo.MayTinh(MaMT,TenMT,TenHSX,LoaiHang,BaoHanh,NamRaMat,CPU,RAM1,RAM2,ManHinh,DungLuong,TrongLuong,DonGia,GhiChu,Card,TinhTrang)" +
                        "values ('" + txtMaMayTinh.Text + "',N'" + txtTenMayTinh.Text + "',N'" + txtTenHSX.Text + "',N'" + cboLoaiHang.Text + "'," + int.Parse(txtBaoHanh.Text) + "," + int.Parse(txtNamRaMat.Text)
                        + ",N'" + txtCPU.Text + "','" + cboRAM1.Text + "','" + cboRAM2.Text + "',N'" + txtManHinh.Text + "','" + txtDungLuong.Text + "'," + double.Parse(txtTrongLuong.Text) + "," + double.Parse(txtDonGia.Text) + ",N'" + txtGhiChu.Text + "',N'"+txtCard.Text+"',N'"+cboTinhTrang.Text+"')";
                    SqlCommand cmd1 = new SqlCommand(QuerryInsert, conn);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    ResetTextBox();
                    conn.Open();
                    string QuerrySelect = "select *  from dbo.MayTinh";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelect, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgMayTinh.DataSource = dt;
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
                if(checkClickdtg)
                {
                checkClickdtg = false;
                conn.Open();
                string QuerryCheckMa = "select MaMT from dbo.MayTinh where MaMT = '" + txtMaMayTinh.Text + "'";
                SqlCommand cmd = new SqlCommand(QuerryCheckMa, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true && txtMaMayTinh.Text != dtgMayTinh.Rows[numrow].Cells[0].Value.ToString())
                {
                    ErrorWarning(errorProvider1, txtMaMayTinh, "Mã máy tính đã tồn tại");
                    conn.Close();
                }
                else
                {
                conn.Close();
                conn.Open();
                string QuerryUpdate = " Update dbo.MayTinh set MaMT = N'" + txtMaMayTinh.Text + "',TenMT = N'" + txtTenMayTinh.Text + "',TenHSX = N'"+ txtTenHSX.Text +"',LoaiHang = N'"+cboLoaiHang.Text+"',BaoHanh = "+int.Parse(txtBaoHanh.Text)+",NamRaMat =" +
              int.Parse(txtNamRaMat.Text) + ",CPU = N'"+txtCPU.Text+"',RAM1 = '"+ cboRAM1.Text+"',RAM2 = '"+cboRAM2.Text+"', ManHinh = N'"+txtManHinh.Text+"',DungLuong = '" + txtDungLuong.Text +"',TrongLuong = "+ double.Parse(txtTrongLuong.Text)+",DonGia ="+
            double.Parse(txtDonGia.Text)+",GhiChu = N'" +txtGhiChu.Text+"',Card =N'"+txtCard.Text+"',TinhTrang = N'"+cboTinhTrang.Text+"' where  MaMT = N'" + dtgMayTinh.Rows[numrow].Cells[0].Value.ToString() + "'" ;
                SqlCommand cmd1 = new SqlCommand(QuerryUpdate, conn);
                cmd1.ExecuteNonQuery();
                conn.Close();
                    conn.Open();
                    string QuerrySelect = "select *  from dbo.MayTinh";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelect, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgMayTinh.DataSource = dt;
                    conn.Close();
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
            pnMayTinh.Visible = false;
            btnThemMT.Enabled = true;
            btnSuaMT.Enabled = true;
            btnXoaMT.Enabled = true;
            ResetTextBox();
            checkClickdtg = false;
        }
        public void clear_whitespace()
        {
            txtMaMayTinh.Text = txtMaMayTinh.Text.Trim();
            txtTenMayTinh.Text = txtTenMayTinh.Text.Trim();
            txtTenHSX.Text = txtTenHSX.Text.Trim();
            txtNamRaMat.Text = txtNamRaMat.Text.Trim();
            txtBaoHanh.Text = txtBaoHanh.Text.Trim();
            txtCard.Text = txtCard.Text.Trim();
            txtCPU.Text = txtCPU.Text.Trim();
            txtManHinh.Text = txtManHinh.Text.Trim();
            txtDungLuong.Text = txtDungLuong.Text.Trim();
            txtTrongLuong.Text = txtTrongLuong.Text.Trim();
            txtDonGia.Text = txtDonGia.Text.Trim();
            txtGhiChu.Text = txtGhiChu.Text.Trim();
            Regex trimmer = new Regex(@"\s\s+"); // Xoá khoảng trắng thừa trong chuỗi 
            txtMaMayTinh.Text = trimmer.Replace(txtMaMayTinh.Text, " ");
            txtTenMayTinh.Text = trimmer.Replace(txtTenMayTinh.Text, " "); 
            txtTenHSX.Text = trimmer.Replace(txtTenHSX.Text, " ");
            txtNamRaMat.Text = trimmer.Replace(txtNamRaMat.Text, " ");
            txtBaoHanh.Text = trimmer.Replace(txtBaoHanh.Text, " ");
            txtCPU.Text = trimmer.Replace(txtCPU.Text, " ");
            txtCard.Text = trimmer.Replace(txtCard.Text, " ");
            txtManHinh.Text = trimmer.Replace(txtManHinh.Text, " ");
            txtDungLuong.Text = trimmer.Replace(txtDungLuong.Text, " ");
            txtTrongLuong.Text = trimmer.Replace(txtTrongLuong.Text, " ");
            txtDonGia.Text = trimmer.Replace(txtDonGia.Text, " ");
            txtGhiChu.Text = trimmer.Replace(txtGhiChu.Text, " ");
        }
        private void FormMayTinh_Load(object sender, EventArgs e)
        {
            pnMayTinh.Visible = false;
            dtgMayTinh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            conn.Open();
            string QuerrySelect = "select *  from dbo.MayTinh";
            SqlCommand cmd = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgMayTinh.DataSource = dt;
            conn.Close();
        }

        private void btnSuaMT_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = true;
            pnMayTinh.Visible = true;
            btnThemMT.Enabled = false;
            pnMayTinh.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.Visible = true;
            btnLuu.Visible = false;
        }

        private void btnXoaMT_Click(object sender, EventArgs e)
        {
            if (checkClickdtg)
            {

                checkClickdtg = false;
                conn.Open();
                string QuerryDelete = "delete from  dbo.MayTinh where  MaMT = N'" + dtgMayTinh.Rows[numrow].Cells[0].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(QuerryDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                string QuerrySelect = "select *  from dbo.MayTinh";
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgMayTinh.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng để xoá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTimKiemMT_Click(object sender, EventArgs e)
        {
            pnInputSearch.Visible = true;
        }

        private void dtgMayTinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        int numrow;
        bool checkClickdtg = false;
        private void dtgMayTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            numrow = e.RowIndex;
            if (CheckClickBtnSua && numrow >= 0)
            {
                txtMaMayTinh.Text = dtgMayTinh.Rows[numrow].Cells[0].Value.ToString();
                txtTenMayTinh.Text = dtgMayTinh.Rows[numrow].Cells[1].Value.ToString();
                txtTenHSX.Text = dtgMayTinh.Rows[numrow].Cells[2].Value.ToString();
                cboLoaiHang.Text = dtgMayTinh.Rows[numrow].Cells[3].Value.ToString();
                txtBaoHanh.Text = dtgMayTinh.Rows[numrow].Cells[4].Value.ToString();
                txtNamRaMat.Text = dtgMayTinh.Rows[numrow].Cells[5].Value.ToString();
                txtCPU.Text = dtgMayTinh.Rows[numrow].Cells[6].Value.ToString();
                cboRAM1.Text = dtgMayTinh.Rows[numrow].Cells[7].Value.ToString();
                cboRAM2.Text = dtgMayTinh.Rows[numrow].Cells[8].Value.ToString();
                txtCard.Text = dtgMayTinh.Rows[numrow].Cells[9].Value.ToString();
                txtManHinh.Text = dtgMayTinh.Rows[numrow].Cells[10].Value.ToString();
                txtDungLuong.Text = dtgMayTinh.Rows[numrow].Cells[11].Value.ToString();
                txtTrongLuong.Text = dtgMayTinh.Rows[numrow].Cells[12].Value.ToString();
                cboTinhTrang.Text = dtgMayTinh.Rows[numrow].Cells[13].Value.ToString();
                txtDonGia.Text = dtgMayTinh.Rows[numrow].Cells[14].Value.ToString();
                txtGhiChu.Text = dtgMayTinh.Rows[numrow].Cells[15].Value.ToString();
            }
            checkClickdtg = true;

        }
        private void txtMaMayTinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text!="")
            {
                lblTimKiem.Visible = false;
            }    
            else
                {
                lblTimKiem.Visible = true;
            }
            string QuerrySelect = "select *  from dbo.MayTinh where MaMT LIKE '%" + txtTimKiem.Text + "%'" +
               "or TenMT LIKE N'%" + txtTimKiem.Text + "%'" +
               "or TenHSX LIKE N'%" + txtTimKiem.Text + "%'" +
               "or LoaiHang LIKE N'%" + txtTimKiem.Text + "%'" +
               "or BaoHanh LIKE N'%" + txtTimKiem.Text + "%'" +
               "or NamRaMat LIKE N'%" + txtTimKiem.Text + "%'" +
               "or CPU LIKE N'%" + txtTimKiem.Text + "%'" +
               "or RAM1 LIKE N'%" + txtTimKiem.Text + "%'" +
               "or RAM2 LIKE N'%" + txtTimKiem.Text + "%'" +
               "or ManHinh LIKE N'%" + txtTimKiem.Text + "%'" +
               "or DungLuong LIKE N'%" + txtTimKiem.Text + "%'" +
               "or TrongLuong LIKE N'%" + txtTimKiem.Text + "%'" +
               "or DonGia LIKE N'%" + txtTimKiem.Text + "%'" +
               "or GhiChu LIKE N'%" + txtTimKiem.Text + "%'" +
               "or TinhTrang LIKE N'%" + txtTimKiem.Text + "%'" +
               "or Card LIKE N'%" + txtTimKiem.Text + "%'";
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgMayTinh.DataSource = dt;
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
            if(txtTimKiem.Text=="")
            {
                lblTimKiem.Visible = true;
            }    
        }

        private void btnXTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            pnInputSearch.Visible = false;
            FormMayTinh_Load(sender, e);
        }
        public void SelectCondition(string QuerrySelect)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgMayTinh.DataSource = dt;
            conn.Close();
        }
        private void cbLietKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = cbLietKe.SelectedIndex;
            switch(a)
            {
                case 0:
                    FormMayTinh_Load(sender, e);
                    break;
                case 1:
                    SelectCondition("select * from dbo.MayTinh where DonGia < 10000000");
                    break;
                case 2:
                    SelectCondition("select * from dbo.MayTinh where DonGia between 10000000 and 15000000");
                    break;
                case 3:
                    SelectCondition("select * from dbo.MayTinh where DonGia between 15000000 and 20000000");
                    break;
                case 4:
                    SelectCondition("select * from dbo.MayTinh where DonGia between 20000000 and 30000000");
                    break;
                case 5:
                    SelectCondition("select * from dbo.MayTinh where DonGia > 30000000");
                    break;
            }

        }
    }
}
