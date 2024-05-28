using Aspose.Words.Fields;
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
        bool CheckClickBtnSua = false;
        Functions f = new Functions();
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
        public void CheckInputTxt()
        {
            double sothuc = 0.0;
            int songuyen = 0;
            
            if (txtMaMayTinh.Text == "")    
            {
                f.ErrorWarning(errorProvider1, txtMaMayTinh, "Chưa nhập mã máy tính");
                checkError = true;
            }
            else if (txtTenMayTinh.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtTenMayTinh, "Chưa nhập tên máy tính");
                checkError = true;
            }
            else if (txtTenHSX.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtTenHSX, "Chưa nhập tên hãng sản xuất");
                checkError = true;
            }
            else if (cboLoaiHang.Text == "none")
            {
                errorProvider1.SetError(cboLoaiHang, "Chưa chọn loại hàng");
                checkError = true;
            }
            else if (txtNamRaMat.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtNamRaMat, "Chưa nhập năm ra mắt");
                checkError = true;

            }
            else if (int.TryParse(txtNamRaMat.Text, out songuyen) == false || int.Parse(txtNamRaMat.Text) < 2005)
            {
                f.ErrorWarning(errorProvider1, txtNamRaMat, "Sai định dạng năm ra mắt");
                checkError = true;

            }
            else if (txtBaoHanh.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtBaoHanh, "Chưa nhập bảo hành");
                checkError = true;

            }
            else if (int.TryParse(txtBaoHanh.Text, out songuyen) == false || int.Parse(txtBaoHanh.Text) < 0)
            {
                f.ErrorWarning(errorProvider1, txtBaoHanh, "Sai định dạng tháng bảo hành");
                checkError = true;

            }
            else if (txtCPU.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtCPU, "Chưa nhập thông số CPU");
                checkError = true;

            }
            else if (cboRAM1.Text == "none" && cboRAM2.Text == "none")
            {
                errorProvider1.SetError(cboRAM1, "Chưa chọn thông số RAM");
                checkError = true;
            }
            else if (txtCard.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtCard, "Chưa nhập thông số Card");
                checkError = true;

            }
            else if (txtManHinh.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtManHinh, "Chưa nhập thông số màn hình");
                checkError = true;

            }
            else if (txtDungLuong.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtDungLuong, "Chưa nhập dung lượng");
                checkError = true;

            }
            else if (txtTrongLuong.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtTrongLuong, "Chưa nhập trọng lượng");
                checkError = true;

            }
            else if (double.TryParse(txtTrongLuong.Text, out sothuc) == false || double.Parse(txtTrongLuong.Text) < 0)
            {
                f.ErrorWarning(errorProvider1, txtTrongLuong, "Sai định dạng trọng lượng");
                checkError = true;

            }
            else if (cboTinhTrang.Text == "none")
            {
                errorProvider1.SetError(cboTinhTrang, "Chưa chọn tình trạng");
                checkError = true;
            }
            else if (txtDonGia.Text == "")
            {
                f.ErrorWarning(errorProvider1, txtDonGia, "Chưa nhập đơn giá");
                checkError = true;

            }
            else if (double.TryParse(txtDonGia.Text, out sothuc) == false || double.Parse(txtDonGia.Text) < 0)
            {
                f.ErrorWarning(errorProvider1, txtDonGia, "Sai định dạng đơn giá");
                checkError = true;

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
                if (f.Select_TblCheck("MaMT","MayTinh","MaMT",txtMaMayTinh.Text))
                {
                    f.ErrorWarning(errorProvider1, txtMaMayTinh, "Mã máy tính đã tồn tại");
                }
                else
                {
                    SqlParameter[] parameterMayTinh = new SqlParameter[]
                    {
                        new SqlParameter("@1",txtMaMayTinh.Text),
                        new SqlParameter("@2",txtTenMayTinh.Text),
                        new SqlParameter("@3",txtTenHSX.Text),
                        new SqlParameter("@4",cboLoaiHang.Text),
                        new SqlParameter("@5",int.Parse(txtBaoHanh.Text)),
                        new SqlParameter("@6",int.Parse(txtNamRaMat.Text)),
                        new SqlParameter("@7",txtCPU.Text),
                        new SqlParameter("@8",cboRAM1.Text),
                        new SqlParameter("@9",cboRAM2.Text),
                        new SqlParameter("@10",txtManHinh.Text),
                        new SqlParameter("@11",txtDungLuong.Text),
                        new SqlParameter("@12",double.Parse(txtTrongLuong.Text)),
                        new SqlParameter("@13",double.Parse(txtDonGia.Text)),
                        new SqlParameter("@14",txtGhiChu.Text),
                        new SqlParameter("@15",txtCard.Text),
                        new SqlParameter("@16",cboTinhTrang.Text)
                    };

                    f.InsertDataIntoTable("MayTinh(MaMT,TenMT,TenHSX,LoaiHang,BaoHanh,NamRaMat,CPU,RAM1,RAM2,ManHinh,DungLuong,TrongLuong,DonGia,GhiChu,Card,TinhTrang)", parameterMayTinh);
                    ResetTextBox();
                    dtgMayTinh.DataSource = f.ReadData("MayTinh","1","1");
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
                if (f.Select_TblCheck("MaMT","MayTinh","MaMT",txtMaMayTinh.Text) && txtMaMayTinh.Text != dtgMayTinh.Rows[numrow].Cells[0].Value.ToString())
                {
                    f.ErrorWarning(errorProvider1, txtMaMayTinh, "Mã máy tính đã tồn tại");
                }
                else
                {
                        string[] field = { "MaMT", "TenMT", "TenHSX", "LoaiHang", "BaoHanh", "NamRaMat", "CPU", "RAM1", "RAM2", "ManHinh", "DungLuong", "TrongLuong", "DonGia", "GhiChu", "Card", "TinhTrang" };
                        SqlParameter[] parameter = new SqlParameter[]
                        {
                            new SqlParameter("@1",txtMaMayTinh.Text),
                            new SqlParameter("@2",txtTenMayTinh.Text),
                            new SqlParameter("@3",txtTenHSX.Text),
                            new SqlParameter("@4",cboLoaiHang.Text),
                            new SqlParameter("@5",int.Parse(txtBaoHanh.Text)),
                            new SqlParameter("@6",int.Parse(txtNamRaMat.Text)),
                            new SqlParameter("@7",txtCPU.Text),
                            new SqlParameter("@8",cboRAM1.Text),
                            new SqlParameter("@9",cboRAM2.Text),
                            new SqlParameter("@10",txtManHinh.Text),
                            new SqlParameter("@11",txtDungLuong.Text),
                            new SqlParameter("@12",double.Parse(txtTrongLuong.Text)),
                            new SqlParameter("@13",double.Parse(txtDonGia.Text)),
                            new SqlParameter("@14",txtGhiChu.Text),
                            new SqlParameter("@15",txtCard.Text),
                            new SqlParameter("@16",cboTinhTrang.Text)
                        };
                        string[] fieldCondition = {"MaMT"};
                        SqlParameter[] parameterConditon = new SqlParameter[]
                        {
                            new SqlParameter("@17",dtgMayTinh.Rows[numrow].Cells[0].Value.ToString())
                        };

                        f.UpdateDataTable("MayTinh", field, parameter, fieldCondition, parameterConditon);
                    dtgMayTinh.DataSource = f.ReadData("MayTinh", "1", "1");
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
            TextBox[] txt = { txtMaMayTinh, txtTenMayTinh, txtTenHSX, txtNamRaMat, txtBaoHanh, txtCard, txtCPU, txtManHinh, txtDungLuong, txtTrongLuong, txtDonGia, txtGhiChu};
            f.clear_whitespace(txt);

        }
        private void FormMayTinh_Load(object sender, EventArgs e)
        {
            pnMayTinh.Visible = false;
            dtgMayTinh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgMayTinh.DataSource = f.ReadData("MayTinh", "1", "1");
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
                string[] fieldCondition = { "MaMT" };
                SqlParameter[] parameterCondition = new SqlParameter[]
                {
                    new SqlParameter("@1",dtgMayTinh.Rows[numrow].Cells[0].Value.ToString())
                };
                f.DeleteDataTable("MayTinh", fieldCondition, parameterCondition);
                dtgMayTinh.DataSource = f.ReadData("MayTinh", "1", "1");
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
            string[] fieldCondition = { "MaMT", "TenMT", "TenHSX", "LoaiHang", "BaoHanh", "NamRaMat", "CPU", "RAM1", "RAM2", "ManHinh", "DungLuong", "TrongLuong", "DonGia", "GhiChu", "TinhTrang", "Card" };
            SqlParameter[] parameterCondition = new SqlParameter[]
            {
                new SqlParameter("@1","%" + txtTimKiem.Text+ "%")
            };
            dtgMayTinh.DataSource = f.SelectCondition("MayTinh",fieldCondition,parameterCondition);
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
        private void cbLietKe_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int a = cbLietKe.SelectedIndex;
            switch (a)
            {
                case 0:
                    FormMayTinh_Load(sender, e);
                    break;
                case 1:
                    dtgMayTinh.DataSource = f.Select("select * from dbo.MayTinh where DonGia < 10000000");
                    break;
                case 2:
                    dtgMayTinh.DataSource = f.Select("select * from dbo.MayTinh where DonGia between 10000000 and 15000000");
                    break;
                case 3:
                    dtgMayTinh.DataSource = f.Select("select * from dbo.MayTinh where DonGia between 15000000 and 20000000");
                    break;
                case 4:
                    dtgMayTinh.DataSource = f.Select("select * from dbo.MayTinh where DonGia between 20000000 and 30000000");
                    break;
                case 5:
                    dtgMayTinh.DataSource = f.Select("select * from dbo.MayTinh where DonGia > 30000000");
                    break;
            }

        }
    }
}
