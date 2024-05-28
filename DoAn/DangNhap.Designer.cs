namespace DoAn
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblQuenMatKhau = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.ptbShow = new System.Windows.Forms.PictureBox();
            this.ptbHide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHide)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(143, 254);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(209, 33);
            this.txtMatKhau.TabIndex = 3;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(143, 201);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(209, 33);
            this.txtTaiKhoan.TabIndex = 6;
            // 
            // lblQuenMatKhau
            // 
            this.lblQuenMatKhau.AutoSize = true;
            this.lblQuenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuenMatKhau.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMatKhau.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQuenMatKhau.Location = new System.Drawing.Point(301, 302);
            this.lblQuenMatKhau.Name = "lblQuenMatKhau";
            this.lblQuenMatKhau.Size = new System.Drawing.Size(78, 22);
            this.lblQuenMatKhau.TabIndex = 8;
            this.lblQuenMatKhau.Text = "Hỗ Trợ?";
            this.lblQuenMatKhau.Click += new System.EventHandler(this.lblQuenMatKhau_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(165, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(169, 156);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(93, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDangNhap.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtnDangNhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnDangNhap.Location = new System.Drawing.Point(199, 325);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(96, 30);
            this.BtnDangNhap.TabIndex = 12;
            this.BtnDangNhap.Text = "Đăng Nhập";
            this.BtnDangNhap.UseVisualStyleBackColor = false;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // ptbShow
            // 
            this.ptbShow.Image = ((System.Drawing.Image)(resources.GetObject("ptbShow.Image")));
            this.ptbShow.Location = new System.Drawing.Point(358, 254);
            this.ptbShow.Name = "ptbShow";
            this.ptbShow.Size = new System.Drawing.Size(29, 24);
            this.ptbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbShow.TabIndex = 14;
            this.ptbShow.TabStop = false;
            this.ptbShow.Click += new System.EventHandler(this.ptbShow_Click);
            // 
            // ptbHide
            // 
            this.ptbHide.Image = ((System.Drawing.Image)(resources.GetObject("ptbHide.Image")));
            this.ptbHide.Location = new System.Drawing.Point(358, 254);
            this.ptbHide.Name = "ptbHide";
            this.ptbHide.Size = new System.Drawing.Size(29, 24);
            this.ptbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHide.TabIndex = 14;
            this.ptbHide.TabStop = false;
            this.ptbHide.Click += new System.EventHandler(this.ptbHide_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(450, 366);
            this.Controls.Add(this.ptbHide);
            this.Controls.Add(this.ptbShow);
            this.Controls.Add(this.BtnDangNhap);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblQuenMatKhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMatKhau);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblQuenMatKhau;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnDangNhap;
        private System.Windows.Forms.PictureBox ptbShow;
        private System.Windows.Forms.PictureBox ptbHide;
        private System.Windows.Forms.TextBox txtMatKhau;
    }
}

