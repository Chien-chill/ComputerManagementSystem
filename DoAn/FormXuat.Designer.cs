namespace DoAn
{
    partial class FormXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXuat));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDatePhieuXuat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtgPhieuXuat = new System.Windows.Forms.DataGridView();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInPhieuXuat = new DoAn.VBButton();
            this.btnXoaXuat = new DoAn.VBButton();
            this.btnSuaXuat = new DoAn.VBButton();
            this.lblDateNow = new System.Windows.Forms.Label();
            this.btnThemXuat = new DoAn.VBButton();
            this.pnXuat = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaMT = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaPhieuXuat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tst = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPhieuXuat = new System.Windows.Forms.DateTimePicker();
            this.btnLamMoi = new DoAn.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuXuat)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnXuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // lblDatePhieuXuat
            // 
            this.lblDatePhieuXuat.AutoSize = true;
            this.lblDatePhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatePhieuXuat.Location = new System.Drawing.Point(112, 198);
            this.lblDatePhieuXuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatePhieuXuat.Name = "lblDatePhieuXuat";
            this.lblDatePhieuXuat.Size = new System.Drawing.Size(139, 29);
            this.lblDatePhieuXuat.TabIndex = 17;
            this.lblDatePhieuXuat.Text = "dd/MM/yyyy";
            // 
            // dtgPhieuXuat
            // 
            this.dtgPhieuXuat.AllowUserToAddRows = false;
            this.dtgPhieuXuat.AllowUserToDeleteRows = false;
            this.dtgPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dtgPhieuXuat.Location = new System.Drawing.Point(36, 125);
            this.dtgPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgPhieuXuat.Name = "dtgPhieuXuat";
            this.dtgPhieuXuat.ReadOnly = true;
            this.dtgPhieuXuat.RowHeadersWidth = 62;
            this.dtgPhieuXuat.Size = new System.Drawing.Size(1191, 885);
            this.dtgPhieuXuat.TabIndex = 7;
            this.dtgPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhieuXuat_CellClick);
            // 
            // clnMPN
            // 
            this.clnMPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnMPN.DataPropertyName = "MaPhieuXuat";
            this.clnMPN.HeaderText = "Mã phiếu xuất";
            this.clnMPN.MinimumWidth = 8;
            this.clnMPN.Name = "clnMPN";
            this.clnMPN.ReadOnly = true;
            this.clnMPN.Width = 133;
            // 
            // clnNLPN
            // 
            this.clnNLPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnNLPN.DataPropertyName = "NgayLamPhieu";
            this.clnNLPN.HeaderText = "Ngày làm phiếu";
            this.clnNLPN.MinimumWidth = 8;
            this.clnNLPN.Name = "clnNLPN";
            this.clnNLPN.ReadOnly = true;
            this.clnNLPN.Width = 141;
            // 
            // clnMCT
            // 
            this.clnMCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnMCT.DataPropertyName = "MaKH";
            this.clnMCT.HeaderText = "Mã khách hàng";
            this.clnMCT.MinimumWidth = 8;
            this.clnMCT.Name = "clnMCT";
            this.clnMCT.ReadOnly = true;
            this.clnMCT.Width = 142;
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
            // clnThue
            // 
            this.clnThue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnThue.DataPropertyName = "Thue";
            this.clnThue.HeaderText = "Thuế (VND)";
            this.clnThue.MinimumWidth = 8;
            this.clnThue.Name = "clnThue";
            this.clnThue.ReadOnly = true;
            this.clnThue.Width = 119;
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
            this.clnSL.DataPropertyName = "SoLuong";
            this.clnSL.HeaderText = "Số lượng";
            this.clnSL.MinimumWidth = 8;
            this.clnSL.Name = "clnSL";
            this.clnSL.ReadOnly = true;
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
            this.panel2.Controls.Add(this.btnInPhieuXuat);
            this.panel2.Controls.Add(this.btnXoaXuat);
            this.panel2.Controls.Add(this.btnSuaXuat);
            this.panel2.Controls.Add(this.lblDateNow);
            this.panel2.Controls.Add(this.btnThemXuat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 115);
            this.panel2.TabIndex = 6;
            // 
            // btnInPhieuXuat
            // 
            this.btnInPhieuXuat.BackColor = System.Drawing.Color.SlateBlue;
            this.btnInPhieuXuat.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.btnInPhieuXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInPhieuXuat.BorderRadius = 20;
            this.btnInPhieuXuat.BorderSize = 0;
            this.btnInPhieuXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInPhieuXuat.FlatAppearance.BorderSize = 0;
            this.btnInPhieuXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInPhieuXuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieuXuat.ForeColor = System.Drawing.Color.Black;
            this.btnInPhieuXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnInPhieuXuat.Image")));
            this.btnInPhieuXuat.Location = new System.Drawing.Point(939, 14);
            this.btnInPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInPhieuXuat.Name = "btnInPhieuXuat";
            this.btnInPhieuXuat.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnInPhieuXuat.Size = new System.Drawing.Size(178, 69);
            this.btnInPhieuXuat.TabIndex = 3;
            this.btnInPhieuXuat.Text = "In Phiếu";
            this.btnInPhieuXuat.TextColor = System.Drawing.Color.Black;
            this.btnInPhieuXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInPhieuXuat.UseVisualStyleBackColor = false;
            this.btnInPhieuXuat.Click += new System.EventHandler(this.btnInPhieuXuat_Click);
            // 
            // btnXoaXuat
            // 
            this.btnXoaXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaXuat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaXuat.BorderRadius = 20;
            this.btnXoaXuat.BorderSize = 0;
            this.btnXoaXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaXuat.FlatAppearance.BorderSize = 0;
            this.btnXoaXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnXoaXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXoaXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaXuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaXuat.ForeColor = System.Drawing.Color.Black;
            this.btnXoaXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaXuat.Image")));
            this.btnXoaXuat.Location = new System.Drawing.Point(673, 10);
            this.btnXoaXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaXuat.Name = "btnXoaXuat";
            this.btnXoaXuat.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnXoaXuat.Size = new System.Drawing.Size(178, 69);
            this.btnXoaXuat.TabIndex = 2;
            this.btnXoaXuat.Text = "Xoá";
            this.btnXoaXuat.TextColor = System.Drawing.Color.Black;
            this.btnXoaXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoaXuat.UseVisualStyleBackColor = false;
            this.btnXoaXuat.Click += new System.EventHandler(this.btnXoaXuat_Click);
            // 
            // btnSuaXuat
            // 
            this.btnSuaXuat.BackColor = System.Drawing.Color.Yellow;
            this.btnSuaXuat.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnSuaXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSuaXuat.BorderRadius = 20;
            this.btnSuaXuat.BorderSize = 0;
            this.btnSuaXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaXuat.FlatAppearance.BorderSize = 0;
            this.btnSuaXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnSuaXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSuaXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaXuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaXuat.ForeColor = System.Drawing.Color.Black;
            this.btnSuaXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaXuat.Image")));
            this.btnSuaXuat.Location = new System.Drawing.Point(401, 14);
            this.btnSuaXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaXuat.Name = "btnSuaXuat";
            this.btnSuaXuat.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnSuaXuat.Size = new System.Drawing.Size(178, 69);
            this.btnSuaXuat.TabIndex = 1;
            this.btnSuaXuat.Text = "Sửa";
            this.btnSuaXuat.TextColor = System.Drawing.Color.Black;
            this.btnSuaXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSuaXuat.UseVisualStyleBackColor = false;
            this.btnSuaXuat.Click += new System.EventHandler(this.btnSuaXuat_Click);
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
            // btnThemXuat
            // 
            this.btnThemXuat.BackColor = System.Drawing.Color.Lime;
            this.btnThemXuat.BackgroundColor = System.Drawing.Color.Lime;
            this.btnThemXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemXuat.BorderRadius = 20;
            this.btnThemXuat.BorderSize = 0;
            this.btnThemXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemXuat.FlatAppearance.BorderSize = 0;
            this.btnThemXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnThemXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThemXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemXuat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemXuat.ForeColor = System.Drawing.Color.Black;
            this.btnThemXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnThemXuat.Image")));
            this.btnThemXuat.Location = new System.Drawing.Point(150, 14);
            this.btnThemXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemXuat.Name = "btnThemXuat";
            this.btnThemXuat.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnThemXuat.Size = new System.Drawing.Size(178, 69);
            this.btnThemXuat.TabIndex = 0;
            this.btnThemXuat.Text = "Thêm";
            this.btnThemXuat.TextColor = System.Drawing.Color.Black;
            this.btnThemXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThemXuat.UseVisualStyleBackColor = false;
            this.btnThemXuat.Click += new System.EventHandler(this.btnThemXuat_Click);
            // 
            // pnXuat
            // 
            this.pnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnXuat.Controls.Add(this.lblDatePhieuXuat);
            this.pnXuat.Controls.Add(this.btnSua);
            this.pnXuat.Controls.Add(this.btnDong);
            this.pnXuat.Controls.Add(this.btnLuu);
            this.pnXuat.Controls.Add(this.txtGhiChu);
            this.pnXuat.Controls.Add(this.label4);
            this.pnXuat.Controls.Add(this.txtMaMT);
            this.pnXuat.Controls.Add(this.txtMaKH);
            this.pnXuat.Controls.Add(this.txtSoLuong);
            this.pnXuat.Controls.Add(this.txtThue);
            this.pnXuat.Controls.Add(this.txtMaNV);
            this.pnXuat.Controls.Add(this.txtMaPhieuXuat);
            this.pnXuat.Controls.Add(this.label9);
            this.pnXuat.Controls.Add(this.tst);
            this.pnXuat.Controls.Add(this.label3);
            this.pnXuat.Controls.Add(this.label6);
            this.pnXuat.Controls.Add(this.label5);
            this.pnXuat.Controls.Add(this.label2);
            this.pnXuat.Controls.Add(this.label1);
            this.pnXuat.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnXuat.Location = new System.Drawing.Point(1262, 0);
            this.pnXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnXuat.Name = "pnXuat";
            this.pnXuat.Size = new System.Drawing.Size(356, 1080);
            this.pnXuat.TabIndex = 0;
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
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(50, 286);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(253, 26);
            this.txtMaKH.TabIndex = 2;
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
            this.txtThue.Size = new System.Drawing.Size(78, 26);
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
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(50, 106);
            this.txtMaPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(253, 26);
            this.txtMaPhieuXuat.TabIndex = 1;
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
            this.label3.Size = new System.Drawing.Size(160, 26);
            this.label3.TabIndex = 0;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu xuất:";
            // 
            // dtpPhieuXuat
            // 
            this.dtpPhieuXuat.CustomFormat = "";
            this.dtpPhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPhieuXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPhieuXuat.Location = new System.Drawing.Point(33, 1043);
            this.dtpPhieuXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpPhieuXuat.Name = "dtpPhieuXuat";
            this.dtpPhieuXuat.Size = new System.Drawing.Size(154, 30);
            this.dtpPhieuXuat.TabIndex = 5;
            this.dtpPhieuXuat.Value = new System.DateTime(2023, 11, 18, 0, 0, 0, 0);
            this.dtpPhieuXuat.ValueChanged += new System.EventHandler(this.dtpPhieuNhap_ValueChanged);
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
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.TextColor = System.Drawing.Color.White;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // FormXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 1080);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dtgPhieuXuat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnXuat);
            this.Controls.Add(this.dtpPhieuXuat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormXuat";
            this.Text = "FormXuat";
            this.Load += new System.EventHandler(this.FormXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuXuat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnXuat.ResumeLayout(false);
            this.pnXuat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VBButton btnSuaXuat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dtgPhieuXuat;
        private System.Windows.Forms.Panel panel2;
        private VBButton btnInPhieuXuat;
        private VBButton btnXoaXuat;
        private VBButton btnThemXuat;
        private System.Windows.Forms.Panel pnXuat;
        private System.Windows.Forms.Label lblDatePhieuXuat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaMT;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaPhieuXuat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label tst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDateNow;
        private System.Windows.Forms.DateTimePicker dtpPhieuXuat;
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