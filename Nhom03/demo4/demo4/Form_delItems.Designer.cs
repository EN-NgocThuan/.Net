namespace demo4
{
    partial class Form_delItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_delItems));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cBLoai = new System.Windows.Forms.ComboBox();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnSubmit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bLb_TenVL = new Bunifu.UI.WinForms.BunifuLabel();
            this.bLb_GiaVL = new Bunifu.UI.WinForms.BunifuLabel();
            this.bLb_DonVi = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cBLoai
            // 
            this.cBLoai.FormattingEnabled = true;
            this.cBLoai.Location = new System.Drawing.Point(122, 62);
            this.cBLoai.Name = "cBLoai";
            this.cBLoai.Size = new System.Drawing.Size(290, 21);
            this.cBLoai.TabIndex = 40;
            this.cBLoai.SelectedIndexChanged += new System.EventHandler(this.cBLoai_SelectedIndexChanged);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bunifuLabel4.Location = new System.Drawing.Point(9, 62);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(107, 23);
            this.bunifuLabel4.TabIndex = 39;
            this.bunifuLabel4.TabStop = false;
            this.bunifuLabel4.Text = "Mã vật liệu :";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 13;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(406, 10);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(27, 27);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 38;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bunifuLabel5.Location = new System.Drawing.Point(134, 12);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(179, 23);
            this.bunifuLabel5.TabIndex = 37;
            this.bunifuLabel5.TabStop = false;
            this.bunifuLabel5.Text = "Sửa thông tin vật liệu";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ActiveBorderThickness = 1;
            this.btnSubmit.ActiveCornerRadius = 20;
            this.btnSubmit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnSubmit.ActiveForecolor = System.Drawing.Color.White;
            this.btnSubmit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.ButtonText = "Submit";
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnSubmit.IdleBorderThickness = 1;
            this.btnSubmit.IdleCornerRadius = 20;
            this.btnSubmit.IdleFillColor = System.Drawing.Color.White;
            this.btnSubmit.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnSubmit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btnSubmit.Location = new System.Drawing.Point(144, 298);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 46);
            this.btnSubmit.TabIndex = 36;
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(9, 225);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(71, 23);
            this.bunifuLabel3.TabIndex = 30;
            this.bunifuLabel3.TabStop = false;
            this.bunifuLabel3.Text = "Đơn Vị :";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(9, 172);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(81, 23);
            this.bunifuLabel2.TabIndex = 31;
            this.bunifuLabel2.TabStop = false;
            this.bunifuLabel2.Text = "Giá Bán :";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(9, 119);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(111, 23);
            this.bunifuLabel1.TabIndex = 32;
            this.bunifuLabel1.TabStop = false;
            this.bunifuLabel1.Text = "Tên vật liệu :";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bLb_TenVL
            // 
            this.bLb_TenVL.AllowParentOverrides = false;
            this.bLb_TenVL.AutoEllipsis = false;
            this.bLb_TenVL.Cursor = System.Windows.Forms.Cursors.Default;
            this.bLb_TenVL.CursorType = System.Windows.Forms.Cursors.Default;
            this.bLb_TenVL.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLb_TenVL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bLb_TenVL.Location = new System.Drawing.Point(144, 119);
            this.bLb_TenVL.Name = "bLb_TenVL";
            this.bLb_TenVL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bLb_TenVL.Size = new System.Drawing.Size(15, 23);
            this.bLb_TenVL.TabIndex = 41;
            this.bLb_TenVL.TabStop = false;
            this.bLb_TenVL.Text = "...";
            this.bLb_TenVL.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLb_TenVL.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bLb_GiaVL
            // 
            this.bLb_GiaVL.AllowParentOverrides = false;
            this.bLb_GiaVL.AutoEllipsis = false;
            this.bLb_GiaVL.Cursor = System.Windows.Forms.Cursors.Default;
            this.bLb_GiaVL.CursorType = System.Windows.Forms.Cursors.Default;
            this.bLb_GiaVL.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLb_GiaVL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bLb_GiaVL.Location = new System.Drawing.Point(105, 172);
            this.bLb_GiaVL.Name = "bLb_GiaVL";
            this.bLb_GiaVL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bLb_GiaVL.Size = new System.Drawing.Size(15, 23);
            this.bLb_GiaVL.TabIndex = 41;
            this.bLb_GiaVL.TabStop = false;
            this.bLb_GiaVL.Text = "...";
            this.bLb_GiaVL.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLb_GiaVL.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bLb_DonVi
            // 
            this.bLb_DonVi.AllowParentOverrides = false;
            this.bLb_DonVi.AutoEllipsis = false;
            this.bLb_DonVi.Cursor = System.Windows.Forms.Cursors.Default;
            this.bLb_DonVi.CursorType = System.Windows.Forms.Cursors.Default;
            this.bLb_DonVi.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLb_DonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.bLb_DonVi.Location = new System.Drawing.Point(101, 225);
            this.bLb_DonVi.Name = "bLb_DonVi";
            this.bLb_DonVi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bLb_DonVi.Size = new System.Drawing.Size(15, 23);
            this.bLb_DonVi.TabIndex = 41;
            this.bLb_DonVi.TabStop = false;
            this.bLb_DonVi.Text = "...";
            this.bLb_DonVi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.bLb_DonVi.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Form_delItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 355);
            this.Controls.Add(this.bLb_DonVi);
            this.Controls.Add(this.bLb_GiaVL);
            this.Controls.Add(this.bLb_TenVL);
            this.Controls.Add(this.cBLoai);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_delItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_delItems";
            this.Load += new System.EventHandler(this.Form_delItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ComboBox cBLoai;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSubmit;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bLb_DonVi;
        private Bunifu.UI.WinForms.BunifuLabel bLb_GiaVL;
        private Bunifu.UI.WinForms.BunifuLabel bLb_TenVL;
    }
}