using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }
        private void cbPicture_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbPicture.SelectedIndex;
            switch(index)
            {
                case 0:
                    ptbTrangChu.Image = Properties.Resources.hrMdhw3flV;
                    break;
                case 1:
                    ptbTrangChu.Image = Properties.Resources.index_0;
                    break;  
                case 2:
                    ptbTrangChu.Image = Properties.Resources.index_2;
                    break;
                case 3:
                    ptbTrangChu.Image = Properties.Resources.index_3;
                    break;
                case 4:
                    ptbTrangChu.Image = Properties.Resources.index_4;
                    break;
            }
        }

        private void ptbTrangChu_Click(object sender, EventArgs e)
        {

        }
    }
}
