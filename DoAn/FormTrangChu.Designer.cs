namespace DoAn
{
    partial class FormTrangChu
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
            this.cbPicture = new System.Windows.Forms.ComboBox();
            this.ptbTrangChu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTrangChu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPicture
            // 
            this.cbPicture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPicture.BackColor = System.Drawing.Color.Aqua;
            this.cbPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbPicture.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPicture.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbPicture.FormattingEnabled = true;
            this.cbPicture.Items.AddRange(new object[] {
            "Main",
            "Christmas",
            "New Year",
            "Mid-Autumm",
            "30-4"});
            this.cbPicture.Location = new System.Drawing.Point(0, 0);
            this.cbPicture.Name = "cbPicture";
            this.cbPicture.Size = new System.Drawing.Size(185, 32);
            this.cbPicture.TabIndex = 1;
            this.cbPicture.SelectedIndexChanged += new System.EventHandler(this.cbPicture_SelectedIndexChanged);
            // 
            // ptbTrangChu
            // 
            this.ptbTrangChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbTrangChu.Image = global::DoAn.Properties.Resources.index_2;
            this.ptbTrangChu.Location = new System.Drawing.Point(0, 0);
            this.ptbTrangChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbTrangChu.Name = "ptbTrangChu";
            this.ptbTrangChu.Size = new System.Drawing.Size(1460, 1106);
            this.ptbTrangChu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTrangChu.TabIndex = 0;
            this.ptbTrangChu.TabStop = false;
            this.ptbTrangChu.Click += new System.EventHandler(this.ptbTrangChu_Click);
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 1106);
            this.Controls.Add(this.cbPicture);
            this.Controls.Add(this.ptbTrangChu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTrangChu";
            this.Text = "FormTrangChu";
            ((System.ComponentModel.ISupportInitialize)(this.ptbTrangChu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbTrangChu;
        private System.Windows.Forms.ComboBox cbPicture;
    }
}