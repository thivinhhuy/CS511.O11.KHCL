namespace Doan
{
    partial class FormDangBaiViet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangBaiViet));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Avt = new System.Windows.Forms.PictureBox();
            this.TenNguoiDung = new System.Windows.Forms.Label();
            this.ThemAnh = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BaiViet = new Doan.Roundedtext.RJtext();
            this.rjButton1 = new Doan.RJUserControl.RJButton();
            this.CheDo = new Doan.RJUserControl.RJComboBox();
            this.Tat = new Doan.RJUserControl.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Centur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(572, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tạo bài viết";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(0, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1499, 2);
            this.label2.TabIndex = 2;
            // 
            // Avt
            // 
            this.Avt.Image = ((System.Drawing.Image)(resources.GetObject("Avt.Image")));
            this.Avt.Location = new System.Drawing.Point(48, 173);
            this.Avt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Avt.Name = "Avt";
            this.Avt.Size = new System.Drawing.Size(96, 108);
            this.Avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avt.TabIndex = 3;
            this.Avt.TabStop = false;
            this.Avt.Click += new System.EventHandler(this.Avt_Click);
            // 
            // TenNguoiDung
            // 
            this.TenNguoiDung.AutoSize = true;
            this.TenNguoiDung.Font = new System.Drawing.Font("UTM Centur", 14F, System.Drawing.FontStyle.Bold);
            this.TenNguoiDung.ForeColor = System.Drawing.Color.White;
            this.TenNguoiDung.Location = new System.Drawing.Point(190, 173);
            this.TenNguoiDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TenNguoiDung.Name = "TenNguoiDung";
            this.TenNguoiDung.Size = new System.Drawing.Size(310, 53);
            this.TenNguoiDung.TabIndex = 4;
            this.TenNguoiDung.Text = "TenPlaceholder";
            // 
            // ThemAnh
            // 
            this.ThemAnh.AutoScroll = true;
            this.ThemAnh.Location = new System.Drawing.Point(13, 520);
            this.ThemAnh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThemAnh.Name = "ThemAnh";
            this.ThemAnh.Size = new System.Drawing.Size(1299, 228);
            this.ThemAnh.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UTM Centur", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 780);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thêm vào bài viết của bạn";
            // 
            // Photo
            // 
            this.Photo.Image = ((System.Drawing.Image)(resources.GetObject("Photo.Image")));
            this.Photo.Location = new System.Drawing.Point(701, 780);
            this.Photo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(87, 81);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo.TabIndex = 9;
            this.Photo.TabStop = false;
            this.Photo.Click += new System.EventHandler(this.Photo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(820, 780);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(946, 780);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1079, 780);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // BaiViet
            // 
            this.BaiViet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BaiViet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BaiViet.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.BaiViet.BorderRadius = 0;
            this.BaiViet.BorderSize = 2;
            this.BaiViet.Font = new System.Drawing.Font("UTM Centur", 12F);
            this.BaiViet.ForeColor = System.Drawing.Color.White;
            this.BaiViet.Location = new System.Drawing.Point(11, 292);
            this.BaiViet.Margin = new System.Windows.Forms.Padding(6);
            this.BaiViet.Multiline = true;
            this.BaiViet.Name = "BaiViet";
            this.BaiViet.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.BaiViet.PasswordChar = false;
            this.BaiViet.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.BaiViet.PlaceholderText = "Bạn ơi, bạn đang nghĩ gì thế?";
            this.BaiViet.ReadOnly = false;
            this.BaiViet.Size = new System.Drawing.Size(1299, 217);
            this.BaiViet.TabIndex = 14;
            this.BaiViet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BaiViet.Texts = "";
            this.BaiViet.UnderlinedStyle = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.MediumBlue;
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 2;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("UTM Centur", 14F, System.Drawing.FontStyle.Bold);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(26, 923);
            this.rjButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(1265, 105);
            this.rjButton1.TabIndex = 13;
            this.rjButton1.Text = "Đăng";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // CheDo
            // 
            this.CheDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.CheDo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.CheDo.BorderSize = 1;
            this.CheDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CheDo.Font = new System.Drawing.Font("UTM Centur", 10F);
            this.CheDo.ForeColor = System.Drawing.Color.White;
            this.CheDo.IconColor = System.Drawing.Color.White;
            this.CheDo.Items.AddRange(new object[] {
            "Cong khai",
            "Ban be",
            "Mot minh"});
            this.CheDo.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.CheDo.ListTextColor = System.Drawing.Color.White;
            this.CheDo.Location = new System.Drawing.Point(200, 234);
            this.CheDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheDo.MinimumSize = new System.Drawing.Size(150, 47);
            this.CheDo.Name = "CheDo";
            this.CheDo.Padding = new System.Windows.Forms.Padding(2);
            this.CheDo.Size = new System.Drawing.Size(264, 58);
            this.CheDo.TabIndex = 5;
            this.CheDo.Texts = "Bạn bè";
            // 
            // Tat
            // 
            this.Tat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.Tat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.Tat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.Tat.BorderRadius = 25;
            this.Tat.BorderSize = 2;
            this.Tat.FlatAppearance.BorderSize = 0;
            this.Tat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tat.ForeColor = System.Drawing.Color.White;
            this.Tat.Image = ((System.Drawing.Image)(resources.GetObject("Tat.Image")));
            this.Tat.Location = new System.Drawing.Point(1230, 14);
            this.Tat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tat.Name = "Tat";
            this.Tat.Size = new System.Drawing.Size(82, 86);
            this.Tat.TabIndex = 1;
            this.Tat.TextColor = System.Drawing.Color.White;
            this.Tat.UseVisualStyleBackColor = false;
            this.Tat.Click += new System.EventHandler(this.Tat_Click);
            // 
            // FormDangBaiViet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1325, 1070);
            this.Controls.Add(this.ThemAnh);
            this.Controls.Add(this.BaiViet);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheDo);
            this.Controls.Add(this.TenNguoiDung);
            this.Controls.Add(this.Avt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDangBaiViet";
            this.Text = "FormDangBaiViet";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormDangBaiViet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Doan.RJUserControl.RJButton Tat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Avt;
        private System.Windows.Forms.Label TenNguoiDung;
        private Doan.RJUserControl.RJComboBox CheDo;
        private System.Windows.Forms.Panel ThemAnh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Doan.RJUserControl.RJButton rjButton1;
        private Doan.Roundedtext.RJtext BaiViet;
    }
}