namespace DoAn
{
    partial class FormNhap
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhap));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInNhap = new DoAn.VBButton();
            this.btnXoaNhap = new DoAn.VBButton();
            this.btnSuaNhap = new DoAn.VBButton();
            this.btnThemNhap = new DoAn.VBButton();
            this.pnNhap = new System.Windows.Forms.Panel();
            this.lblDatePhieuNhap = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaMT = new System.Windows.Forms.TextBox();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tst = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgPhieuNhap = new System.Windows.Forms.DataGridView();
            this.clnMPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNLPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpPhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.btnLamMoi = new DoAn.VBButton();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.pnNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInNhap);
            this.panel2.Controls.Add(this.btnXoaNhap);
            this.panel2.Controls.Add(this.btnSuaNhap);
            this.panel2.Controls.Add(this.btnThemNhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 115);
            this.panel2.TabIndex = 3;
            // 
            // btnInNhap
            // 
            this.btnInNhap.BackColor = System.Drawing.Color.SlateBlue;
            this.btnInNhap.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.btnInNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInNhap.BorderRadius = 20;
            this.btnInNhap.BorderSize = 0;
            this.btnInNhap.FlatAppearance.BorderSize = 0;
            this.btnInNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInNhap.ForeColor = System.Drawing.Color.Black;
            this.btnInNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnInNhap.Image")));
            this.btnInNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInNhap.Location = new System.Drawing.Point(939, 14);
            this.btnInNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInNhap.Name = "btnInNhap";
            this.btnInNhap.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnInNhap.Size = new System.Drawing.Size(178, 69);
            this.btnInNhap.TabIndex = 3;
            this.btnInNhap.Text = "In Phiếu";
            this.btnInNhap.TextColor = System.Drawing.Color.Black;
            this.btnInNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInNhap.UseVisualStyleBackColor = false;
            this.btnInNhap.Click += new System.EventHandler(this.btnInNhap_Click);
            // 
            // btnXoaNhap
            // 
            this.btnXoaNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaNhap.BorderRadius = 20;
            this.btnXoaNhap.BorderSize = 0;
            this.btnXoaNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNhap.FlatAppearance.BorderSize = 0;
            this.btnXoaNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnXoaNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXoaNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhap.ForeColor = System.Drawing.Color.Black;
            this.btnXoaNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaNhap.Image")));
            this.btnXoaNhap.Location = new System.Drawing.Point(673, 10);
            this.btnXoaNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaNhap.Name = "btnXoaNhap";
            this.btnXoaNhap.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnXoaNhap.Size = new System.Drawing.Size(178, 69);
            this.btnXoaNhap.TabIndex = 2;
            this.btnXoaNhap.Text = "Xoá";
            this.btnXoaNhap.TextColor = System.Drawing.Color.Black;
            this.btnXoaNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoaNhap.UseVisualStyleBackColor = false;
            this.btnXoaNhap.Click += new System.EventHandler(this.btnXoaNhap_Click);
            // 
            // btnSuaNhap
            // 
            this.btnSuaNhap.BackColor = System.Drawing.Color.Yellow;
            this.btnSuaNhap.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnSuaNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSuaNhap.BorderRadius = 20;
            this.btnSuaNhap.BorderSize = 0;
            this.btnSuaNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNhap.FlatAppearance.BorderSize = 0;
            this.btnSuaNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnSuaNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSuaNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhap.ForeColor = System.Drawing.Color.Black;
            this.btnSuaNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaNhap.Image")));
            this.btnSuaNhap.Location = new System.Drawing.Point(401, 14);
            this.btnSuaNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaNhap.Name = "btnSuaNhap";
            this.btnSuaNhap.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnSuaNhap.Size = new System.Drawing.Size(178, 69);
            this.btnSuaNhap.TabIndex = 1;
            this.btnSuaNhap.Text = "Sửa";
            this.btnSuaNhap.TextColor = System.Drawing.Color.Black;
            this.btnSuaNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSuaNhap.UseVisualStyleBackColor = false;
            this.btnSuaNhap.Click += new System.EventHandler(this.btnSuaNhap_Click);
            // 
            // btnThemNhap
            // 
            this.btnThemNhap.BackColor = System.Drawing.Color.Lime;
            this.btnThemNhap.BackgroundColor = System.Drawing.Color.Lime;
            this.btnThemNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemNhap.BorderRadius = 20;
            this.btnThemNhap.BorderSize = 0;
            this.btnThemNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNhap.FlatAppearance.BorderSize = 0;
            this.btnThemNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnThemNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThemNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNhap.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhap.ForeColor = System.Drawing.Color.Black;
            this.btnThemNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNhap.Image")));
            this.btnThemNhap.Location = new System.Drawing.Point(150, 14);
            this.btnThemNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemNhap.Name = "btnThemNhap";
            this.btnThemNhap.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnThemNhap.Size = new System.Drawing.Size(178, 69);
            this.btnThemNhap.TabIndex = 0;
            this.btnThemNhap.Text = "Thêm";
            this.btnThemNhap.TextColor = System.Drawing.Color.Black;
            this.btnThemNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThemNhap.UseVisualStyleBackColor = false;
            this.btnThemNhap.Click += new System.EventHandler(this.btnThemNhap_Click);
            // 
            // pnNhap
            // 
            this.pnNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnNhap.Controls.Add(this.lblDatePhieuNhap);
            this.pnNhap.Controls.Add(this.btnSua);
            this.pnNhap.Controls.Add(this.btnDong);
            this.pnNhap.Controls.Add(this.btnLuu);
            this.pnNhap.Controls.Add(this.txtGhiChu);
            this.pnNhap.Controls.Add(this.label4);
            this.pnNhap.Controls.Add(this.txtMaMT);
            this.pnNhap.Controls.Add(this.txtMaCT);
            this.pnNhap.Controls.Add(this.txtSoLuong);
            this.pnNhap.Controls.Add(this.txtThue);
            this.pnNhap.Controls.Add(this.txtMaNV);
            this.pnNhap.Controls.Add(this.txtMaPhieuNhap);
            this.pnNhap.Controls.Add(this.label9);
            this.pnNhap.Controls.Add(this.tst);
            this.pnNhap.Controls.Add(this.label3);
            this.pnNhap.Controls.Add(this.label6);
            this.pnNhap.Controls.Add(this.label5);
            this.pnNhap.Controls.Add(this.label2);
            this.pnNhap.Controls.Add(this.label1);
            this.pnNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnNhap.Location = new System.Drawing.Point(1262, 0);
            this.pnNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnNhap.Name = "pnNhap";
            this.pnNhap.Size = new System.Drawing.Size(356, 1080);
            this.pnNhap.TabIndex = 2;
            // 
            // lblDatePhieuNhap
            // 
            this.lblDatePhieuNhap.AutoSize = true;
            this.lblDatePhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePhieuNhap.Location = new System.Drawing.Point(112, 198);
            this.lblDatePhieuNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatePhieuNhap.Name = "lblDatePhieuNhap";
            this.lblDatePhieuNhap.Size = new System.Drawing.Size(139, 29);
            this.lblDatePhieuNhap.TabIndex = 17;
            this.lblDatePhieuNhap.Text = "dd/MM/yyyy";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(0, 943);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(148, 49);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Location = new System.Drawing.Point(212, 943);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(144, 49);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(0, 943);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(148, 49);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(50, 675);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(253, 207);
            this.txtGhiChu.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 645);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ghi Chú:";
            // 
            // txtMaMT
            // 
            this.txtMaMT.Location = new System.Drawing.Point(50, 369);
            this.txtMaMT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaMT.Name = "txtMaMT";
            this.txtMaMT.Size = new System.Drawing.Size(253, 26);
            this.txtMaMT.TabIndex = 3;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(50, 286);
            this.txtMaCT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(253, 26);
            this.txtMaCT.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(225, 474);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(78, 26);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtThue
            // 
            this.txtThue.Location = new System.Drawing.Point(52, 474);
            this.txtThue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(126, 26);
            this.txtThue.TabIndex = 4;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(50, 574);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(253, 26);
            this.txtMaNV.TabIndex = 6;
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(50, 106);
            this.txtMaPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(253, 26);
            this.txtMaPhieuNhap.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 543);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã nhân viên:";
            // 
            // tst
            // 
            this.tst.AutoSize = true;
            this.tst.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst.Location = new System.Drawing.Point(218, 426);
            this.tst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tst.Name = "tst";
            this.tst.Size = new System.Drawing.Size(102, 26);
            this.tst.TabIndex = 0;
            this.tst.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã công ty:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã máy tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 426);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã thuế:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày làm phiếu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã phiếu nhập:";
            // 
            // dtgPhieuNhap
            // 
            this.dtgPhieuNhap.AllowUserToAddRows = false;
            this.dtgPhieuNhap.AllowUserToDeleteRows = false;
            this.dtgPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMPN,
            this.clnNLPN,
            this.clnMCT,
            this.clnTCT,
            this.clnThue,
            this.clnMMT,
            this.clnTMT,
            this.clnSL,
            this.clnDG,
            this.clnTT,
            this.clnMNV,
            this.clnGC});
            this.dtgPhieuNhap.Location = new System.Drawing.Point(36, 125);
            this.dtgPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgPhieuNhap.Name = "dtgPhieuNhap";
            this.dtgPhieuNhap.ReadOnly = true;
            this.dtgPhieuNhap.RowHeadersWidth = 62;
            this.dtgPhieuNhap.Size = new System.Drawing.Size(1191, 885);
            this.dtgPhieuNhap.TabIndex = 4;
            this.dtgPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhieuNhap_CellClick);
            this.dtgPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhieuNhap_CellContentClick);
            // 
            // clnMPN
            // 
            this.clnMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnMPN.DataPropertyName = "MaPhieuNhap";
            this.clnMPN.HeaderText = "Mã phiếu nhập";
            this.clnMPN.MinimumWidth = 8;
            this.clnMPN.Name = "clnMPN";
            this.clnMPN.ReadOnly = true;
            this.clnMPN.Width = 150;
            // 
            // clnNLPN
            // 
            this.clnNLPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnNLPN.DataPropertyName = "NgayLamPhieu";
            this.clnNLPN.HeaderText = "Ngày làm phiếu";
            this.clnNLPN.MinimumWidth = 8;
            this.clnNLPN.Name = "clnNLPN";
            this.clnNLPN.ReadOnly = true;
            this.clnNLPN.Width = 153;
            // 
            // clnMCT
            // 
            this.clnMCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnMCT.DataPropertyName = "MaCT";
            this.clnMCT.HeaderText = "Mã công ty";
            this.clnMCT.MinimumWidth = 8;
            this.clnMCT.Name = "clnMCT";
            this.clnMCT.ReadOnly = true;
            this.clnMCT.Width = 122;
            // 
            // clnTCT
            // 
            this.clnTCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnTCT.DataPropertyName = "TenCT";
            this.clnTCT.HeaderText = "Tên công ty";
            this.clnTCT.MinimumWidth = 8;
            this.clnTCT.Name = "clnTCT";
            this.clnTCT.ReadOnly = true;
            this.clnTCT.Width = 127;
            // 
            // clnThue
            // 
            this.clnThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnThue.DataPropertyName = "Thue";
            this.clnThue.HeaderText = "Thuế (VND)";
            this.clnThue.MinimumWidth = 8;
            this.clnThue.Name = "clnThue";
            this.clnThue.ReadOnly = true;
            this.clnThue.Width = 129;
            // 
            // clnMMT
            // 
            this.clnMMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnMMT.DataPropertyName = "MaMT";
            this.clnMMT.HeaderText = "Mã máy tính";
            this.clnMMT.MinimumWidth = 8;
            this.clnMMT.Name = "clnMMT";
            this.clnMMT.ReadOnly = true;
            this.clnMMT.Width = 130;
            // 
            // clnTMT
            // 
            this.clnTMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnTMT.DataPropertyName = "TenMT";
            this.clnTMT.HeaderText = "Tên máy tính";
            this.clnTMT.MinimumWidth = 8;
            this.clnTMT.Name = "clnTMT";
            this.clnTMT.ReadOnly = true;
            this.clnTMT.Width = 135;
            // 
            // clnSL
            // 
            this.clnSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnSL.DataPropertyName = "SoLuong";
            this.clnSL.HeaderText = "Số lượng";
            this.clnSL.MinimumWidth = 8;
            this.clnSL.Name = "clnSL";
            this.clnSL.ReadOnly = true;
            this.clnSL.Width = 108;
            // 
            // clnDG
            // 
            this.clnDG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnDG.DataPropertyName = "DonGia";
            this.clnDG.HeaderText = "Đơn giá";
            this.clnDG.MinimumWidth = 8;
            this.clnDG.Name = "clnDG";
            this.clnDG.ReadOnly = true;
            // 
            // clnTT
            // 
            this.clnTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnTT.DataPropertyName = "ThanhTien";
            this.clnTT.HeaderText = "Thành tiền";
            this.clnTT.MinimumWidth = 8;
            this.clnTT.Name = "clnTT";
            this.clnTT.ReadOnly = true;
            this.clnTT.Width = 120;
            // 
            // clnMNV
            // 
            this.clnMNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnMNV.DataPropertyName = "MaNV";
            this.clnMNV.HeaderText = "Mã nhân viên";
            this.clnMNV.MinimumWidth = 8;
            this.clnMNV.Name = "clnMNV";
            this.clnMNV.ReadOnly = true;
            this.clnMNV.Width = 139;
            // 
            // clnGC
            // 
            this.clnGC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnGC.DataPropertyName = "GhiChu";
            this.clnGC.HeaderText = "Ghi Chú";
            this.clnGC.MinimumWidth = 8;
            this.clnGC.Name = "clnGC";
            this.clnGC.ReadOnly = true;
            this.clnGC.Width = 103;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // dtpPhieuNhap
            // 
            this.dtpPhieuNhap.CustomFormat = "";
            this.dtpPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPhieuNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPhieuNhap.Location = new System.Drawing.Point(33, 1043);
            this.dtpPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpPhieuNhap.Name = "dtpPhieuNhap";
            this.dtpPhieuNhap.Size = new System.Drawing.Size(154, 30);
            this.dtpPhieuNhap.TabIndex = 5;
            this.dtpPhieuNhap.Value = new System.DateTime(2023, 11, 18, 0, 0, 0, 0);
            this.dtpPhieuNhap.ValueChanged += new System.EventHandler(this.dtpPhieuNhap_ValueChanged);
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNow.Location = new System.Drawing.Point(442, 88);
            this.lblDateNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(139, 29);
            this.lblDateNow.TabIndex = 17;
            this.lblDateNow.Text = "dd/MM/yyyy";
            this.lblDateNow.Visible = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AutoSize = true;
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.BackgroundColor = System.Drawing.Color.White;
            this.btnLamMoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLamMoi.BorderRadius = 13;
            this.btnLamMoi.BorderSize = 0;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(204, 1043);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(30, 30);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.TextColor = System.Drawing.Color.White;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // FormNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 1080);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.lblDateNow);
            this.Controls.Add(this.dtpPhieuNhap);
            this.Controls.Add(this.dtgPhieuNhap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNhap";
            this.Tag = "";
            this.Text = "FormNhap";
            this.Load += new System.EventHandler(this.FormNhap_Load);
            this.panel2.ResumeLayout(false);
            this.pnNhap.ResumeLayout(false);
            this.pnNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VBButton btnSuaNhap;
        private VBButton btnXoaNhap;
        private VBButton btnThemNhap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnNhap;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMT;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgPhieuNhap;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblDatePhieuNhap;
        private System.Windows.Forms.DateTimePicker dtpPhieuNhap;
        private System.Windows.Forms.Label lblDateNow;
        private VBButton btnInNhap;
        private VBButton btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNLPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGC;
    }
}