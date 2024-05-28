namespace DoAn
{
    partial class FormBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            this.panelbtn = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.PictureBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.btnTrangChu = new DoAn.VBButton();
            this.btnNhanVien = new DoAn.VBButton();
            this.btnKho = new DoAn.VBButton();
            this.btnHoaDon = new DoAn.VBButton();
            this.btnMayTinh = new DoAn.VBButton();
            this.btnKhachHang = new DoAn.VBButton();
            this.btnNhaCungCap = new DoAn.VBButton();
            this.btnNhap = new DoAn.VBButton();
            this.btnXuat = new DoAn.VBButton();
            this.panelbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbtn
            // 
            this.panelbtn.BackColor = System.Drawing.Color.Aqua;
            this.panelbtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelbtn.Controls.Add(this.btnTrangChu);
            this.panelbtn.Controls.Add(this.btnNhanVien);
            this.panelbtn.Controls.Add(this.label1);
            this.panelbtn.Controls.Add(this.lblChucVu);
            this.panelbtn.Controls.Add(this.btnKho);
            this.panelbtn.Controls.Add(this.btnHoaDon);
            this.panelbtn.Controls.Add(this.lblTenNV);
            this.panelbtn.Controls.Add(this.btnMayTinh);
            this.panelbtn.Controls.Add(this.btnLogOut);
            this.panelbtn.Controls.Add(this.btnKhachHang);
            this.panelbtn.Controls.Add(this.btnNhaCungCap);
            this.panelbtn.Controls.Add(this.btnNhap);
            this.panelbtn.Controls.Add(this.btnXuat);
            this.panelbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelbtn.Location = new System.Drawing.Point(0, 0);
            this.panelbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(302, 1080);
            this.panelbtn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-112, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(105, 0, 105, 0);
            this.label1.Size = new System.Drawing.Size(490, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "_________________________________________________________________________________" +
    "___________";
            // 
            // lblChucVu
            // 
            this.lblChucVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChucVu.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChucVu.Location = new System.Drawing.Point(4, 155);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(288, 53);
            this.lblChucVu.TabIndex = 3;
            this.lblChucVu.Text = "Chức Vụ";
            // 
            // lblTenNV
            // 
            this.lblTenNV.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(3, 77);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(289, 56);
            this.lblTenNV.TabIndex = 2;
            this.lblTenNV.Text = "Tên Nhân Viên";
            this.lblTenNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(-2, -3);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(51, 75);
            this.btnLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(302, 0);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1618, 1080);
            this.mainpanel.TabIndex = 2;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Aqua;
            this.btnTrangChu.BackgroundColor = System.Drawing.Color.Aqua;
            this.btnTrangChu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTrangChu.BorderRadius = 20;
            this.btnTrangChu.BorderSize = 0;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangChu.Image")));
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(22, 252);
            this.btnTrangChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(250, 62);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.TextColor = System.Drawing.Color.Black;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Aqua;
            this.btnNhanVien.BackgroundColor = System.Drawing.Color.Aqua;
            this.btnNhanVien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNhanVien.BorderRadius = 20;
            this.btnNhanVien.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(18, 911);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(250, 62);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextColor = System.Drawing.Color.Black;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnKho
            // 
            this.btnKho.BackColor = System.Drawing.Color.Aqua;
            this.btnKho.BackgroundColor = System.Drawing.Color.Aqua;
            this.btnKho.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKho.BorderRadius = 20;
            this.btnKho.BorderSize = 0;
            this.btnKho.FlatAppearance.BorderSize = 0;
            this.btnKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKho.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKho.ForeColor = System.Drawing.Color.Black;
            this.btnKho.Image = ((System.Drawing.Image)(resources.GetObject("btnKho.Image")));
            this.btnKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKho.Location = new System.Drawing.Point(22, 1005);
            this.btnKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKho.Name = "btnKho";
            this.btnKho.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnKho.Size = new System.Drawing.Size(250, 62);
            this.btnKho.TabIndex = 0;
            this.btnKho.Text = "Kho";
            this.btnKho.TextColor = System.Drawing.Color.Black;
            this.btnKho.UseVisualStyleBackColor = false;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.Aqua;
            this.btnHoaDon.BackgroundColor = System.Drawing.Color.Aqua;
            this.btnHoaDon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHoaDon.BorderRadius = 20;
            this.btnHoaDon.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(22, 814);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(250, 62);
            this.btnHoaDon.TabIndex = 0;
            this.btnHoaDon.Text = "Hoá Đơn";
            this.btnHoaDon.TextColor = System.Drawing.Color.Black;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnMayTinh
            // 
            this.btnMayTinh.BackColor = System.Drawing.Color.Aqua;
            this.btnMayTinh.BackgroundColor = System.Drawing.Color.Aqua;
            this.btnMayTinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMayTinh.BorderRadius = 20;
            this.btnMayTinh.BorderSize = 0;
            this.btnMayTinh.FlatAppearance.BorderSize = 0;
            this.btnMayTinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnMayTinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMayTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMayTinh.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMayTinh.ForeColor = System.Drawing.Color.Black;
            this.btnMayTinh.Image = ((System.Drawing.Image)(resources.GetObject("btnMayTinh.Image")));
            this.btnMayTinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMayTinh.Location = new System.Drawing.Point(22, 528);
            this.btnMayTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMayTinh.Name = "btnMayTinh";
            this.btnMayTinh.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnMayTinh.Size = new System.Drawing.Size(250, 62);
            this.btnMayTinh.TabIndex = 0;
            this.btnMayTinh.Text = "Máy Tính";
            this.btnMayTinh.TextColor = System.Drawing.Color.Black;
            this.btnMayTinh.UseVisualStyleBackColor = false;
            this.btnMayTinh.Click += new System.EventHandler(this.btnMayTinh_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Aqua;
            this.btnKhachHang.BackgroundColor = System.Drawing.Color.Aqua;
            this.btnKhachHang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnKhachHang.BorderRadius = 20;
            this.btnKhachHang.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(22, 718);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(250, 62);
            this.btnKhachHang.TabIndex = 0;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.TextColor = System.Drawing.Color.Black;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhaCungCap
            // 
            this.btnNhaCungCap.BackColor = System.Drawing.Color.Aqua;
            this.btnNhaCungCap.BackgroundColor = System.Drawing.Color.Aqua;
            this.btnNhaCungCap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNhaCungCap.BorderRadius = 20;
            this.btnNhaCungCap.BorderSize = 0;
            this.btnNhaCungCap.FlatAppearance.BorderSize = 0;
            this.btnNhaCungCap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnNhaCungCap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaCungCap.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaCungCap.ForeColor = System.Drawing.Color.Black;
            this.btnNhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("btnNhaCungCap.Image")));
            this.btnNhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaCungCap.Location = new System.Drawing.Point(22, 623);
            this.btnNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNhaCungCap.Size = new System.Drawing.Size(250, 62);
            this.btnNhaCungCap.TabIndex = 0;
            this.btnNhaCungCap.Text = "Nhà Cung Cấp";
            this.btnNhaCungCap.TextColor = System.Drawing.Color.Black;
            this.btnNhaCungCap.UseVisualStyleBackColor = false;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.Aqua;
            this.btnNhap.BackgroundColor = System.Drawing.Color.Aqua;
            this.btnNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNhap.BorderRadius = 20;
            this.btnNhap.BorderSize = 0;
            this.btnNhap.FlatAppearance.BorderSize = 0;
            this.btnNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhap.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.Black;
            this.btnNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnNhap.Image")));
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(22, 337);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNhap.Size = new System.Drawing.Size(250, 62);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.TextColor = System.Drawing.Color.Black;
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.Aqua;
            this.btnXuat.BackgroundColor = System.Drawing.Color.Aqua;
            this.btnXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXuat.BorderRadius = 20;
            this.btnXuat.BorderSize = 0;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.Black;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(22, 432);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnXuat.Size = new System.Drawing.Size(250, 62);
            this.btnXuat.TabIndex = 0;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.TextColor = System.Drawing.Color.Black;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelbtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.panelbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelbtn;
        private System.Windows.Forms.Panel mainpanel;
        private VBButton btnKho;
        private VBButton btnNhap;
        private VBButton btnXuat;
        private VBButton btnNhaCungCap;
        private VBButton btnKhachHang;
        private VBButton btnMayTinh;
        private VBButton btnHoaDon;
        private System.Windows.Forms.PictureBox btnLogOut;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblChucVu;
        private VBButton btnNhanVien;
        private VBButton btnTrangChu;
        private System.Windows.Forms.Label label1;
    }
}