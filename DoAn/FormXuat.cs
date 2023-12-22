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
using static System.Net.Mime.MediaTypeNames;


namespace DoAn
{
    public partial class FormXuat : Form
    {
        
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\QuanLyMayTinh\DoAn\DatabaseQuanLy.mdf;Integrated Security=True");
        PhieuXuat phieuXuat;
        bool CheckClickBtnSua = false;
        public FormXuat()
        {
            InitializeComponent();
        }
        
        

        private void FormXuat_Load(object sender, EventArgs e)
        {
            pnXuat.Visible = false;
            lblDateNow.Text = DateTime.Now.ToShortDateString();
            btnThemXuat.Enabled =true;
            btnSuaXuat.Enabled = true;
            btnXoaXuat.Enabled = true;
            btnInPhieuXuat.Enabled = true;
        }
        private void btnThemXuat_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = false;
            pnXuat.Visible = true;
            pnXuat.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnSuaXuat.Enabled = false;
            dtpPhieuXuat.Enabled = false;
            lblDatePhieuXuat.Text = DateTime.Now.ToShortDateString();
            if (dtgPhieuXuat.DataSource == null)
            {
                txtMaKH.Enabled = true;
                txtThue.Enabled = true;
            }
            else
            {
                txtMaKH.Enabled = false;
                txtThue.Enabled = false;
            }
            conn.Open();
            string QuerrySelectMaNV = "select MaNV from dbo.BoNhoTam ";
            SqlCommand cmd2 = new SqlCommand(QuerrySelectMaNV, conn);
            object GetMaNV = cmd2.ExecuteScalar();
            conn.Close();
            string MaNV = Convert.ToString(GetMaNV);
            txtMaNV.Text = MaNV;
        }
        public void clear_whitespace()
        {
            txtMaPhieuXuat.Text = txtMaPhieuXuat.Text.Trim();
            txtMaKH.Text = txtMaKH.Text.Trim();
            txtMaMT.Text = txtMaMT.Text.Trim();
            txtThue.Text = txtThue.Text.Trim();
            txtSoLuong.Text = txtSoLuong.Text.Trim();
            txtMaNV.Text = txtMaNV.Text.Trim();
            Regex trimmer = new Regex(@"\s\s+"); // Xoá khoảng trắng thừa trong chuỗi 
            txtMaPhieuXuat.Text = trimmer.Replace(txtMaPhieuXuat.Text, " ");
            txtMaKH.Text = trimmer.Replace(txtMaKH.Text, " ");
            txtMaMT.Text = trimmer.Replace(txtMaMT.Text, " ");
            txtThue.Text = trimmer.Replace(txtThue.Text, " ");
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
            string QuerryCheckMa = "select MaPhieuXuat from dbo.PhieuXuat where MaPhieuXuat = '" + txtMaPhieuXuat.Text + "'";
            SqlCommand cmd1 = new SqlCommand(QuerryCheckMa, conn);
            SqlDataReader dta = cmd1.ExecuteReader();
            if (dta.Read() == true && check == false)
            {
                ErrorWarning(errorProvider1,txtMaPhieuXuat, "Mã phiếu xuất đã tồn tại");
                conn.Close();
            }
            else if (txtMaPhieuXuat.Text == "")
            {
                ErrorWarning(errorProvider1,txtMaPhieuXuat, "Chưa nhập mã phiếu xuất");
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
            else if (txtThue.Text == "")
            {
                ErrorWarning(errorProvider1,txtThue, "Chưa nhập mã số thuế");
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
                phieuXuat = new PhieuXuat()
                {
                    MaPhieuXuat = txtMaPhieuXuat.Text,
                    NgayLamPhieu = lblDatePhieuXuat.Text,
                    MaKH = txtMaKH.Text,
                    Thue = txtThue.Text,
                    MaMT = txtMaMT.Text,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    MaNV = txtMaNV.Text,
                    GhiChu = txtGhiChu.Text
                };
                dtgPhieuXuat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
               conn.Open();
                SqlCommand cmd3 = new SqlCommand("select MaKH from dbo.KhachHang where MaKH = '" + phieuXuat.MaKH + "'", conn);
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
                    string QuerrySelectMaKH = "select TenKH from dbo.KhachHang where MaKH = '" + phieuXuat.MaKH + "'";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelectMaKH, conn);
                    object GetTenKH = cmd2.ExecuteScalar();
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd4 = new SqlCommand("select MaMT from dbo.Kho where MaMT ='" + phieuXuat.MaMT + "'", conn);
                    SqlDataReader dta2 = cmd4.ExecuteReader();
                    if (!dta2.Read())
                    {
                        ErrorWarning(errorProvider1,txtMaMT, "Mã máy tính không còn trong kho");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        string QuerrySelectDonGia = "select DonGiaBan from dbo.Kho where MaMT = '" + phieuXuat.MaMT + "'";
                        SqlCommand cmd5 = new SqlCommand(QuerrySelectDonGia, conn);
                        object GetDonGia = cmd5.ExecuteScalar();
                        string QuerrySelectTenMT = "select TenMT from dbo.MayTinh where MaMT = '" + phieuXuat.MaMT + "'";
                        SqlCommand cmd6 = new SqlCommand(QuerrySelectTenMT, conn);
                        object GetTenMT = cmd6.ExecuteScalar();
                        conn.Close();
                        phieuXuat.TenMT = Convert.ToString(GetTenMT);
                        phieuXuat.TenKH = Convert.ToString(GetTenKH);
                        phieuXuat.DonGia = Convert.ToDouble(GetDonGia);
                        phieuXuat.ThanhTien = phieuXuat.DonGia * phieuXuat.SoLuong;
                        conn.Open();
                        string QuerryInsert = "insert into dbo.PhieuXuat(MaPhieuXuat,NgayLamPhieu,MaKH,TenKH,Thue,MaMT,TenMT,SoLuong,DonGia,ThanhTien,MaNV,GhiChu)" +
                            "values ('" + phieuXuat.MaPhieuXuat + "','" + phieuXuat.NgayLamPhieu + "','" + phieuXuat.MaKH + "',N'" + phieuXuat.TenKH + "','" + phieuXuat.Thue + "','" + phieuXuat.MaMT + "',N'" + phieuXuat.TenMT + "'," +
                            "" + phieuXuat.SoLuong + "," + phieuXuat.DonGia + "," + phieuXuat.ThanhTien + ",'" + phieuXuat.MaNV + "',N'" + phieuXuat.GhiChu + "')";
                        SqlCommand cmd = new SqlCommand(QuerryInsert, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        txtMaPhieuXuat.Enabled = false;
                        txtMaKH.Enabled = false;
                        txtThue.Enabled=false;
                        txtMaMT.Text = "";
                        txtSoLuong.Text = "";
                        txtGhiChu.Text = "";
                        conn.Open();
                        string QuerrySelect = "select *  from dbo.PhieuXuat where MaPhieuXuat = '" + txtMaPhieuXuat.Text + "'";
                        SqlCommand cmd7 = new SqlCommand(QuerrySelect, conn);
                        SqlDataAdapter da = new SqlDataAdapter(cmd7);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtgPhieuXuat.DataSource = dt;
                        conn.Close();
                    }
                }
            }
        }

