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
using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using Aspose.Words;
using ThuVienWinform.Report.AsposeWordExtension;
using Aspose.Words.Tables;

namespace DoAn
{
    public partial class FormNhap : Form
    {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\QuanLyMayTinh\DoAn\DatabaseQuanLy.mdf;Integrated Security=True");
            PhieuNhap phieuNhap;
            bool CheckClickBtnSua = false;
        public FormNhap()
        {
            InitializeComponent();
        }

        private void btnThemNhap_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = false;
            pnNhap.Visible= true;
            pnNhap.BackColor = Color.FromArgb(128, 255, 128);
            btnSua.Visible = false;
            btnLuu.Visible = true;
            btnSuaNhap.Enabled = false;
            dtpPhieuNhap.Enabled = false;
            lblDatePhieuNhap.Text= DateTime.Now.ToShortDateString();
            if(dtgPhieuNhap.DataSource == null)
            {
                txtMaCT.Enabled = true;
                txtThue.Enabled = true;
            }
            else
            {
                txtMaCT.Enabled = false;
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
        private void FormNhap_Load(object sender, EventArgs e)
        {
            pnNhap.Visible = false;
            lblDateNow.Text = DateTime.Now.ToShortDateString();
            btnThemNhap.Enabled = true;
            btnSuaNhap.Enabled = true;
            btnXoaNhap.Enabled = true;
            btnInNhap.Enabled = true;
        }
        public void clear_whitespace ()
        {
            txtMaPhieuNhap.Text = txtMaPhieuNhap.Text.Trim();
            txtMaCT.Text = txtMaCT.Text.Trim();
            txtMaMT.Text = txtMaMT.Text.Trim();
            txtThue.Text = txtThue.Text.Trim();
            txtSoLuong.Text = txtSoLuong.Text.Trim();
            txtMaNV.Text = txtMaNV.Text.Trim();
            Regex trimmer = new Regex(@"\s\s+"); // Xoá khoảng trắng thừa trong chuỗi 
            txtMaPhieuNhap.Text = trimmer.Replace ( txtMaPhieuNhap.Text, " ");
            txtMaCT.Text = trimmer.Replace ( txtMaCT.Text, " ");
            txtMaMT.Text = trimmer.Replace ( txtMaMT.Text, " ");
            txtThue.Text = trimmer.Replace ( txtThue.Text, " ");
            txtSoLuong.Text = trimmer.Replace ( txtSoLuong.Text, " ");
            txtMaNV.Text = trimmer.Replace (txtMaNV.Text, " ");
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
            string QuerryCheckMa = "select MaPhieuNhap from dbo.PhieuNhap where MaPhieuNhap = '" + txtMaPhieuNhap.Text + "'";
            SqlCommand cmd1 = new SqlCommand(QuerryCheckMa,conn);
            SqlDataReader dta = cmd1.ExecuteReader();
            if (dta.Read() == true && check == false)
            {
                ErrorWarning(errorProvider1,txtMaPhieuNhap, "Mã phiếu nhập đã tồn tại");
                conn.Close();
            }
            else if (txtMaPhieuNhap.Text == "")
            {
                ErrorWarning(errorProvider1,txtMaPhieuNhap, "Chưa nhập mã phiếu nhập");
                conn.Close();
            }
            else if (txtMaCT.Text == "")
            {
                ErrorWarning(errorProvider1,txtMaCT, "Chưa nhập mã công ty");
                conn.Close();
            }
            else if (txtMaMT.Text == "")
            {
                ErrorWarning(errorProvider1,txtMaMT, "Chưa nhập mã máy tính");
                conn.Close();
            }
            else if (txtThue.Text == "")
            {
                ErrorWarning(errorProvider1,txtThue, "Chưa nhập mã số thuế");
                conn.Close();
            }
            else if (txtSoLuong.Text == "")
            {
                ErrorWarning(errorProvider1,txtSoLuong, "Chưa nhập số lượng");
                conn.Close();
            }
            else if (int.TryParse(txtSoLuong.Text, out songuyen) == false || int.Parse(txtSoLuong.Text) <= 0)
            {
                ErrorWarning(errorProvider1,txtSoLuong, "Sai định dạng số lượng");
                conn.Close();
            }
            else if (txtMaNV.Text == "")
            {
                ErrorWarning(errorProvider1,txtMaNV, "Chưa nhập mã nhân viên");
                conn.Close();
            }
            else
            {
                conn.Close();
                check = true;
                phieuNhap = new PhieuNhap()
                {
                    MaPhieuNhap = txtMaPhieuNhap.Text,
                    NgayLamPhieu = lblDatePhieuNhap.Text,
                    MaCT = txtMaCT.Text,
                    Thue = txtThue.Text,
                    MaMT = txtMaMT.Text,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    MaNV = txtMaNV.Text,
                    GhiChu = txtGhiChu.Text
                };
                dtgPhieuNhap.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                conn.Open();
                SqlCommand cmd3 = new SqlCommand("select MaCT from dbo.CongTy where MaCT = '" + phieuNhap.MaCT + "'", conn);
                SqlDataReader dta1 = cmd3.ExecuteReader();
                if (!dta1.Read())
                {
                    ErrorWarning(errorProvider1,txtMaCT, "Mã công ty không tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string QuerrySelectMaCT = "select TenCT from dbo.CongTy where MaCT = '" + phieuNhap.MaCT + "'";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelectMaCT, conn);
                    object GetTenCT = cmd2.ExecuteScalar();
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd4 = new SqlCommand("select MaMT from dbo.MayTinh where MaMT ='" + phieuNhap.MaMT + "'", conn);
                    SqlDataReader dta2 = cmd4.ExecuteReader();
                    if (!dta2.Read())
                    {
                        ErrorWarning(errorProvider1,txtMaMT, "Mã máy tính không tồn tại");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        string QuerrySelectDonGia = "select DonGia from dbo.MayTinh where MaMT = '" + phieuNhap.MaMT + "'";
                        SqlCommand cmd5 = new SqlCommand(QuerrySelectDonGia, conn);
                        object GetDonGia = cmd5.ExecuteScalar();
                        string QuerrySelectTenMT = "select TenMT from dbo.MayTinh where MaMT = '" + phieuNhap.MaMT + "'";
                        SqlCommand cmd6 = new SqlCommand(QuerrySelectTenMT, conn);
                        object GetTenMT = cmd6.ExecuteScalar();
                        conn.Close();
                        phieuNhap.TenMT = Convert.ToString(GetTenMT);
                        phieuNhap.TenCT = Convert.ToString(GetTenCT);
                        phieuNhap.DonGia = Convert.ToDouble(GetDonGia);
                        phieuNhap.ThanhTien = phieuNhap.DonGia * phieuNhap.SoLuong;
                        conn.Open();
                        string QuerryInsert = "insert into dbo.PhieuNhap(MaPhieuNhap,NgayLamPhieu,MaCT,TenCT,Thue,MaMT,TenMT,SoLuong,DonGia,ThanhTien,MaNV,GhiChu)" +
                            "values ('" + phieuNhap.MaPhieuNhap + "','" + phieuNhap.NgayLamPhieu + "','" + phieuNhap.MaCT + "',N'" + phieuNhap.TenCT + "','" + phieuNhap.Thue + "','" + phieuNhap.MaMT + "',N'" + phieuNhap.TenMT + "'," +
                            "" + phieuNhap.SoLuong + "," + phieuNhap.DonGia + "," + phieuNhap.ThanhTien + ",'" + phieuNhap.MaNV + "',N'" + phieuNhap.GhiChu + "')";
                        SqlCommand cmd = new SqlCommand(QuerryInsert, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        txtMaPhieuNhap.Enabled = false;
                        txtMaCT.Enabled = false;
                        txtThue.Enabled = false;
                        txtMaMT.Text = "";
                        txtSoLuong.Text = "";
                        txtGhiChu.Text = "";
                        conn.Open();
                        string QuerrySelect = "select *  from dbo.PhieuNhap where MaPhieuNhap = '" + txtMaPhieuNhap.Text + "'";
                        SqlCommand cmd7 = new SqlCommand(QuerrySelect, conn);
                        SqlDataAdapter da = new SqlDataAdapter(cmd7);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtgPhieuNhap.DataSource = dt;
                        conn.Close();
                    }
                }
            }


        }
        private void btnSuaNhap_Click(object sender, EventArgs e)
        {
            CheckClickBtnSua = true;
            pnNhap.Visible = true;
            btnThemNhap.Enabled = false;
            btnXoaNhap.Enabled = false;
            pnNhap.BackColor = Color.FromArgb(255, 255, 128);
            btnSua.Visible = true;
            btnLuu.Visible = false;
            dtpPhieuNhap.Enabled=false;
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
            pnNhap.Visible = false;
            btnThemNhap.Enabled = true;
            btnSuaNhap.Enabled = true;
            btnXoaNhap.Enabled = true;
            dtpPhieuNhap.Enabled = true;
            txtMaMT.Text = "";
            txtSoLuong.Text = "";
            txtGhiChu.Text = "";
        }

        private void dtgPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

            int numrow;
            bool checkClickdtg = false;
        private void dtgPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            if(CheckClickBtnSua && numrow >=0)
            {
             txtMaCT.Enabled = true;
             txtThue.Enabled = true;
            txtMaPhieuNhap.Text= dtgPhieuNhap.Rows[numrow].Cells[0].Value.ToString();
            txtMaCT.Text= dtgPhieuNhap.Rows[numrow].Cells[2].Value.ToString();
            txtThue.Text= dtgPhieuNhap.Rows[numrow].Cells[4].Value.ToString();
            txtMaMT.Text= dtgPhieuNhap.Rows[numrow].Cells[5].Value.ToString();
            txtSoLuong.Text= dtgPhieuNhap.Rows[numrow].Cells[7].Value.ToString();
            txtMaNV.Text= dtgPhieuNhap.Rows[numrow].Cells[10].Value.ToString();
            txtGhiChu.Text= dtgPhieuNhap.Rows[numrow].Cells[11].Value.ToString();
            }
            checkClickdtg = true; 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int songuyen = 0;
            errorProvider1.Clear();
            clear_whitespace();
            if (txtMaCT.Text == "")
            {
                ErrorWarning(errorProvider1,txtMaCT, "Chưa nhập mã công ty");
            }
            else if (txtMaMT.Text == "")
            {
                ErrorWarning(errorProvider1,txtMaMT, "Chưa nhập mã máy tính");
            }
            else if (txtThue.Text == "")
            {
                ErrorWarning(errorProvider1,txtThue, "Chưa nhập mã số thuế");
            }
            else if (txtSoLuong.Text == "")
            {
                ErrorWarning(errorProvider1,txtSoLuong, "Chưa nhập số lượng");
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
                SqlCommand cmd3 = new SqlCommand("select MaCT from dbo.CongTy where MaCT = '" + txtMaCT.Text + "'", conn);
                SqlDataReader dta1 = cmd3.ExecuteReader();
                if (!dta1.Read())
                {
                    ErrorWarning(errorProvider1,txtMaCT, "Mã công ty không tồn tại");
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    conn.Open();
                    string QuerrySelectMaCT = "select TenCT from dbo.CongTy where MaCT = '" + txtMaCT.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelectMaCT, conn);
                    object GetTenCT = cmd2.ExecuteScalar();
                    conn.Close();
                    conn.Open();
                    SqlCommand cmd4 = new SqlCommand("select MaMT from dbo.MayTinh where MaMT ='" + txtMaMT.Text + "'", conn);
                    SqlDataReader dta2 = cmd4.ExecuteReader();
                    if (!dta2.Read())
                    {
                        ErrorWarning(errorProvider1,txtMaMT, "Mã máy tính không tồn tại");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        string QuerrySelectDonGia = "select DonGia from dbo.MayTinh where MaMT = '" + txtMaMT.Text + "'";
                        SqlCommand cmd5 = new SqlCommand(QuerrySelectDonGia, conn);
                        object GetDonGia = cmd5.ExecuteScalar();
                        string QuerrySelectTenMT = "select TenMT from dbo.MayTinh where MaMT = '" + txtMaMT.Text + "'";
                        SqlCommand cmd6 = new SqlCommand(QuerrySelectTenMT, conn);
                        object GetTenMT = cmd6.ExecuteScalar();
                        conn.Close();
                        string TenMT = Convert.ToString(GetTenMT);
                        string TenCT = Convert.ToString(GetTenCT);
                        double DonGia = Convert.ToDouble(GetDonGia);
                        double ThanhTien = DonGia * int.Parse(txtSoLuong.Text);
                        string QuerryUpdate = " Update dbo.PhieuNhap set TenMT = N'"+TenMT +"',DonGia = " +DonGia +",ThanhTien = "+ThanhTien+
                     ",MaMT = '" + txtMaMT.Text + "',SoLuong = " + int.Parse(txtSoLuong.Text) + ", MaNV = '"
                     + txtMaNV.Text + "', GhiChu = N'" + txtGhiChu.Text + "' where MaPhieuNhap = '" + txtMaPhieuNhap.Text + "' and MaCT = '" + dtgPhieuNhap.Rows[numrow].Cells[2].Value.ToString() +
                     "' and Thue = '" + dtgPhieuNhap.Rows[numrow].Cells[4].Value.ToString() + "' and MaMT = '" + dtgPhieuNhap.Rows[numrow].Cells[5].Value.ToString() + "' and SoLuong = '" + dtgPhieuNhap.Rows[numrow].Cells[7].Value.ToString() + "' and MaNV = '"
                     + dtgPhieuNhap.Rows[numrow].Cells[10].Value.ToString() + "' and GhiChu = N'" + dtgPhieuNhap.Rows[numrow].Cells[11].Value.ToString() + "';";
                        string QuerryUpdateCT = "Update dbo.PhieuNhap set MaCT = '" + txtMaCT.Text + "', TenCT =N'"+ TenCT +"' where MaPhieuNhap = '"+txtMaPhieuNhap.Text+"'";
                        string QuerryUpdateThue = "Update dbo.PhieuNhap set Thue = '"+txtThue.Text + "' where MaPhieuNhap = '" + txtMaPhieuNhap.Text + "'";
                        conn.Open();
                        SqlCommand cmd8 = new SqlCommand(QuerryUpdateThue, conn);
                        cmd8.ExecuteNonQuery();
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(QuerryUpdate, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        conn.Open();
                        SqlCommand cmd7 = new SqlCommand(QuerryUpdateCT, conn);
                        cmd7.ExecuteNonQuery();
                        conn.Close();
                        string QuerrySelect = "select *  from dbo.PhieuNhap where MaPhieuNhap = '" + txtMaPhieuNhap.Text + "'";
                        conn.Open();
                        SqlCommand cmd1 = new SqlCommand(QuerrySelect, conn);
                        SqlDataAdapter da = new SqlDataAdapter(cmd1);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dtgPhieuNhap.DataSource = dt;
                        conn.Close();
                        txtMaCT.Enabled = false;
                        txtThue.Enabled = false;
                    }
                }
            }
        }
        private void btnXoaNhap_Click(object sender, EventArgs e)
        {
            if(checkClickdtg)
            {
                
                checkClickdtg = false;
                string QuerryDelete = "delete from dbo.PhieuNhap where MaPhieuNhap = '" + txtMaPhieuNhap.Text + "' and MaCT = '" + dtgPhieuNhap.Rows[numrow].Cells[2].Value.ToString() +
                     "' and Thue = '" + dtgPhieuNhap.Rows[numrow].Cells[4].Value.ToString() + "' and MaMT = '" + dtgPhieuNhap.Rows[numrow].Cells[5].Value.ToString() + "' and SoLuong = '" + dtgPhieuNhap.Rows[numrow].Cells[7].Value.ToString() + "' and MaNV = '"
                     + dtgPhieuNhap.Rows[numrow].Cells[10].Value.ToString() + "' and GhiChu = N'" + dtgPhieuNhap.Rows[numrow].Cells[11].Value.ToString() + "';";
                conn.Open();
                SqlCommand cmd = new SqlCommand(QuerryDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                string QuerrySelect = "select *  from dbo.PhieuNhap where MaPhieuNhap = '" + txtMaPhieuNhap.Text + "'";
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(QuerrySelect,conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgPhieuNhap.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("Chưa chọn dòng để xoá","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            } 
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void dtpPhieuNhap_ValueChanged(object sender, EventArgs e)
        {
            dtgPhieuNhap.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            string QuerrySelect = "select * from dbo.PhieuNhap where NgayLamPhieu = '" + dtpPhieuNhap.Text + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(QuerrySelect, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgPhieuNhap.DataSource = dt;
            conn.Close();
                btnThemNhap.Enabled = false;
                btnSuaNhap.Enabled = false;
                btnXoaNhap.Enabled = false;
                btnInNhap.Enabled = false;
        }

        private void btnInNhap_Click(object sender, EventArgs e)
        {
            if (dtgPhieuNhap.DataSource != null)
            {
                    double TongSoTien = 0;
                    var Today = DateTime.Now;
                    Document PhieuNhap = new Document(@"TemplateWord\\Mau_Phieu_Nhap.doc");

                    conn.Open();
                    string QuerrySelectDiaChi = "select DiaChiCT from dbo.CongTy where MaCT = '" + dtgPhieuNhap.Rows[0].Cells[2].Value.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(QuerrySelectDiaChi, conn);
                    object GetDiaChi = cmd.ExecuteScalar();
                    string DiaChi = Convert.ToString(GetDiaChi);
                    conn.Close();
                    conn.Open();
                    string QuerrySelectDienThoai = "select DienThoaiCT from dbo.CongTy where MaCT = '" + dtgPhieuNhap.Rows[0].Cells[2].Value.ToString() + "'";
                    SqlCommand cmd1 = new SqlCommand(QuerrySelectDienThoai, conn);
                    object GetDienThoai = cmd1.ExecuteScalar();
                    string DienThoai = Convert.ToString(GetDienThoai);
                    conn.Close();
                    conn.Open();
                    string QuerrySelectBank = "select BANK from dbo.CongTy where MaCT = '" + dtgPhieuNhap.Rows[0].Cells[2].Value.ToString() + "'";
                    SqlCommand cmd2 = new SqlCommand(QuerrySelectBank, conn);
                    object GetBank = cmd2.ExecuteScalar();
                    string Bank = Convert.ToString(GetBank);
                    conn.Close();
                    conn.Open();
                    string QuerrySelectTenNV = "select TenNV from dbo.NhanVien where MaNV = '" + dtgPhieuNhap.Rows[0].Cells[10].Value.ToString() + "'";
                    SqlCommand cmd3 = new SqlCommand(QuerrySelectTenNV, conn);
                    object GetTenNV = cmd3.ExecuteScalar();
                    string TenNV = Convert.ToString(GetTenNV);
                    conn.Close();
                    PhieuNhap.MailMerge.Execute(new[] { "Ngay_Thang_Nam" }, new[] { string.Format("Nam Định , ngày {0} tháng {1} năm {2}", Today.Day, Today.Month, Today.Year) });
                    PhieuNhap.MailMerge.Execute(new[] { "Ma_Nhap" }, new[] { dtgPhieuNhap.Rows[0].Cells[0].Value.ToString() });
                    PhieuNhap.MailMerge.Execute(new[] { "Ma_Cong_Ty" }, new[] { dtgPhieuNhap.Rows[0].Cells[2].Value.ToString() });
                    PhieuNhap.MailMerge.Execute(new[] { "Ten_Cong_Ty" }, new[] { dtgPhieuNhap.Rows[0].Cells[3].Value.ToString() });
                    PhieuNhap.MailMerge.Execute(new[] { "THUE" }, new[] { dtgPhieuNhap.Rows[0].Cells[4].Value.ToString() });
                    PhieuNhap.MailMerge.Execute(new[] { "Dia_Chi" }, new[] { DiaChi });
                    PhieuNhap.MailMerge.Execute(new[] { "SDT" }, new[] { DienThoai });
                    PhieuNhap.MailMerge.Execute(new[] { "BANK" }, new[] { Bank });
                    PhieuNhap.MailMerge.Execute(new[] { "Ma_Nhan_Vien" }, new[] { dtgPhieuNhap.Rows[0].Cells[10].Value.ToString() });
                    PhieuNhap.MailMerge.Execute(new[] { "Ten_Nhan_Vien" }, new[] { TenNV });

                    int count = dtgPhieuNhap.Rows.Count;
                    Table ThongTin = PhieuNhap.GetChild(NodeType.Table, 0, true) as Table;
                    int row = 1;
                    ThongTin.InsertRows(row, row, count - 1);
                    for (int i = 0; i < count; i++)
                    {
                        ThongTin.PutValue(row, 0, dtgPhieuNhap.Rows[i].Cells[5].Value.ToString());
                        ThongTin.PutValue(row, 1, dtgPhieuNhap.Rows[i].Cells[6].Value.ToString());
                        ThongTin.PutValue(row, 2, dtgPhieuNhap.Rows[i].Cells[7].Value.ToString());
                        ThongTin.PutValue(row, 3, dtgPhieuNhap.Rows[i].Cells[8].Value.ToString());
                        ThongTin.PutValue(row, 4, dtgPhieuNhap.Rows[i].Cells[9].Value.ToString());
                        ThongTin.PutValue(row, 5, dtgPhieuNhap.Rows[i].Cells[11].Value.ToString());
                        TongSoTien += double.Parse(dtgPhieuNhap.Rows[i].Cells[9].Value.ToString());
                        row++;
                    }
                    PhieuNhap.MailMerge.Execute(new[] { "Tong_So_Tien" }, new[] { TongSoTien.ToString() });
                    PhieuNhap.SaveAndOpenFile("PhieuNhap.doc");
                }
            }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            FormNhap_Load(sender, e);
            check = false;
            txtMaPhieuNhap.Enabled = true;
            dtgPhieuNhap.DataSource = null;
        }
    }
}
