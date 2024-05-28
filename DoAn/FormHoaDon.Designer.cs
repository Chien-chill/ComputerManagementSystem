namespace DoAn
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaMT = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHD = new System.Windows.Forms.DateTimePicker();
            this.tst = new System.Windows.Forms.Label();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDateHD = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtgHD = new System.Windows.Forms.DataGridView();
            this.clnMPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNLPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnHD = new System.Windows.Forms.Panel();
            this.txtDiemTT = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new DoAn.VBButton();
            this.btnBaoCao = new DoAn.VBButton();
            this.btnInPhieuHD = new DoAn.VBButton();
            this.btnXoaHD = new DoAn.VBButton();
            this.btnSuaHD = new DoAn.VBButton();
            this.btnThemHD = new DoAn.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHD)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(0, 943);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(148, 49);
            this.btnSua.TabIndex = 15;
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
            this.btnDong.TabIndex = 16;
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
            this.txtGhiChu.Location = new System.Drawing.Point(50, 675);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(253, 207);
            this.txtGhiChu.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 645);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ghi Chú:";
            // 
            // txtMaMT
            // 
            this.txtMaMT.Location = new System.Drawing.Point(50, 369);
            this.txtMaMT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaMT.Name = "txtMaMT";
            this.txtMaMT.Size = new System.Drawing.Size(253, 26);
            this.txtMaMT.TabIndex = 10;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(50, 286);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(253, 26);
            this.txtMaKH.TabIndex = 9;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(225, 474);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(78, 26);
            this.txtSoLuong.TabIndex = 12;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(50, 574);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(253, 26);
            this.txtMaNV.TabIndex = 13;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(50, 106);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(253, 26);
            this.txtMaHD.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 543);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 26);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Mã máy tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 426);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điểm thân thiết:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày bán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn:";
            // 
            // dtpHD
            // 
            this.dtpHD.CustomFormat = "";
            this.dtpHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHD.Location = new System.Drawing.Point(33, 1043);
            this.dtpHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpHD.Name = "dtpHD";
            this.dtpHD.Size = new System.Drawing.Size(154, 30);
            this.dtpHD.TabIndex = 21;
            this.dtpHD.Value = new System.DateTime(2023, 11, 18, 0, 0, 0, 0);
            this.dtpHD.ValueChanged += new System.EventHandler(this.dtpHD_ValueChanged);
            // 
            // tst
            // 
            this.tst.AutoSize = true;
            this.tst.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tst.Location = new System.Drawing.Point(207, 426);
            this.tst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tst.Name = "tst";
            this.tst.Size = new System.Drawing.Size(148, 26);
            this.tst.TabIndex = 4;
            this.tst.Text = "Số lượng mua:";
            // 
            // lblDateNow
            // 
            this.lblDateNow.AutoSize = true;
            this.lblDateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateNow.Location = new System.Drawing.Point(442, 92);
            this.lblDateNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateNow.Name = "lblDateNow";
            this.lblDateNow.Size = new System.Drawing.Size(139, 29);
            this.lblDateNow.TabIndex = 17;
            this.lblDateNow.Text = "dd/MM/yyyy";
            this.lblDateNow.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // lblDateHD
            // 
            this.lblDateHD.AutoSize = true;
            this.lblDateHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateHD.Location = new System.Drawing.Point(112, 198);
            this.lblDateHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateHD.Name = "lblDateHD";
            this.lblDateHD.Size = new System.Drawing.Size(139, 29);
            this.lblDateHD.TabIndex = 17;
            this.lblDateHD.Text = "dd/MM/yyyy";
            // 
            // dtgHD
            // 
            this.dtgHD.AllowUserToAddRows = false;
            this.dtgHD.AllowUserToDeleteRows = false;
            this.dtgHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMPN,
            this.clnNLPN,
            this.clnMCT,
            this.clnTCT,
            this.clnMMT,
            this.clnTMT,
            this.clnSL,
            this.clnThue,
            this.clnDG,
            this.clnTT,
            this.clnMNV,
            this.clnGC});
            this.dtgHD.Location = new System.Drawing.Point(36, 125);
            this.dtgHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgHD.Name = "dtgHD";
            this.dtgHD.ReadOnly = true;
            this.dtgHD.RowHeadersWidth = 62;
            this.dtgHD.Size = new System.Drawing.Size(1191, 885);
            this.dtgHD.TabIndex = 24;
            this.dtgHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHD_CellClick);
            // 
            // clnMPN
            // 
            this.clnMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnMPN.DataPropertyName = "MaHD";
            this.clnMPN.HeaderText = "Mã hoá đơn";
            this.clnMPN.MinimumWidth = 8;
            this.clnMPN.Name = "clnMPN";
            this.clnMPN.ReadOnly = true;
            this.clnMPN.Width = 129;
            // 
            // clnNLPN
            // 
            this.clnNLPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnNLPN.DataPropertyName = "NgayBan";
            this.clnNLPN.HeaderText = "Ngày bán";
            this.clnNLPN.MinimumWidth = 8;
            this.clnNLPN.Name = "clnNLPN";
            this.clnNLPN.ReadOnly = true;
            this.clnNLPN.Width = 112;
            // 
            // clnMCT
            // 
            this.clnMCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnMCT.DataPropertyName = "MaKH";
            this.clnMCT.HeaderText = "Mã khách hàng";
            this.clnMCT.MinimumWidth = 8;
            this.clnMCT.Name = "clnMCT";
            this.clnMCT.ReadOnly = true;
            this.clnMCT.Width = 154;
            // 
            // clnTCT
            // 
            this.clnTCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnTCT.DataPropertyName = "TenKH";
            this.clnTCT.HeaderText = "Tên khách hàng";
            this.clnTCT.MinimumWidth = 8;
            this.clnTCT.Name = "clnTCT";
            this.clnTCT.ReadOnly = true;
            this.clnTCT.Width = 146;
            // 
            // clnMMT
            // 
            this.clnMMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnMMT.DataPropertyName = "MaMT";
            this.clnMMT.HeaderText = "Mã máy tính";
            this.clnMMT.MinimumWidth = 8;
            this.clnMMT.Name = "clnMMT";
            this.clnMMT.ReadOnly = true;
            this.clnMMT.Width = 120;
            // 
            // clnTMT
            // 
            this.clnTMT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnTMT.DataPropertyName = "TenMT";
            this.clnTMT.HeaderText = "Tên máy tính";
            this.clnTMT.MinimumWidth = 8;
            this.clnTMT.Name = "clnTMT";
            this.clnTMT.ReadOnly = true;
            this.clnTMT.Width = 125;
            // 
            // clnSL
            // 
            this.clnSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnSL.DataPropertyName = "SoLuongMua";
            this.clnSL.HeaderText = "Số lượng mua";
            this.clnSL.MinimumWidth = 8;
            this.clnSL.Name = "clnSL";
            this.clnSL.ReadOnly = true;
            this.clnSL.Width = 132;
            // 
            // clnThue
            // 
            this.clnThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnThue.DataPropertyName = "GiamGia";
            this.clnThue.HeaderText = "Giảm Giá (%)";
            this.clnThue.MinimumWidth = 8;
            this.clnThue.Name = "clnThue";
            this.clnThue.ReadOnly = true;
            this.clnThue.Width = 108;
            // 
            // clnDG
            // 
            this.clnDG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnDG.DataPropertyName = "DonGia";
            this.clnDG.HeaderText = "Đơn giá";
            this.clnDG.MinimumWidth = 8;
            this.clnDG.Name = "clnDG";
            this.clnDG.ReadOnly = true;
            this.clnDG.Width = 93;
            // 
            // clnTT
            // 
            this.clnTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnTT.DataPropertyName = "ThanhTien";
            this.clnTT.HeaderText = "Thành tiền";
            this.clnTT.MinimumWidth = 8;
            this.clnTT.Name = "clnTT";
            this.clnTT.ReadOnly = true;
            this.clnTT.Width = 111;
            // 
            // clnMNV
            // 
            this.clnMNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnMNV.DataPropertyName = "MaNV";
            this.clnMNV.HeaderText = "Mã nhân viên";
            this.clnMNV.MinimumWidth = 8;
            this.clnMNV.Name = "clnMNV";
            this.clnMNV.ReadOnly = true;
            this.clnMNV.Width = 128;
            // 
            // clnGC
            // 
            this.clnGC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnGC.DataPropertyName = "GhiChu";
            this.clnGC.HeaderText = "Ghi Chú";
            this.clnGC.MinimumWidth = 8;
            this.clnGC.Name = "clnGC";
            this.clnGC.ReadOnly = true;
            this.clnGC.Width = 96;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBaoCao);
            this.panel2.Controls.Add(this.btnInPhieuHD);
            this.panel2.Controls.Add(this.btnXoaHD);
            this.panel2.Controls.Add(this.btnSuaHD);
            this.panel2.Controls.Add(this.lblDateNow);
            this.panel2.Controls.Add(this.btnThemHD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 115);
            this.panel2.TabIndex = 23;
            // 
            // pnHD
            // 
            this.pnHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnHD.Controls.Add(this.txtDiemTT);
            this.pnHD.Controls.Add(this.lblDateHD);
            this.pnHD.Controls.Add(this.btnSua);
            this.pnHD.Controls.Add(this.btnDong);
            this.pnHD.Controls.Add(this.btnLuu);
            this.pnHD.Controls.Add(this.txtGhiChu);
            this.pnHD.Controls.Add(this.label4);
            this.pnHD.Controls.Add(this.txtMaMT);
            this.pnHD.Controls.Add(this.txtMaKH);
            this.pnHD.Controls.Add(this.txtSoLuong);
            this.pnHD.Controls.Add(this.txtMaNV);
            this.pnHD.Controls.Add(this.txtMaHD);
            this.pnHD.Controls.Add(this.label9);
            this.pnHD.Controls.Add(this.tst);
            this.pnHD.Controls.Add(this.label3);
            this.pnHD.Controls.Add(this.label6);
            this.pnHD.Controls.Add(this.label5);
            this.pnHD.Controls.Add(this.label2);
            this.pnHD.Controls.Add(this.label1);
            this.pnHD.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnHD.Location = new System.Drawing.Point(1262, 0);
            this.pnHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnHD.Name = "pnHD";
            this.pnHD.Size = new System.Drawing.Size(356, 1080);
            this.pnHD.TabIndex = 22;
            // 
            // txtDiemTT
            // 
            this.txtDiemTT.Enabled = false;
            this.txtDiemTT.Location = new System.Drawing.Point(50, 474);
            this.txtDiemTT.Name = "txtDiemTT";
            this.txtDiemTT.Size = new System.Drawing.Size(85, 26);
            this.txtDiemTT.TabIndex = 18;
            this.txtDiemTT.Text = "0";
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
            this.btnLamMoi.Location = new System.Drawing.Point(207, 1038);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(30, 30);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.TextColor = System.Drawing.Color.White;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBaoCao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBaoCao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBaoCao.BorderRadius = 20;
            this.btnBaoCao.BorderSize = 0;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.ForeColor = System.Drawing.Color.Black;
            this.btnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Image")));
            this.btnBaoCao.Location = new System.Drawing.Point(939, 14);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(178, 69);
            this.btnBaoCao.TabIndex = 18;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.TextColor = System.Drawing.Color.Black;
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnInPhieuHD
            // 
            this.btnInPhieuHD.BackColor = System.Drawing.Color.SlateBlue;
            this.btnInPhieuHD.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.btnInPhieuHD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInPhieuHD.BorderRadius = 20;
            this.btnInPhieuHD.BorderSize = 0;
            this.btnInPhieuHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInPhieuHD.FlatAppearance.BorderSize = 0;
            this.btnInPhieuHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInPhieuHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieuHD.ForeColor = System.Drawing.Color.Black;
            this.btnInPhieuHD.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieuHD.Image")));
            this.btnInPhieuHD.Location = new System.Drawing.Point(939, 14);
            this.btnInPhieuHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInPhieuHD.Name = "btnInPhieuHD";
            this.btnInPhieuHD.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnInPhieuHD.Size = new System.Drawing.Size(178, 69);
            this.btnInPhieuHD.TabIndex = 3;
            this.btnInPhieuHD.Text = "In Phiếu";
            this.btnInPhieuHD.TextColor = System.Drawing.Color.Black;
            this.btnInPhieuHD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInPhieuHD.UseVisualStyleBackColor = false;
            this.btnInPhieuHD.Click += new System.EventHandler(this.btnInPhieuHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaHD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaHD.BorderRadius = 20;
            this.btnXoaHD.BorderSize = 0;
            this.btnXoaHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaHD.FlatAppearance.BorderSize = 0;
            this.btnXoaHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnXoaHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHD.ForeColor = System.Drawing.Color.Black;
            this.btnXoaHD.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHD.Image")));
            this.btnXoaHD.Location = new System.Drawing.Point(673, 10);
            this.btnXoaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnXoaHD.Size = new System.Drawing.Size(178, 69);
            this.btnXoaHD.TabIndex = 2;
            this.btnXoaHD.Text = "Xoá";
            this.btnXoaHD.TextColor = System.Drawing.Color.Black;
            this.btnXoaHD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoaHD.UseVisualStyleBackColor = false;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.BackColor = System.Drawing.Color.Yellow;
            this.btnSuaHD.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnSuaHD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSuaHD.BorderRadius = 20;
            this.btnSuaHD.BorderSize = 0;
            this.btnSuaHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaHD.FlatAppearance.BorderSize = 0;
            this.btnSuaHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnSuaHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSuaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaHD.ForeColor = System.Drawing.Color.Black;
            this.btnSuaHD.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaHD.Image")));
            this.btnSuaHD.Location = new System.Drawing.Point(401, 14);
            this.btnSuaHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnSuaHD.Size = new System.Drawing.Size(178, 69);
            this.btnSuaHD.TabIndex = 1;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.TextColor = System.Drawing.Color.Black;
            this.btnSuaHD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSuaHD.UseVisualStyleBackColor = false;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.Color.Lime;
            this.btnThemHD.BackgroundColor = System.Drawing.Color.Lime;
            this.btnThemHD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemHD.BorderRadius = 20;
            this.btnThemHD.BorderSize = 0;
            this.btnThemHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemHD.FlatAppearance.BorderSize = 0;
            this.btnThemHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnThemHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThemHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHD.ForeColor = System.Drawing.Color.Black;
            this.btnThemHD.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHD.Image")));
            this.btnThemHD.Location = new System.Drawing.Point(150, 14);
            this.btnThemHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnThemHD.Size = new System.Drawing.Size(178, 69);
            this.btnThemHD.TabIndex = 0;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.TextColor = System.Drawing.Color.Black;
            this.btnThemHD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 1080);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dtpHD);
            this.Controls.Add(this.dtgHD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHD)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnHD.ResumeLayout(false);
            this.pnHD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMT;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private VBButton btnInPhieuHD;
        private VBButton btnXoaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHD;
        private System.Windows.Forms.Label tst;
        private VBButton btnSuaHD;
        private System.Windows.Forms.Label lblDateNow;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dtgHD;
        private System.Windows.Forms.Panel panel2;
        private VBButton btnThemHD;
        private System.Windows.Forms.Panel pnHD;
        private System.Windows.Forms.Label lblDateHD;
        private System.Windows.Forms.Timer timer1;
        private VBButton btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNLPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGC;
        private VBButton btnBaoCao;
        private System.Windows.Forms.TextBox txtDiemTT;
    }
}