using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words.Saving;

namespace DoAn
{
    public partial class FormBanHang : Form
    {
        Functions f = new Functions();
        public FormBanHang()
        {
            InitializeComponent();
            
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count>0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void btnKho_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnKho.BackColor = Color.White;
            loadform(new FormKho());
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnXuat.BackColor = Color.White;
            loadform(new FormXuat());
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnNhap.BackColor = Color.White;
            loadform(new FormNhap());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnNhaCungCap.BackColor = Color.White;
            loadform(new FormNCC());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnKhachHang.BackColor = Color.White;
            loadform(new FormKhachHang());
        }

        private void btnMayTinh_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnMayTinh.BackColor = Color.White;
            loadform(new FormMayTinh());
        }
        public void ResetColor()
        {
            btnNhap.BackColor = Color.Aqua;
            btnXuat.BackColor = Color.Aqua;
            btnMayTinh.BackColor = Color.Aqua;
            btnKhachHang.BackColor = Color.Aqua;
            btnNhaCungCap.BackColor = Color.Aqua;
            btnHoaDon.BackColor = Color.Aqua;
            btnKho.BackColor = Color.Aqua;
            btnNhanVien.BackColor = Color.Aqua;
            btnTrangChu.BackColor = Color.Aqua;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnNhanVien.BackColor = Color.White;
            loadform(new FormNhanVien());
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnTrangChu.BackColor = Color.White;
            loadform(new FormTrangChu());
        }
        private void EnabledAll()
        {
            btnNhap.Enabled = true;
            btnXuat.Enabled = true;
            btnMayTinh.Enabled = true;
            btnKhachHang.Enabled = true;
            btnNhaCungCap.Enabled = true;
            btnHoaDon.Enabled = true;
            btnKho.Enabled = true;
            btnNhanVien.Enabled = true;
        }
        private void FormBanHang_Load(object sender, EventArgs e)
        {
            string TenNV = Convert.ToString(f.Select_TblNhanVien("TenNV"));
            string ChucVu = Convert.ToString(f.Select_TblNhanVien("ChucVu"));
            lblTenNV.Text = TenNV;
            lblChucVu.Text = ChucVu;
            btnTrangChu_Click(sender, e);
            EnabledAll();
            switch(ChucVu)
            {
                case "Nhân viên bán hàng":
                    btnNhap.Enabled = false;
                    btnXuat.Enabled = false;
                    btnMayTinh.Enabled = true;
                    btnKhachHang.Enabled = true;
                    btnNhaCungCap.Enabled = false;
                    btnHoaDon.Enabled = false;
                    btnKho.Enabled = false;
                    btnNhanVien.Enabled = false;
                    break;
                case "Kế toán":
                    btnNhap.Enabled = false;
                    btnXuat.Enabled = false;
                    btnMayTinh.Enabled = true;
                    btnKhachHang.Enabled = true;
                    btnNhaCungCap.Enabled = false;
                    btnHoaDon.Enabled = true;
                    btnKho.Enabled = false;
                    btnNhanVien.Enabled = false;
                    break;
                case "Thủ kho":
                    btnNhap.Enabled = false;
                    btnXuat.Enabled = false;
                    btnMayTinh.Enabled = true;
                    btnKhachHang.Enabled = false;
                    btnNhaCungCap.Enabled = true;
                    btnHoaDon.Enabled = false;
                    btnKho.Enabled = true;
                    btnNhanVien.Enabled = false;
                    break;
                case "Nhân viên chăm sóc khách hàng":
                    btnNhap.Enabled = false;
                    btnXuat.Enabled = false;
                    btnMayTinh.Enabled = false;
                    btnKhachHang.Enabled = true;
                    btnNhaCungCap.Enabled = false;
                    btnHoaDon.Enabled = false;
                    btnKho.Enabled = false;
                    btnNhanVien.Enabled = false;
                    break;
                case "Nhân viên nhập xuất hàng":
                    btnNhap.Enabled = true;
                    btnXuat.Enabled = true;
                    btnMayTinh.Enabled = true;
                    btnKhachHang.Enabled = true;
                    btnNhaCungCap.Enabled = true;
                    btnHoaDon.Enabled = false;
                    btnKho.Enabled = false;
                    btnNhanVien.Enabled = false;
                    break;
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnHoaDon.BackColor = Color.White;
            loadform(new FormHoaDon());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            f.DeleteTemp();
            Close();
        }
    }
}
