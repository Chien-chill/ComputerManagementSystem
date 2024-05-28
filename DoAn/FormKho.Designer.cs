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
            this.btnXTimKiem = new System.Windows.Forms.PictureBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pnInputSearch = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiemKho = new DoAn.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXTimKiem)).BeginInit();
            this.pnInputSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.dtgKho.Location = new System.Drawing.Point(54, 240);
            this.dtgKho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgKho.Name = "dtgKho";
            this.dtgKho.ReadOnly = true;
            this.dtgKho.RowHeadersWidth = 62;
            this.dtgKho.Size = new System.Drawing.Size(1520, 809);
            this.dtgKho.TabIndex = 27;
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
            this.pnInputSearch.Location = new System.Drawing.Point(257, 19);
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
            this.panel2.Controls.Add(this.btnTimKiemKho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1618, 208);
            this.panel2.TabIndex = 26;
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
            this.btnTimKiemKho.Location = new System.Drawing.Point(45, 19);
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
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 1080);
            this.Controls.Add(this.dtgKho);
            this.Controls.Add(this.panel2);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgKho;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnInputSearch;
        private System.Windows.Forms.PictureBox btnXTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private VBButton btnTimKiemKho;
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