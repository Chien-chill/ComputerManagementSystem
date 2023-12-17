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

namespace DoAn
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            ptbShow.Visible = false;
            ptbHide.Visible = true;
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy Liên Hệ Kỹ Thuật: 0943769822\nCoder by Trần Công Đông",
                "Thông Báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\QuanLyMayTinh\DoAn\DatabaseQuanLy.mdf;Integrated Security=True");

            conn.Open();
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            string sqlLogin = "select * from TaiKhoan where MaNV ='" + tk + "' and MatKhau = '" + mk + "'";
            SqlCommand cmd = new SqlCommand(sqlLogin, conn);
            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {
                conn.Close();
                conn.Open();
                string Querry = "insert into dbo.BoNhoTam (MaNV) values ('" + tk + "')";
                SqlCommand cmd1 = new SqlCommand(Querry, conn);
                cmd1.ExecuteNonQuery();
                conn.Close();
                this.Hide();
            FormBanHang formbanhang = new FormBanHang();
                 formbanhang.ShowDialog();
            this.Show();
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
            }
            else
            {
                MessageBox.Show("Mã nhân viên hoặc mật khẩu sai !", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void ptbShow_Click(object sender, EventArgs e)
        {
            ptbShow.Visible = false;
            ptbHide.Visible = true;
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void ptbHide_Click(object sender, EventArgs e)
        {
            ptbShow.Visible = true;
            ptbHide.Visible = false;
            txtMatKhau.UseSystemPasswordChar = false;
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
