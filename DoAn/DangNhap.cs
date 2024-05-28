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
        Functions f = new Functions();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            ptbShow.Visible = false;
            ptbHide.Visible = true;
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
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            bool LoginCheck = f.Login(tk,mk);
            if (LoginCheck)
            {
                f.TempAccount(tk);
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
    }
}
