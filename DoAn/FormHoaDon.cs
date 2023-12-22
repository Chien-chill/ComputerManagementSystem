using Aspose.Words.Tables;
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
using ThuVienWinform.Report.AsposeWordExtension;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DoAn
{
    public partial class FormHoaDon : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\QuanLyMayTinh\DoAn\DatabaseQuanLy.mdf;Integrated Security=True");
        HoaDon hoaDon;
        bool CheckClickBtnSua = false;
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = false;
            pnHD.Visible = true;
            pnHD.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnSuaHD.Enabled = false;
            dtpHD.Enabled = false;
            if (dtgHD.DataSource == null)
            {
                txtMaKH.Enabled = true;
            }
            else
            {
                txtMaKH.Enabled = false;
            }
            lblDateHD.Text = DateTime.Now.ToShortDateString();
            conn.Open();
            string QuerrySelectMaNV = "select MaNV from dbo.BoNhoTam ";
            SqlCommand cmd2 = new SqlCommand(QuerrySelectMaNV, conn);
            object GetMaNV = cmd2.ExecuteScalar();
            conn.Close();
            string MaNV = Convert.ToString(GetMaNV);
            txtMaNV.Text = MaNV;
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            pnHD.Visible = false;
            lblDateNow.Text = DateTime.Now.ToShortDateString();
            btnThemHD.Enabled = true;
            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;
            btnInPhieuHD.Enabled = true;
            btnInPhieuHD.Visible = true;
            btnBaoCao.Visible = false;
        }
        public void clear_whitespace()
        {
            txtMaHD.Text = txtMaHD.Text.Trim();
            txtMaKH.Text = txtMaKH.Text.Trim();
            txtMaMT.Text = txtMaMT.Text.Trim();
            txtSoLuong.Text = txtSoLuong.Text.Trim();
            txtMaNV.Text = txtMaNV.Text.Trim();
            Regex trimmer = new Regex(@"\s\s+"); // Xoá khoảng trắng thừa trong chuỗi 
            txtMaHD.Text = trimmer.Replace(txtMaHD.Text, " ");
            txtMaKH.Text = trimmer.Replace(txtMaKH.Text, " ");
            txtMaMT.Text = trimmer.Replace(txtMaMT.Text, " ");
            txtSoLuong.Text = trimmer.Replace(txtSoLuong.Text, " ");
            txtMaNV.Text = trimmer.Replace(txtMaNV.Text, " ");
        }
        public void ErrorWarning(ErrorProvider error, TextBox txt, string message)
        {
            error.SetError(txt, message);
            txt.Focus();
        }
        bool check = false;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int songuyen = 0;
            errorProvider1.Clear();
            clear_whitespace();
            conn.Open();
            string QuerryCheckMa = "select MaHD from dbo.HoaDon where MaHD = '" + txtMaHD.Text + "'";
            SqlCommand cmd1 = new SqlCommand(QuerryCheckMa, conn);
            SqlDataReader dta = cmd1.ExecuteReader();
            if (dta.Read() == true && check == false)
            {
                ErrorWarning(errorProvider1, txtMaHD, "Mã hoá đơn đã tồn tại");
                conn.Close();
            }
            else if (txtMaHD.Text == "")
            {
                ErrorWarning(errorProvider1, txtMaHD, "Chưa nhập mã hoá đơn");
                conn.Close();
            }
            else if (txtMaKH.Text == "")
            {
                ErrorWarning(errorProvider1, txtMaKH, "Chưa nhập mã khách hàng");
                conn.Close();
            }
            else if (txtMaMT.Text == "")
            {
                ErrorWarning(errorProvider1, txtMaMT, "Chưa nhập mã máy tính");
                conn.Close();
            }
            else if (txtSoLuong.Text == "")
            {
                ErrorWarning(errorProvider1, txtSoLuong, "Chưa nhập số lượng");
                conn.Close();
            }
            else if (int.TryParse(txtSoLuong.Text, out songuyen) == false || int.Parse(txtSoLuong.Text) <= 0)
            {
                ErrorWarning(errorProvider1, txtSoLuong, "Sai định dạng số lượng");
                conn.Close();
            }
            else if (txtMaNV.Text == "")
            {
                ErrorWarning(errorProvider1, txtMaNV, "Chưa nhập mã nhân viên");
                conn.Close();
            }
            else
            {
                conn.Close();
                check = true;
                hoaDon = new HoaDon()
                {
                    MaHoaDon = txtMaHD.Text,
                    NgayBan = lblDateHD.Text,
                    MaKH = txtMaKH.Text,
                    MaMT = txtMaMT.Text,
                    GiamGia=int.Parse(txtDiemTT.Text)/10,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    MaNV = txtMaNV.Text,
                    GhiChu = txtGhiChu.Text
                };
                dtgHD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                conn.Open();
                SqlCommand cmd3 = new SqlCommand("select MaKH from dbo.KhachHang where MaKH = '" + hoaDon.MaKH + "'", conn);
                SqlDataReader dta1 = cmd3.ExecuteReader();
                if (!dta1.Read())
                {
                    ErrorWarning(errorProvider1, txtMaKH, "Mã khách hàng không tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string QuerrySelectMaKH = "select TenKH from dbo.KhachHang where MaKH = '" + hoaDon.MaKH + "'";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelectMaKH, conn);
                    object GetTenKH = cmd2.ExecuteScalar();
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd4 = new SqlCommand("select MaMT from dbo.Kho where MaMT ='" + hoaDon.MaMT + "'", conn);
                    SqlDataReader dta2 = cmd4.ExecuteReader();
                    if (!dta2.Read())
                    {
                        ErrorWarning(errorProvider1, txtMaMT, "Mã máy tính không còn trong kho");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        string QuerrySelectDonGia = "select DonGiaBan from dbo.Kho where MaMT = '" + hoaDon.MaMT + "'";
                        SqlCommand cmd5 = new SqlCommand(QuerrySelectDonGia, conn);
                        object GetDonGia = cmd5.ExecuteScalar();
                        string QuerrySelectTenMT = "select TenMT from dbo.MayTinh where MaMT = '" + hoaDon.MaMT + "'";
                        SqlCommand cmd6 = new SqlCommand(QuerrySelectTenMT, conn);
                        object GetTenMT = cmd6.ExecuteScalar();
                        conn.Close();
                        hoaDon.TenMT = Convert.ToString(GetTenMT);
                        hoaDon.TenKH = Convert.ToString(GetTenKH);
                        hoaDon.DonGia = Convert.ToDouble(GetDonGia);
                        hoaDon.ThanhTien = hoaDon.DonGia * hoaDon.SoLuong;
                        conn.Open();
                        string QuerryInsert = "insert into dbo.HoaDon(MaHD,NgayBan,MaKH,TenKH,GiamGia,MaMT,TenMT,SoLuongMua,DonGia,ThanhTien,MaNV,GhiChu)" +
                            "values ('" + hoaDon.MaHoaDon + "','" + hoaDon.NgayBan + "','" + hoaDon.MaKH + "',N'" + hoaDon.TenKH + "'," + hoaDon.GiamGia + ",'" + hoaDon.MaMT + "',N'" + hoaDon.TenMT + "'," +
                            "" + hoaDon.SoLuong + "," + hoaDon.DonGia + "," + hoaDon.ThanhTien + ",'" + hoaDon.MaNV + "',N'" + hoaDon.GhiChu + "')";
                        SqlCommand cmd = new SqlCommand(QuerryInsert, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        txtMaHD.Enabled = false;
                        txtMaKH.Enabled = false;
                        txtMaMT.Text = "";
                        txtSoLuong.Text = "";
                        txtGhiChu.Text = "";
                        conn.Open();
                        string QuerrySelect = "select *  from dbo.HoaDon where MaHD = '" + txtMaHD.Text + "'";
                        SqlCommand cmd7 = new SqlCommand(QuerrySelect, conn);
                        SqlDataAdapter da = new SqlDataAdapter(cmd7);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtgHD.DataSource = dt;
                        conn.Close();
                    }
                }
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = true;
            pnHD.Visible = true;
            pnHD.BackColor = Color.FromArgb(255, 255, 128);
            btnThemHD.Enabled = false;
            btnSua.Visible = true;
            btnLuu.Visible = false;
            dtpHD.Enabled = false;
            conn.Open();
            string QuerrySelectMaNV = "select MaNV from dbo.BoNhoTam ";
            SqlCommand cmd2 = new SqlCommand(QuerrySelectMaNV, conn);
            object GetMaNV = cmd2.ExecuteScalar();
            conn.Close();
            string MaNV = Convert.ToString(GetMaNV);
            txtMaNV.Text = MaNV;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            pnHD.Visible = false;
            btnThemHD.Enabled = true;
            btnSuaHD.Enabled = true;
            btnXoaHD.Enabled = true;
            dtpHD.Enabled = true;
            txtMaMT.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
        }
        int numrow;
        bool checkClickdtg = false;

        private void dtgHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            if (CheckClickBtnSua && numrow >= 0)
            {
                txtMaKH.Enabled = true;
                txtMaHD.Text = dtgHD.Rows[numrow].Cells[0].Value.ToString();
                txtMaKH.Text = dtgHD.Rows[numrow].Cells[1].Value.ToString();
                txtMaMT.Text = dtgHD.Rows[numrow].Cells[3].Value.ToString();
                txtSoLuong.Text = dtgHD.Rows[numrow].Cells[5].Value.ToString();
                txtMaNV.Text = dtgHD.Rows[numrow].Cells[9].Value.ToString();
                txtGhiChu.Text = dtgHD.Rows[numrow].Cells[11].Value.ToString();
            }
            checkClickdtg = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int songuyen = 0;
            errorProvider1.Clear();
            clear_whitespace();
            if (txtMaKH.Text == "")
            {
                ErrorWarning(errorProvider1, txtMaKH, "Chưa nhập mã khách hàng");
            }
            else if (txtMaMT.Text == "")
            {
                ErrorWarning(errorProvider1, txtMaMT, "Chưa nhập mã máy tính");
            }
            else if (txtSoLuong.Text == "")
            {
                ErrorWarning(errorProvider1, txtSoLuong, "Chưa nhập số lượng");
            }
            else if (int.TryParse(txtSoLuong.Text, out songuyen) == false || int.Parse(txtSoLuong.Text) <= 0)
            {
                ErrorWarning(errorProvider1, txtSoLuong, "Sai định dạng số lượng");
            }
            else if (txtMaNV.Text == "")
            {
                ErrorWarning(errorProvider1, txtMaNV, "Chưa nhập mã nhân viên");
            }
            else
            {
                if (checkClickdtg)
                {
                    checkClickdtg = false;
                    conn.Open();
                    SqlCommand cmd3 = new SqlCommand("select MaKH from dbo.KhachHang where MaKH = '" + txtMaKH.Text + "'", conn);
                    SqlDataReader dta1 = cmd3.ExecuteReader();
                    if (!dta1.Read())
                    {
                        ErrorWarning(errorProvider1, txtMaKH, "Mã khách hàng không tồn tại");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        string QuerrySelectTenKH = "select TenKH from dbo.KhachHang where MaKH = '" + txtMaKH.Text + "'";
                        SqlCommand cmd2 = new SqlCommand(QuerrySelectTenKH, conn);
                        object GetTenKH = cmd2.ExecuteScalar();
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd4 = new SqlCommand("select MaMT from dbo.Kho where MaMT ='" + txtMaMT.Text + "'", conn);
                        SqlDataReader dta2 = cmd4.ExecuteReader();
                        if (!dta2.Read())
                        {
                            ErrorWarning(errorProvider1, txtMaMT, "Mã máy tính không còn trong kho");
                            conn.Close();
                        }
                        else
                        {
                            conn.Close();
                            conn.Open();
                            string QuerrySelectDonGia = "select DonGiaBan from dbo.Kho where MaMT = '" + txtMaMT.Text + "'";
                            SqlCommand cmd5 = new SqlCommand(QuerrySelectDonGia, conn);
                            object GetDonGia = cmd5.ExecuteScalar();
                            string QuerrySelectTenMT = "select TenMT from dbo.MayTinh where MaMT = '" + txtMaMT.Text + "'";
                            SqlCommand cmd6 = new SqlCommand(QuerrySelectTenMT, conn);
                            object GetTenMT = cmd6.ExecuteScalar();
                            conn.Close();
                            string TenMT = Convert.ToString(GetTenMT);
                            string TenKH = Convert.ToString(GetTenKH);
                            double DonGia = Convert.ToDouble(GetDonGia);
                            double ThanhTien = DonGia * int.Parse(txtSoLuong.Text);
                            int GiamGia = int.Parse(txtDiemTT.Text)/10;
                            string QuerryUpdate = " Update dbo.HoaDon set TenMT = N'" + TenMT + "',DonGia = " + DonGia + ",ThanhTien = " + ThanhTien +
                        ",MaMT = '" + txtMaMT.Text + "',SoLuongMua = " + int.Parse(txtSoLuong.Text) + ", MaNV = '"
                         + txtMaNV.Text + "', GhiChu = N'" + txtGhiChu.Text + "' where MaHD = '" + txtMaHD.Text + "' and MaKH = '" + dtgHD.Rows[numrow].Cells[1].Value.ToString() +
                         "' and GiamGia = '" + dtgHD.Rows[numrow].Cells[7].Value.ToString() + "' and MaMT = '" + dtgHD.Rows[numrow].Cells[3].Value.ToString() + "' and SoLuongMua = '" + dtgHD.Rows[numrow].Cells[5].Value.ToString() + "' and MaNV = '"
                         + dtgHD.Rows[numrow].Cells[9].Value.ToString() + "' and GhiChu = '" + dtgHD.Rows[numrow].Cells[11].Value.ToString() + "';";
                            string QuerryUpdateKH = "Update dbo.HoaDon set MaKH = '" + txtMaKH.Text + "', TenKH =N'" + TenKH + "' where MaHD = '" + txtMaHD.Text + "'";
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(QuerryUpdate, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            string QuerryUpdateGG = "Update dbo.HoaDon set GiamGia = " + GiamGia + "where MaHD = '" + txtMaHD.Text + "'";
                            conn.Open();
                            SqlCommand cmd0 = new SqlCommand(QuerryUpdateGG, conn);
                            cmd0.ExecuteNonQuery();
                            conn.Close();
                            conn.Open();
                            SqlCommand cmd7 = new SqlCommand(QuerryUpdateKH, conn);
                            cmd7.ExecuteNonQuery();
                            conn.Close();
                            string QuerrySelect = "select *  from dbo.HoaDon where MaHD = '" + txtMaHD.Text + "'";
                            conn.Open();
                            SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd1);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dtgHD.DataSource = dt;
                            conn.Close();
                            txtMaKH.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn dòng để sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (checkClickdtg)
            {

                checkClickdtg = false;
                string QuerryDelete = "delete from dbo.HoaDon where MaHD = '" + txtMaHD.Text + "' and MaKH = '" + dtgHD.Rows[numrow].Cells[1].Value.ToString() +
                     "' and GiamGia = '" + dtgHD.Rows[numrow].Cells[7].Value.ToString() + "' and MaMT = '" + dtgHD.Rows[numrow].Cells[3].Value.ToString() + "' and SoLuongMua = '" + dtgHD.Rows[numrow].Cells[5].Value.ToString() + "' and MaNV = '"
                     + dtgHD.Rows[numrow].Cells[9].Value.ToString() + "' and GhiChu = '" + dtgHD.Rows[numrow].Cells[11].Value.ToString() + "';";
                conn.Open();
                SqlCommand cmd = new SqlCommand(QuerryDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                string QuerrySelect = "select *  from dbo.HoaDon where MaHD = '" + txtMaHD.Text + "'";
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgHD.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng để xoá", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnInPhieuHD_Click(object sender, EventArgs e)
        {
            if (dtgHD.DataSource != null)
            {
                double TongSoTien = 0;
                var Today = DateTime.Now;
                Document HoaDon = new Document(@"TemplateWord\\Mau_Hoa_Don.doc");
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("select NgaySinhKH from dbo.KhachHang where MaKH = '" + dtgHD.Rows[0].Cells[1].Value.ToString() + "'", conn);
                object GetNgaySinh = cmd1.ExecuteScalar();
                string NgaySinh = Convert.ToString(GetNgaySinh);
                conn.Close();
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("select GioiTinhKH from dbo.KhachHang where MaKH = '" + dtgHD.Rows[0].Cells[1].Value.ToString() + "'", conn);
                object GetGioiTinh = cmd2.ExecuteScalar();
                string GioiTinh = Convert.ToString(GetGioiTinh);
                conn.Close();
                conn.Open();
                string QuerrySelectDiaChi = "select DiaChiKH from dbo.KhachHang where MaKH = '" + dtgHD.Rows[0].Cells[1].Value.ToString() + "'";
                SqlCommand cmd3 = new SqlCommand(QuerrySelectDiaChi, conn);
                object GetDiaChi = cmd3.ExecuteScalar();
                string DiaChi = Convert.ToString(GetDiaChi);
                conn.Close();
                conn.Open();
                string QuerrySelectDienThoai = "select DienThoaiKH from dbo.KhachHang where MaKH = '" + dtgHD.Rows[0].Cells[1].Value.ToString() + "'";
                SqlCommand cmd4 = new SqlCommand(QuerrySelectDienThoai, conn);
                object GetDienThoai = cmd4.ExecuteScalar();
                string DienThoai = Convert.ToString(GetDienThoai);
                conn.Close();
                conn.Open();
                string QuerrySelectBank = "select BANK from dbo.KhachHang where MaKH = '" + dtgHD.Rows[0].Cells[1].Value.ToString() + "'";
                SqlCommand cmd5 = new SqlCommand(QuerrySelectBank, conn);
                object GetBank = cmd5.ExecuteScalar();
                string Bank = Convert.ToString(GetBank);
                conn.Close();
                conn.Open();
                string QuerrySelectTenNV = "select TenNV from dbo.NhanVien where MaNV = '" + dtgHD.Rows[0].Cells[9].Value.ToString() + "'";
                SqlCommand cmd6 = new SqlCommand(QuerrySelectTenNV, conn);
                object GetTenNV = cmd6.ExecuteScalar();
                string TenNV = Convert.ToString(GetTenNV);
                conn.Close();
                conn.Open();
                SqlCommand cmd15 = new SqlCommand("select DiemThanThiet from dbo.KhachHang where MaKH = '" + dtgHD.Rows[0].Cells[1].Value.ToString() + "'", conn);
                object GetDiemThanThiet = cmd15.ExecuteScalar();
                double DiemThanThiet = Convert.ToDouble(GetDiemThanThiet);
                conn.Close();
                HoaDon.MailMerge.Execute(new[] { "Ngay_Thang_Nam" }, new[] { string.Format("Nam Định , ngày {0} tháng {1} năm {2}", Today.Day, Today.Month, Today.Year) });
                HoaDon.MailMerge.Execute(new[] { "Ma_HD" }, new[] { dtgHD.Rows[0].Cells[0].Value.ToString() });
                HoaDon.MailMerge.Execute(new[] { "Ma_KH" }, new[] { dtgHD.Rows[0].Cells[1].Value.ToString() });
                HoaDon.MailMerge.Execute(new[] { "Ten_KH" }, new[] { dtgHD.Rows[0].Cells[2].Value.ToString() });
                HoaDon.MailMerge.Execute(new[] { "Dia_Chi" }, new[] { DiaChi });
                HoaDon.MailMerge.Execute(new[] { "Ngay_Sinh" }, new[] { NgaySinh });
                HoaDon.MailMerge.Execute(new[] { "Gioi_Tinh" }, new[] { GioiTinh });
                HoaDon.MailMerge.Execute(new[] { "SDT" }, new[] { DienThoai });
                HoaDon.MailMerge.Execute(new[] { "BANK" }, new[] { Bank });
                HoaDon.MailMerge.Execute(new[] { "Ma_Nhan_Vien" }, new[] { dtgHD.Rows[0].Cells[9].Value.ToString() });
                HoaDon.MailMerge.Execute(new[] { "Ten_Nhan_Vien" }, new[] { TenNV });
                HoaDon.MailMerge.Execute(new[] { "Diem_TT" }, new[] { DiemThanThiet.ToString() });

                int count = dtgHD.Rows.Count;
                Table ThongTin = HoaDon.GetChild(NodeType.Table, 0, true) as Table;
                int row = 1;
                ThongTin.InsertRows(row, row, count - 1);
                for (int i = 0; i < count; i++)
                {
                    conn.Open();
                    SqlCommand cmd7 = new SqlCommand("select LoaiHang from dbo.MayTinh where MaMT = '" + dtgHD.Rows[i].Cells[3].Value.ToString() + "'", conn);
                    object GetLoaiHang = cmd7.ExecuteScalar();
                    string LoaiHang = Convert.ToString(GetLoaiHang);
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd8 = new SqlCommand("select BaoHanh from dbo.MayTinh where MaMT = '" + dtgHD.Rows[i].Cells[3].Value.ToString() + "'", conn);
                    object GetBaoHanh = cmd8.ExecuteScalar();
                    string BaoHanh = Convert.ToString(GetBaoHanh);
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd9 = new SqlCommand("select CPU from dbo.MayTinh where MaMT = '" + dtgHD.Rows[i].Cells[3].Value.ToString() + "'", conn);
                    object GetCPU = cmd9.ExecuteScalar();
                    string CPU = Convert.ToString(GetCPU);
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd10 = new SqlCommand("select RAM1 from dbo.MayTinh where MaMT = '" + dtgHD.Rows[i].Cells[3].Value.ToString() + "'", conn);
                    object GetRAM1 = cmd10.ExecuteScalar();
                    string RAM1 = Convert.ToString(GetRAM1);
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd11 = new SqlCommand("select RAM2 from dbo.MayTinh where MaMT = '" + dtgHD.Rows[i].Cells[3].Value.ToString() + "'", conn);
                    object GetRAM2 = cmd11.ExecuteScalar();
                    string RAM2 = Convert.ToString(GetRAM2);
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd12 = new SqlCommand("select Card from dbo.MayTinh where MaMT = '" + dtgHD.Rows[i].Cells[3].Value.ToString() + "'", conn);
                    object GetCard = cmd12.ExecuteScalar();
                    string Card = Convert.ToString(GetCard);
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd13 = new SqlCommand("select ManHinh from dbo.MayTinh where MaMT = '" + dtgHD.Rows[i].Cells[3].Value.ToString() + "'", conn);
                    object GetManHinh = cmd13.ExecuteScalar();
                    string ManHinh = Convert.ToString(GetManHinh);
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd14 = new SqlCommand("select DungLuong from dbo.MayTinh where MaMT = '" + dtgHD.Rows[i].Cells[3].Value.ToString() + "'", conn);
                    object GetDungLuong = cmd14.ExecuteScalar();
                    string DungLuong = Convert.ToString(GetDungLuong);
                    conn.Close();
                    ThongTin.PutValue(row, 0, dtgHD.Rows[i].Cells[3].Value.ToString());
                    ThongTin.PutValue(row, 1, dtgHD.Rows[i].Cells[4].Value.ToString());
                    ThongTin.PutValue(row, 2, LoaiHang +", "+CPU+", "+RAM1+"+"+RAM2+", "+Card+", "+ManHinh+", "+DungLuong);
                    ThongTin.PutValue(row, 3, dtgHD.Rows[i].Cells[5].Value.ToString());
                    ThongTin.PutValue(row, 4, BaoHanh);
                    ThongTin.PutValue(row, 5, dtgHD.Rows[i].Cells[6].Value.ToString());
                    ThongTin.PutValue(row, 6, dtgHD.Rows[i].Cells[8].Value.ToString());
                    ThongTin.PutValue(row, 7, dtgHD.Rows[i].Cells[9].Value.ToString());
                    TongSoTien += double.Parse(dtgHD.Rows[i].Cells[8].Value.ToString());
                    row++;
                    DiemThanThiet += (double.Parse(dtgHD.Rows[i].Cells[5].Value.ToString()) * 10);
                }
                HoaDon.MailMerge.Execute(new[] { "Tong_So_Tien" }, new[] { TongSoTien.ToString() });
                HoaDon.MailMerge.Execute(new[] { "Giam_Gia" }, new[] { dtgHD.Rows[0].Cells[7].Value.ToString() });
                double TienThanhToan;
                double GiamGia = (100 - double.Parse(dtgHD.Rows[0].Cells[7].Value.ToString()))/100;
                TienThanhToan = TongSoTien * GiamGia;
                HoaDon.MailMerge.Execute(new[] { "Thanh_Toan" }, new[] { TienThanhToan.ToString() });
                HoaDon.SaveAndOpenFile("HoaDon.doc");
                conn.Open();
                SqlCommand cmd16 = new SqlCommand("update dbo.KhachHang set DiemThanThiet = "+ DiemThanThiet+"where MaKH = '" + dtgHD.Rows[0].Cells[1].Value.ToString() + "'", conn);
                cmd16.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dtpHD_ValueChanged(object sender, EventArgs e)
        {
            dtgHD.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            string QuerrySelect = "select * from dbo.HoaDon where NgayBan = '" + dtpHD.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgHD.DataSource = dt;
            conn.Close();
            btnThemHD.Enabled = false;
            btnSuaHD.Enabled = false;
            btnXoaHD.Enabled = false;
            btnInPhieuHD.Visible = false;
            btnBaoCao.Visible = true;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            FormHoaDon_Load(sender, e);
            check = false;
            txtMaHD.Enabled = true;
            dtgHD.DataSource = null;
            btnInPhieuHD.Visible = true;
            btnBaoCao.Visible = false;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (dtgHD.DataSource != null)
            {
                double TongSoTien = 0;
                Document BaoCao = new Document(@"TemplateWord\\Mau_Bao_Cao_Doanh_Thu.doc");
                BaoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam" }, new[] { dtpHD.Text });
                int count = dtgHD.Rows.Count;
                Table ThongTin = BaoCao.GetChild(NodeType.Table, 0, true) as Table;
                int row = 1;
                ThongTin.InsertRows(row, row, count - 1);
                for (int i = 0; i < count; i++)
                {
                    ThongTin.PutValue(row, 0, dtgHD.Rows[i].Cells[0].Value.ToString());
                    ThongTin.PutValue(row, 1, dtgHD.Rows[i].Cells[1].Value.ToString());
                    ThongTin.PutValue(row, 2, dtgHD.Rows[i].Cells[3].Value.ToString());
                    ThongTin.PutValue(row, 3, dtgHD.Rows[i].Cells[5].Value.ToString());
                    ThongTin.PutValue(row, 4, dtgHD.Rows[i].Cells[6].Value.ToString());
                    ThongTin.PutValue(row, 5, dtgHD.Rows[i].Cells[8].Value.ToString());
                    ThongTin.PutValue(row, 6, dtgHD.Rows[i].Cells[9].Value.ToString());
                    ThongTin.PutValue(row, 7, dtgHD.Rows[i].Cells[11].Value.ToString());
                    TongSoTien += double.Parse(dtgHD.Rows[i].Cells[8].Value.ToString());
                    row++;
                }
                BaoCao.MailMerge.Execute(new[] { "Tong_So_Tien" }, new[] { TongSoTien.ToString() });
                BaoCao.SaveAndOpenFile("DoanhThu.doc");
            }
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd3 = new SqlCommand("select MaKH from dbo.KhachHang where MaKH = '" + txtMaKH.Text + "'", conn);
            SqlDataReader dta1 = cmd3.ExecuteReader();
            if (dta1.Read())
            {
            conn.Close();
            conn.Open();
            string QuerrySelectDiemTT = "select DiemThanThiet from dbo.KhachHang where MaKH = '" + txtMaKH.Text + "'";
            SqlCommand cmd = new SqlCommand(QuerrySelectDiemTT, conn);
            object GetDiemTT = cmd.ExecuteScalar();
            string DiemTT = Convert.ToString(GetDiemTT);
            conn.Close();
            txtDiemTT.Text = DiemTT;
            }
            else
            {
            conn.Close();
            }    
        }
    }
}