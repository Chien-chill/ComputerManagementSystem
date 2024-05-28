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
       Functions f = new Functions();
        public FormKho()
        {
            InitializeComponent();
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            btnTimKiemKho.Enabled = true;
            dtgKho.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgKho.DataSource = f.ReadData("Kho","1","1");
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
            string[] fieldCondition = { "MaMT", "TenMT", "MaCT", "TenCT", "SoLuongTon", "NgayNhap" };
            SqlParameter[] parameterCondition = new SqlParameter[]
            {
                new SqlParameter("@1","%" +txtTimKiem.Text + "%")
            };
            dtgKho.DataSource = null;
            dtgKho.DataSource = f.SelectCondition("Kho",fieldCondition,parameterCondition);
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

    }
}