        private void btnSuaXuat_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = true;
            pnXuat.Visible = true;
            pnXuat.BackColor = Color.FromArgb(255, 255, 128);
            btnThemXuat.Enabled = false;
            btnSua.Visible = true;
            btnLuu.Visible = false;
            dtpPhieuXuat.Enabled = false;
            conn.Open();
            string QuerrySelectMaNV = "select MaNV from dbo.BoNhoTam ";
            SqlCommand cmd2 = new SqlCommand(QuerrySelectMaNV, conn);
            object GetMaNV = cmd2.ExecuteScalar();
            conn.Close();
            string MaNV = Convert.ToString(GetMaNV);
            txtMaNV.Text = MaNV;
        }
        private void dtpPhieuNhap_ValueChanged(object sender, EventArgs e)
        {
            dtgPhieuXuat.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            string QuerrySelect = "select * from dbo.PhieuXuat where NgayLamPhieu = '" + dtpPhieuXuat.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgPhieuXuat.DataSource = dt;
            conn.Close();
            btnThemXuat.Enabled = false;
            btnSuaXuat.Enabled = false;
            btnXoaXuat.Enabled = false;
            btnInPhieuXuat.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            pnXuat.Visible = false;
            btnThemXuat.Enabled = true;
            btnSuaXuat.Enabled = true;
            btnXoaXuat.Enabled = true;
            dtpPhieuXuat.Enabled = true;
            txtMaMT.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
        }
        int numrow;
        bool checkClickdtg = false;

        private void dtgPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            if (CheckClickBtnSua && numrow >=0)
            {
                txtMaKH.Enabled = true;
                txtThue.Enabled = true;
                txtMaPhieuXuat.Text = dtgPhieuXuat.Rows[numrow].Cells[0].Value.ToString();
                txtMaKH.Text = dtgPhieuXuat.Rows[numrow].Cells[2].Value.ToString();
                txtThue.Text = dtgPhieuXuat.Rows[numrow].Cells[4].Value.ToString();
                txtMaMT.Text = dtgPhieuXuat.Rows[numrow].Cells[5].Value.ToString();
                txtSoLuong.Text = dtgPhieuXuat.Rows[numrow].Cells[7].Value.ToString();
                txtMaNV.Text = dtgPhieuXuat.Rows[numrow].Cells[10].Value.ToString();
                txtGhiChu.Text = dtgPhieuXuat.Rows[numrow].Cells[11].Value.ToString();
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
            else if (txtThue.Text == "")
            {
                ErrorWarning(errorProvider1, txtThue, "Chưa nhập thuế");
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
                    string QuerrySelectMaCT = "select TenKH from dbo.KhachHang where MaKH = '" + txtMaKH.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelectMaCT, conn);
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
                        if (checkClickdtg)
                        {
                            checkClickdtg = false;
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

                            string QuerryUpdate = " Update dbo.PhieuXuat set TenMT = N'" + TenMT + "',DonGia = " + DonGia + ",ThanhTien = " + ThanhTien +
                         ",MaMT = '" + txtMaMT.Text + "',SoLuong = " + int.Parse(txtSoLuong.Text) + ", MaNV = '"
                         + txtMaNV.Text + "', GhiChu = N'" + txtGhiChu.Text + "' where MaPhieuXuat = '" + txtMaPhieuXuat.Text + "' and MaKH = '" + dtgPhieuXuat.Rows[numrow].Cells[2].Value.ToString() +
                         "' and Thue = '" + dtgPhieuXuat.Rows[numrow].Cells[4].Value.ToString() + "' and MaMT = '" + dtgPhieuXuat.Rows[numrow].Cells[5].Value.ToString() + "' and SoLuong = '" + dtgPhieuXuat.Rows[numrow].Cells[7].Value.ToString() + "' and MaNV = '"
                         + dtgPhieuXuat.Rows[numrow].Cells[10].Value.ToString() + "' and GhiChu = N'" + dtgPhieuXuat.Rows[numrow].Cells[11].Value.ToString() + "';";
                            string QuerryUpdateKH = "Update dbo.PhieuXuat set MaKH = '" + txtMaKH.Text + "', TenKH =N'" + TenKH + "' where MaPhieuXuat = '" + txtMaPhieuXuat.Text + "'";
                            string QuerryUpdateThue = "Update dbo.PhieuXuat set Thue = '" + txtThue.Text + "' where MaPhieuXuat = '" + txtMaPhieuXuat.Text + "'";
                            conn.Open();
                            SqlCommand cmd8 = new SqlCommand(QuerryUpdateThue, conn);
                            cmd8.ExecuteNonQuery();
                            conn.Close();
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(QuerryUpdate, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            conn.Open();
                            SqlCommand cmd7 = new SqlCommand(QuerryUpdateKH, conn);
                            cmd7.ExecuteNonQuery();
                            conn.Close();
                            string QuerrySelect = "select *  from dbo.PhieuXuat where MaPhieuXuat = '" + txtMaPhieuXuat.Text + "'";
                            conn.Open();
                            SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
                            SqlDataAdapter da = new SqlDataAdapter(cmd1);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dtgPhieuXuat.DataSource = dt;
                            conn.Close();
                            txtMaKH.Enabled = false;
                            txtThue.Enabled = false;
                        }
                else
                {
                    MessageBox.Show("Chưa chọn dòng để sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    }
                }
            }
        }

        private void btnXoaXuat_Click(object sender, EventArgs e)
        {
            if(checkClickdtg)
            {
                
                checkClickdtg = false;
                string QuerryDelete = "delete from dbo.PhieuXuat where MaPhieuXuat = '" + txtMaPhieuXuat.Text + "' and MaKH = '" + dtgPhieuXuat.Rows[numrow].Cells[2].Value.ToString() +
                     "' and Thue = '" + dtgPhieuXuat.Rows[numrow].Cells[4].Value.ToString() + "' and MaMT = '" + dtgPhieuXuat.Rows[numrow].Cells[5].Value.ToString() + "' and SoLuong = '" + dtgPhieuXuat.Rows[numrow].Cells[7].Value.ToString() + "' and MaNV = '"
                     + dtgPhieuXuat.Rows[numrow].Cells[10].Value.ToString() + "' and GhiChu = N'" + dtgPhieuXuat.Rows[numrow].Cells[11].Value.ToString() + "';";
                conn.Open();
                SqlCommand cmd = new SqlCommand(QuerryDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                string QuerrySelect = "select *  from dbo.PhieuXuat where MaPhieuXuat = '" + txtMaPhieuXuat.Text + "'";
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(QuerrySelect,conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgPhieuXuat.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng để xoá","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            } 
                
        }

        private void btnInPhieuXuat_Click(object sender, EventArgs e)
        {
            if (dtgPhieuXuat.DataSource != null)
            {
                double TongSoTien = 0;
                var Today = DateTime.Now;
                Document PhieuXuat = new Document(@"TemplateWord\\Mau_Phieu_Xuat.doc");

                conn.Open();
                string QuerrySelectDiaChi = "select DiaChiKH from dbo.KhachHang where MaKH = '" + dtgPhieuXuat.Rows[0].Cells[2].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(QuerrySelectDiaChi, conn);
                object GetDiaChi = cmd.ExecuteScalar();
                string DiaChi = Convert.ToString(GetDiaChi);
                conn.Close();
                conn.Open();
                string QuerrySelectDienThoai = "select DienThoaiKH from dbo.KhachHang where MaKH = '" + dtgPhieuXuat.Rows[0].Cells[2].Value.ToString() + "'";
                SqlCommand cmd1 = new SqlCommand(QuerrySelectDienThoai, conn);
                object GetDienThoai = cmd1.ExecuteScalar();
                string DienThoai = Convert.ToString(GetDienThoai);
                conn.Close();
                conn.Open();
                string QuerrySelectBank = "select BANK from dbo.KhachHang where MaKH = '" + dtgPhieuXuat.Rows[0].Cells[2].Value.ToString() + "'";
                SqlCommand cmd2 = new SqlCommand(QuerrySelectBank, conn);
                object GetBank = cmd2.ExecuteScalar();
                string Bank = Convert.ToString(GetBank);
                conn.Close();
                conn.Open();
                string QuerrySelectTenNV = "select TenNV from dbo.NhanVien where MaNV = '" + dtgPhieuXuat.Rows[0].Cells[10].Value.ToString() + "'";
                SqlCommand cmd3 = new SqlCommand(QuerrySelectTenNV, conn);
                object GetTenNV = cmd3.ExecuteScalar();
                string TenNV = Convert.ToString(GetTenNV);
                conn.Close();
                PhieuXuat.MailMerge.Execute(new[] { "Ngay_Thang_Nam" }, new[] { string.Format("Nam Định , ngày {0} tháng {1} năm {2}", Today.Day, Today.Month, Today.Year) });
                PhieuXuat.MailMerge.Execute(new[] { "Ma_Xuat" }, new[] { dtgPhieuXuat.Rows[0].Cells[0].Value.ToString() });
                PhieuXuat.MailMerge.Execute(new[] { "Ma_Khach_Hang" }, new[] { dtgPhieuXuat.Rows[0].Cells[2].Value.ToString() });
                PhieuXuat.MailMerge.Execute(new[] { "Ten_Khach_Hang" }, new[] { dtgPhieuXuat.Rows[0].Cells[3].Value.ToString() });
                PhieuXuat.MailMerge.Execute(new[] { "THUE" }, new[] { dtgPhieuXuat.Rows[0].Cells[4].Value.ToString() });
                PhieuXuat.MailMerge.Execute(new[] { "Dia_Chi" }, new[] { DiaChi });
                PhieuXuat.MailMerge.Execute(new[] { "SDT" }, new[] { DienThoai });
                PhieuXuat.MailMerge.Execute(new[] { "BANK" }, new[] { Bank });
                PhieuXuat.MailMerge.Execute(new[] { "Ma_Nhan_Vien" }, new[] { dtgPhieuXuat.Rows[0].Cells[10].Value.ToString() });
                PhieuXuat.MailMerge.Execute(new[] { "Ten_Nhan_Vien" }, new[] { TenNV });

                int count = dtgPhieuXuat.Rows.Count;
                Table ThongTin = PhieuXuat.GetChild(NodeType.Table, 0, true) as Table;
                int row = 1;
                ThongTin.InsertRows(row, row, count - 1);
                for (int i = 0; i < count; i++)
                {
                    ThongTin.PutValue(row, 0, dtgPhieuXuat.Rows[i].Cells[5].Value.ToString());
                    ThongTin.PutValue(row, 1, dtgPhieuXuat.Rows[i].Cells[6].Value.ToString());
                    ThongTin.PutValue(row, 2, dtgPhieuXuat.Rows[i].Cells[7].Value.ToString());
                    ThongTin.PutValue(row, 3, dtgPhieuXuat.Rows[i].Cells[8].Value.ToString());
                    ThongTin.PutValue(row, 4, dtgPhieuXuat.Rows[i].Cells[9].Value.ToString());
                    ThongTin.PutValue(row, 5, dtgPhieuXuat.Rows[i].Cells[11].Value.ToString());
                    TongSoTien += double.Parse(dtgPhieuXuat.Rows[i].Cells[9].Value.ToString());
                    row++;
                }
                PhieuXuat.MailMerge.Execute(new[] { "Tong_So_Tien" }, new[] { TongSoTien.ToString() });
                PhieuXuat.SaveAndOpenFile("PhieuXuat.doc");
            }
            else
            {
                MessageBox.Show("Chưa nhập thông tin phiếu xuất", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            FormXuat_Load(sender, e);
            check = false;
            txtMaPhieuXuat.Enabled = true;
            dtgPhieuXuat.DataSource = null;
        }
    }
}
