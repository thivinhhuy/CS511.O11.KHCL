namespace Doan
{
    partial class BaiViet_Vid_
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaiViet_Vid_));
            this.Avt = new System.Windows.Forms.PictureBox();
            this.TenNguoiDung = new System.Windows.Forms.Label();
            this.ThoiGian = new System.Windows.Forms.Label();
            this.CheDo = new System.Windows.Forms.PictureBox();
            this.BaiViet = new System.Windows.Forms.Label();
            this.PanelAnh = new System.Windows.Forms.Panel();
            this.TatTieng = new System.Windows.Forms.PictureBox();
            this.PhatVideo = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.socmt = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SoThich = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rjProgressBar1 = new Doan.RJUserControl.RJProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheDo)).BeginInit();
            this.PanelAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TatTieng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhatVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Avt
            // 
            this.Avt.Image = ((System.Drawing.Image)(resources.GetObject("Avt.Image")));
            this.Avt.Location = new System.Drawing.Point(39, 22);
            this.Avt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Avt.Name = "Avt";
            this.Avt.Size = new System.Drawing.Size(96, 108);
            this.Avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avt.TabIndex = 0;
            this.Avt.TabStop = false;
            this.Avt.Click += new System.EventHandler(this.Avt_Click);
            // 
            // TenNguoiDung
            // 
            this.TenNguoiDung.AutoSize = true;
            this.TenNguoiDung.Font = new System.Drawing.Font("UTM Centur", 14F, System.Drawing.FontStyle.Bold);
            this.TenNguoiDung.ForeColor = System.Drawing.Color.White;
            this.TenNguoiDung.Location = new System.Drawing.Point(162, 22);
            this.TenNguoiDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TenNguoiDung.Name = "TenNguoiDung";
            this.TenNguoiDung.Size = new System.Drawing.Size(310, 53);
            this.TenNguoiDung.TabIndex = 1;
            this.TenNguoiDung.Text = "TenPlaceholder";
            this.TenNguoiDung.Click += new System.EventHandler(this.TenNguoiDung_Click);
            // 
            // ThoiGian
            // 
            this.ThoiGian.AutoSize = true;
            this.ThoiGian.Font = new System.Drawing.Font("UTM Centur", 10F);
            this.ThoiGian.ForeColor = System.Drawing.Color.White;
            this.ThoiGian.Location = new System.Drawing.Point(165, 92);
            this.ThoiGian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Size = new System.Drawing.Size(231, 38);
            this.ThoiGian.TabIndex = 2;
            this.ThoiGian.Text = "TimePlaceholder";
            // 
            // CheDo
            // 
            this.CheDo.Image = ((System.Drawing.Image)(resources.GetObject("CheDo.Image")));
            this.CheDo.Location = new System.Drawing.Point(476, 82);
            this.CheDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheDo.Name = "CheDo";
            this.CheDo.Size = new System.Drawing.Size(46, 48);
            this.CheDo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheDo.TabIndex = 3;
            this.CheDo.TabStop = false;
            // 
            // BaiViet
            // 
            this.BaiViet.Font = new System.Drawing.Font("UTM Centur", 14F);
            this.BaiViet.ForeColor = System.Drawing.Color.White;
            this.BaiViet.Location = new System.Drawing.Point(30, 162);
            this.BaiViet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BaiViet.Name = "BaiViet";
            this.BaiViet.Size = new System.Drawing.Size(1405, 122);
            this.BaiViet.TabIndex = 4;
            this.BaiViet.Text = "BaiVietPlaceholder";
            // 
            // PanelAnh
            // 
            this.PanelAnh.Controls.Add(this.rjProgressBar1);
            this.PanelAnh.Controls.Add(this.TatTieng);
            this.PanelAnh.Controls.Add(this.PhatVideo);
            this.PanelAnh.Controls.Add(this.axWindowsMediaPlayer1);
            this.PanelAnh.Location = new System.Drawing.Point(39, 289);
            this.PanelAnh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelAnh.Name = "PanelAnh";
            this.PanelAnh.Size = new System.Drawing.Size(1120, 770);
            this.PanelAnh.TabIndex = 10;
            this.PanelAnh.MouseEnter += new System.EventHandler(this.PanelAnh_MouseEnter);
            this.PanelAnh.MouseLeave += new System.EventHandler(this.PanelAnh_MouseLeave);
            // 
            // TatTieng
            // 
            this.TatTieng.BackColor = System.Drawing.Color.Black;
            this.TatTieng.Image = ((System.Drawing.Image)(resources.GetObject("TatTieng.Image")));
            this.TatTieng.Location = new System.Drawing.Point(986, 636);
            this.TatTieng.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TatTieng.Name = "TatTieng";
            this.TatTieng.Size = new System.Drawing.Size(98, 78);
            this.TatTieng.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TatTieng.TabIndex = 2;
            this.TatTieng.TabStop = false;
            this.TatTieng.Click += new System.EventHandler(this.TatTieng_Click);
            // 
            // PhatVideo
            // 
            this.PhatVideo.BackColor = System.Drawing.Color.Black;
            this.PhatVideo.Image = ((System.Drawing.Image)(resources.GetObject("PhatVideo.Image")));
            this.PhatVideo.Location = new System.Drawing.Point(50, 636);
            this.PhatVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhatVideo.Name = "PhatVideo";
            this.PhatVideo.Size = new System.Drawing.Size(98, 78);
            this.PhatVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhatVideo.TabIndex = 1;
            this.PhatVideo.TabStop = false;
            this.PhatVideo.Click += new System.EventHandler(this.PhatVideo_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1120, 770);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // socmt
            // 
            this.socmt.AutoSize = true;
            this.socmt.Font = new System.Drawing.Font("UTM Centur", 12F);
            this.socmt.ForeColor = System.Drawing.Color.White;
            this.socmt.Location = new System.Drawing.Point(1025, 1086);
            this.socmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.socmt.Name = "socmt";
            this.socmt.Size = new System.Drawing.Size(38, 45);
            this.socmt.TabIndex = 21;
            this.socmt.Text = "1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(969, 1080);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // SoThich
            // 
            this.SoThich.AutoSize = true;
            this.SoThich.Font = new System.Drawing.Font("UTM Centur", 12F);
            this.SoThich.ForeColor = System.Drawing.Color.White;
            this.SoThich.Location = new System.Drawing.Point(164, 1080);
            this.SoThich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SoThich.Name = "SoThich";
            this.SoThich.Size = new System.Drawing.Size(38, 45);
            this.SoThich.TabIndex = 19;
            this.SoThich.Text = "1";
            this.SoThich.MouseEnter += new System.EventHandler(this.SoThich_MouseEnter);
            this.SoThich.MouseLeave += new System.EventHandler(this.SoThich_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 1080);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(11, 1139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 158);
            this.panel1.TabIndex = 22;
            // 
            // rjProgressBar1
            // 
            this.rjProgressBar1.BackColor = System.Drawing.Color.Black;
            this.rjProgressBar1.ChannelColor = System.Drawing.Color.White;
            this.rjProgressBar1.ChannelHeight = 8;
            this.rjProgressBar1.Font = new System.Drawing.Font("UTM Centur", 10F);
            this.rjProgressBar1.ForeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.rjProgressBar1.ForeColor = System.Drawing.Color.White;
            this.rjProgressBar1.Location = new System.Drawing.Point(190, 656);
            this.rjProgressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rjProgressBar1.Maximum = 9999999;
            this.rjProgressBar1.Name = "rjProgressBar1";
            this.rjProgressBar1.ShowMaximun = true;
            this.rjProgressBar1.ShowValue = Doan.RJUserControl.TextPosition.Left;
            this.rjProgressBar1.Size = new System.Drawing.Size(788, 58);
            this.rjProgressBar1.SliderColor = System.Drawing.Color.RoyalBlue;
            this.rjProgressBar1.SliderHeight = 8;
            this.rjProgressBar1.Step = 1;
            this.rjProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.rjProgressBar1.SymbolAfter = "";
            this.rjProgressBar1.SymbolBefore = "";
            this.rjProgressBar1.TabIndex = 3;
            this.rjProgressBar1.Visible = false;
            this.rjProgressBar1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rjProgressBar1_MouseClick);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(184, 917);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 205);
            this.panel2.TabIndex = 20;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listView1.Font = new System.Drawing.Font("UTM Centur", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(194, 197);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BaiViet_Vid_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.socmt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SoThich);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelAnh);
            this.Controls.Add(this.BaiViet);
            this.Controls.Add(this.CheDo);
            this.Controls.Add(this.ThoiGian);
            this.Controls.Add(this.TenNguoiDung);
            this.Controls.Add(this.Avt);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BaiViet_Vid_";
            this.Size = new System.Drawing.Size(1200, 1300);
            this.Load += new System.EventHandler(this.BaiViet_Vid__Load);
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheDo)).EndInit();
            this.PanelAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TatTieng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhatVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Avt;
        private System.Windows.Forms.Label TenNguoiDung;
        private System.Windows.Forms.Label ThoiGian;
        private System.Windows.Forms.PictureBox CheDo;
        private System.Windows.Forms.Label BaiViet;
        private System.Windows.Forms.Panel PanelAnh;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox TatTieng;
        private System.Windows.Forms.PictureBox PhatVideo;
        private RJUserControl.RJProgressBar rjProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label socmt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label SoThich;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
    }
}
