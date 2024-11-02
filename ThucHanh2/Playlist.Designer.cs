namespace thuchanh2
{
    partial class Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox13);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rjTextBox1);
            this.panel1.Location = new System.Drawing.Point(-6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1381, 219);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(1297, 3);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(80, 74);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 74;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(660, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 136);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên PlayList";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Location = new System.Drawing.Point(16, 80);
            this.rjTextBox1.Multiline = true;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(598, 139);
            this.rjTextBox1.TabIndex = 0;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Location = new System.Drawing.Point(10, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 745);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1358, 739);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Screenshot 2023-11-17 005838 - Copy.png");
            this.imageList1.Images.SetKeyName(1, "Screenshot 2023-11-17 005838 - Copy (2).png");
            this.imageList1.Images.SetKeyName(2, "Screenshot 2023-11-17 005838 - Copy (3).png");
            this.imageList1.Images.SetKeyName(3, "Screenshot 2023-11-17 005838 - Copy (4).png");
            this.imageList1.Images.SetKeyName(4, "Screenshot 2023-11-17 005838 - Copy (5).png");
            this.imageList1.Images.SetKeyName(5, "Screenshot 2023-11-17 005838 - Copy (6).png");
            this.imageList1.Images.SetKeyName(6, "Screenshot 2023-11-17 005838 - Copy (7).png");
            this.imageList1.Images.SetKeyName(7, "Screenshot 2023-11-17 005838 - Copy (8).png");
            this.imageList1.Images.SetKeyName(8, "Screenshot 2023-11-17 005838 - Copy (9).png");
            this.imageList1.Images.SetKeyName(9, "Screenshot 2023-11-17 005838 - Copy (10).png");
            this.imageList1.Images.SetKeyName(10, "Screenshot 2023-11-17 005838 - Copy (11).png");
            this.imageList1.Images.SetKeyName(11, "Screenshot 2023-11-17 005838 - Copy (12).png");
            this.imageList1.Images.SetKeyName(12, "Screenshot 2023-11-17 005838 - Copy (13).png");
            this.imageList1.Images.SetKeyName(13, "Screenshot 2023-11-17 005838 - Copy (14).png");
            this.imageList1.Images.SetKeyName(14, "Screenshot 2023-11-17 005838 - Copy (15).png");
            this.imageList1.Images.SetKeyName(15, "Screenshot 2023-11-17 005838 - Copy (16).png");
            this.imageList1.Images.SetKeyName(16, "Screenshot 2023-11-17 005838 - Copy (17).png");
            this.imageList1.Images.SetKeyName(17, "Screenshot 2023-11-17 005838 - Copy (18).png");
            this.imageList1.Images.SetKeyName(18, "Screenshot 2023-11-17 005838 - Copy (19).png");
            this.imageList1.Images.SetKeyName(19, "Screenshot 2023-11-17 005838 - Copy (20).png");
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 1019);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Playlist";
            this.Text = "Playlist";
            this.Load += new System.EventHandler(this.load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox13;
    }
}