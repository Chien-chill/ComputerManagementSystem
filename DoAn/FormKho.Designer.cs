namespace DoAn
{
    partial class FormKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKho));
            this.txtSLT = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.txtMaMT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgKho = new System.Windows.Forms.DataGridView();
            this.clnTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnXTimKiem = new System.Windows.Forms.PictureBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pnInputSearch = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThemKho = new DoAn.VBButton();
            this.btnTimKiemKho = new DoAn.VBButton();
            this.btnXoaKho = new DoAn.VBButton();
            this.btnSuaKho = new DoAn.VBButton();
            this.pnKho = new System.Windows.Forms.Panel();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXTimKiem)).BeginInit();
            this.pnInputSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnKho.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSLT
            // 
            this.txtSLT.Location = new System.Drawing.Point(30, 310);
            this.txtSLT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSLT.Name = "txtSLT";
            this.txtSLT.Size = new System.Drawing.Size(276, 26);
            this.txtSLT.TabIndex = 9;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(0, 612);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(146, 49);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Location = new System.Drawing.Point(212, 612);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(144, 49);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(0, 612);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(146, 49);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(30, 204);
            this.txtMaCT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(276, 26);
            this.txtMaCT.TabIndex = 6;
            // 
            // txtMaMT
            // 
            this.txtMaMT.Location = new System.Drawing.Point(30, 100);
            this.txtMaMT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaMT.Name = "txtMaMT";
            this.txtMaMT.Size = new System.Drawing.Size(276, 26);
            this.txtMaMT.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "Số lượng tồn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã công ty:";
            // 
            // dtgKho
            // 
            this.dtgKho.AllowUserToAddRows = false;
            this.dtgKho.AllowUserToDeleteRows = false;
            this.dtgKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnTT,
            this.clnTST,
            this.Column2,
            this.clnDG,
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column5});
            this.dtgKho.Location = new System.Drawing.Point(45, 232);
            this.dtgKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgKho.Name = "dtgKho";
            this.dtgKho.ReadOnly = true;
            this.dtgKho.RowHeadersWidth = 62;
            this.dtgKho.Size = new System.Drawing.Size(1181, 809);
            this.dtgKho.TabIndex = 27;
            this.dtgKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKho_CellClick);
            // 
            // clnTT
            // 
            this.clnTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnTT.DataPropertyName = "MaMT";
            this.clnTT.HeaderText = "Mã máy tính";
            this.clnTT.MinimumWidth = 8;
            this.clnTT.Name = "clnTT";
            this.clnTT.ReadOnly = true;
            this.clnTT.Width = 130;
            // 
            // clnTST
            // 
            this.clnTST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnTST.DataPropertyName = "TenMT";
            this.clnTST.HeaderText = "Tên máy tính";
            this.clnTST.MinimumWidth = 8;
            this.clnTST.Name = "clnTST";
            this.clnTST.ReadOnly = true;
            this.clnTST.Width = 135;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.DataPropertyName = "MaCT";
            this.Column2.HeaderText = "Mã công ty";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 122;
            // 
            // clnDG
            // 
            this.clnDG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnDG.DataPropertyName = "TenCT";
            this.clnDG.HeaderText = "Tên công ty";
            this.clnDG.MinimumWidth = 8;
            this.clnDG.Name = "clnDG";
            this.clnDG.ReadOnly = true;
            this.clnDG.Width = 127;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "SoLuongTon";
            this.Column3.HeaderText = "Số lượng tồn";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 135;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "NgayNhap";
            this.Column1.HeaderText = "Ngày Nhập";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 123;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "DonGiaNhap";
            this.Column4.HeaderText = "Đơn giá nhập";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "DonGiaBan";
            this.Column5.HeaderText = "Đơn giá bán";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 131;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã máy tính:";
            // 
            // btnXTimKiem
            // 
            this.btnXTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.btnXTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnXTimKiem.Image")));
            this.btnXTimKiem.Location = new System.Drawing.Point(42, 18);
            this.btnXTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXTimKiem.Name = "btnXTimKiem";
            this.btnXTimKiem.Size = new System.Drawing.Size(38, 40);
            this.btnXTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnXTimKiem.TabIndex = 5;
            this.btnXTimKiem.TabStop = false;
            this.btnXTimKiem.Click += new System.EventHandler(this.btnXTimKiem_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblTimKiem.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTimKiem.Location = new System.Drawing.Point(117, 29);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(108, 20);
            this.lblTimKiem.TabIndex = 1;
            this.lblTimKiem.Text = "Nhập từ khoá ";
            this.lblTimKiem.Click += new System.EventHandler(this.lblTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(102, 18);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(343, 35);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.MouseLeave += new System.EventHandler(this.txtTimKiem_MouseLeave);
            // 
            // pnInputSearch
            // 
            this.pnInputSearch.Controls.Add(this.btnXTimKiem);
            this.pnInputSearch.Controls.Add(this.lblTimKiem);
            this.pnInputSearch.Controls.Add(this.txtTimKiem);
            this.pnInputSearch.Location = new System.Drawing.Point(794, 106);
            this.pnInputSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnInputSearch.Name = "pnInputSearch";
            this.pnInputSearch.Size = new System.Drawing.Size(447, 86);
            this.pnInputSearch.TabIndex = 1;
            this.pnInputSearch.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.pnInputSearch);
            this.panel2.Controls.Add(this.btnThemKho);
            this.panel2.Controls.Add(this.btnTimKiemKho);
            this.panel2.Controls.Add(this.btnXoaKho);
            this.panel2.Controls.Add(this.btnSuaKho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 208);
            this.panel2.TabIndex = 26;
            // 
            // btnThemKho
            // 
            this.btnThemKho.BackColor = System.Drawing.Color.Lime;
            this.btnThemKho.BackgroundColor = System.Drawing.Color.Lime;
            this.btnThemKho.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThemKho.BorderRadius = 20;
            this.btnThemKho.BorderSize = 0;
            this.btnThemKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemKho.FlatAppearance.BorderSize = 0;
            this.btnThemKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnThemKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnThemKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKho.ForeColor = System.Drawing.Color.Black;
            this.btnThemKho.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKho.Image")));
            this.btnThemKho.Location = new System.Drawing.Point(152, 19);
            this.btnThemKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemKho.Name = "btnThemKho";
            this.btnThemKho.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnThemKho.Size = new System.Drawing.Size(178, 69);
            this.btnThemKho.TabIndex = 1;
            this.btnThemKho.Text = "Thêm";
            this.btnThemKho.TextColor = System.Drawing.Color.Black;
            this.btnThemKho.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThemKho.UseVisualStyleBackColor = false;
            this.btnThemKho.Click += new System.EventHandler(this.btnThemKho_Click);
            // 
            // btnTimKiemKho
            // 
            this.btnTimKiemKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiemKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiemKho.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiemKho.BorderRadius = 20;
            this.btnTimKiemKho.BorderSize = 0;
            this.btnTimKiemKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiemKho.FlatAppearance.BorderSize = 0;
            this.btnTimKiemKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemKho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemKho.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiemKho.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemKho.Image")));
            this.btnTimKiemKho.Location = new System.Drawing.Point(910, 19);
            this.btnTimKiemKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiemKho.Name = "btnTimKiemKho";
            this.btnTimKiemKho.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnTimKiemKho.Size = new System.Drawing.Size(189, 69);
            this.btnTimKiemKho.TabIndex = 4;
            this.btnTimKiemKho.Text = "Tìm Kiếm";
            this.btnTimKiemKho.TextColor = System.Drawing.Color.Black;
            this.btnTimKiemKho.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTimKiemKho.UseVisualStyleBackColor = false;
            this.btnTimKiemKho.Click += new System.EventHandler(this.btnTimKiemKho_Click);
            // 
            // btnXoaKho
            // 
            this.btnXoaKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaKho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoaKho.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoaKho.BorderRadius = 20;
            this.btnXoaKho.BorderSize = 0;
            this.btnXoaKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKho.FlatAppearance.BorderSize = 0;
            this.btnXoaKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnXoaKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnXoaKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKho.ForeColor = System.Drawing.Color.Black;
            this.btnXoaKho.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKho.Image")));
            this.btnXoaKho.Location = new System.Drawing.Point(646, 19);
            this.btnXoaKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaKho.Name = "btnXoaKho";
            this.btnXoaKho.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnXoaKho.Size = new System.Drawing.Size(178, 69);
            this.btnXoaKho.TabIndex = 3;
            this.btnXoaKho.Text = "Xoá";
            this.btnXoaKho.TextColor = System.Drawing.Color.Black;
            this.btnXoaKho.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoaKho.UseVisualStyleBackColor = false;
            this.btnXoaKho.Click += new System.EventHandler(this.btnXoaKho_Click);
            // 
            // btnSuaKho
            // 
            this.btnSuaKho.BackColor = System.Drawing.Color.Yellow;
            this.btnSuaKho.BackgroundColor = System.Drawing.Color.Yellow;
            this.btnSuaKho.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSuaKho.BorderRadius = 20;
            this.btnSuaKho.BorderSize = 0;
            this.btnSuaKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaKho.FlatAppearance.BorderSize = 0;
            this.btnSuaKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnSuaKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSuaKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaKho.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaKho.ForeColor = System.Drawing.Color.Black;
            this.btnSuaKho.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKho.Image")));
            this.btnSuaKho.Location = new System.Drawing.Point(388, 19);
            this.btnSuaKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaKho.Name = "btnSuaKho";
            this.btnSuaKho.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnSuaKho.Size = new System.Drawing.Size(178, 69);
            this.btnSuaKho.TabIndex = 2;
            this.btnSuaKho.Text = "Sửa";
            this.btnSuaKho.TextColor = System.Drawing.Color.Black;
            this.btnSuaKho.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSuaKho.UseVisualStyleBackColor = false;
            this.btnSuaKho.Click += new System.EventHandler(this.btnSuaKho_Click);
            // 
            // pnKho
            // 
            this.pnKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnKho.Controls.Add(this.dtpNgayNhap);
            this.pnKho.Controls.Add(this.label7);
            this.pnKho.Controls.Add(this.txtSLT);
            this.pnKho.Controls.Add(this.btnSua);
            this.pnKho.Controls.Add(this.btnDong);
            this.pnKho.Controls.Add(this.btnLuu);
            this.pnKho.Controls.Add(this.txtMaCT);
            this.pnKho.Controls.Add(this.txtMaMT);
            this.pnKho.Controls.Add(this.label5);
            this.pnKho.Controls.Add(this.label3);
            this.pnKho.Controls.Add(this.label1);
            this.pnKho.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnKho.Location = new System.Drawing.Point(1262, 0);
            this.pnKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnKho.Name = "pnKho";
            this.pnKho.Size = new System.Drawing.Size(356, 1080);
            this.pnKho.TabIndex = 25;
            this.pnKho.Paint += new System.Windows.Forms.PaintEventHandler(this.pnKho_Paint);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(30, 433);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpNgayNhap.Size = new System.Drawing.Size(249, 30);
            this.dtpNgayNhap.TabIndex = 10;
            this.dtpNgayNhap.Value = new System.DateTime(2023, 11, 22, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 392);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ngày nhập:";
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 1080);
            this.Controls.Add(this.dtgKho);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKho";
            this.Text = "FormKho";
            this.Load += new System.EventHandler(this.FormKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXTimKiem)).EndInit();
            this.pnInputSearch.ResumeLayout(false);
            this.pnInputSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnKho.ResumeLayout(false);
            this.pnKho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSLT;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.TextBox txtMaMT;
        private VBButton btnSuaKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgKho;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnInputSearch;
        private System.Windows.Forms.PictureBox btnXTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private VBButton btnThemKho;
        private VBButton btnTimKiemKho;
        private VBButton btnXoaKho;
        private System.Windows.Forms.Panel pnKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTST;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}