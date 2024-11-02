namespace Doan
{
    partial class BinhLuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinhLuan));
            this.Avt = new System.Windows.Forms.PictureBox();
            this.ThoiGian = new System.Windows.Forms.Label();
            this.Cmt = new Doan .Roundedtext.RJtext();
            this.Thich = new System.Windows.Forms.Label();
            this.ThichPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThichPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Avt
            // 
            this.Avt.Location = new System.Drawing.Point(3, 3);
            this.Avt.Name = "Avt";
            this.Avt.Size = new System.Drawing.Size(72, 66);
            this.Avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Avt.TabIndex = 1;
            this.Avt.TabStop = false;
            // 
            // ThoiGian
            // 
            this.ThoiGian.AutoSize = true;
            this.ThoiGian.Font = new System.Drawing.Font("UTM Centur", 10F);
            this.ThoiGian.ForeColor = System.Drawing.Color.White;
            this.ThoiGian.Location = new System.Drawing.Point(78, 102);
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Size = new System.Drawing.Size(143, 24);
            this.ThoiGian.TabIndex = 3;
            this.ThoiGian.Text = "TimePlaceholder";
            // 
            // Cmt
            // 
            this.Cmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.Cmt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.Cmt.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.Cmt.BorderRadius = 10;
            this.Cmt.BorderSize = 2;
            this.Cmt.Font = new System.Drawing.Font("UTM Centur", 12F);
            this.Cmt.ForeColor = System.Drawing.Color.White;
            this.Cmt.Location = new System.Drawing.Point(82, 4);
            this.Cmt.Margin = new System.Windows.Forms.Padding(4);
            this.Cmt.Multiline = true;
            this.Cmt.Name = "Cmt";
            this.Cmt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.Cmt.PasswordChar = false;
            this.Cmt.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.Cmt.PlaceholderText = "";
            this.Cmt.ReadOnly = true;
            this.Cmt.Size = new System.Drawing.Size(439, 94);
            this.Cmt.TabIndex = 2;
            this.Cmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Cmt.Texts = "";
            this.Cmt.UnderlinedStyle = false;
            // 
            // Thich
            // 
            this.Thich.AutoSize = true;
            this.Thich.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thich.Font = new System.Drawing.Font("UTM Centur", 10F, System.Drawing.FontStyle.Bold);
            this.Thich.ForeColor = System.Drawing.Color.White;
            this.Thich.Location = new System.Drawing.Point(227, 102);
            this.Thich.Name = "Thich";
            this.Thich.Size = new System.Drawing.Size(63, 25);
            this.Thich.TabIndex = 4;
            this.Thich.Text = "Thích";
            this.Thich.Click += new System.EventHandler(this.Thich_Click);
            // 
            // ThichPic
            // 
            this.ThichPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.ThichPic.Image = ((System.Drawing.Image)(resources.GetObject("ThichPic.Image")));
            this.ThichPic.Location = new System.Drawing.Point(484, 63);
            this.ThichPic.Name = "ThichPic";
            this.ThichPic.Size = new System.Drawing.Size(37, 35);
            this.ThichPic.TabIndex = 5;
            this.ThichPic.TabStop = false;
            this.ThichPic.Visible = false;
            // 
            // BinhLuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.ThichPic);
            this.Controls.Add(this.Thich);
            this.Controls.Add(this.ThoiGian);
            this.Controls.Add(this.Cmt);
            this.Controls.Add(this.Avt);
            this.Name = "BinhLuan";
            this.Size = new System.Drawing.Size(525, 142);
            this.Resize += new System.EventHandler(this.BinhLuan_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Avt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThichPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Avt;
        private Doan    .Roundedtext.RJtext Cmt;
        private System.Windows.Forms.Label ThoiGian;
        private System.Windows.Forms.Label Thich;
        private System.Windows.Forms.PictureBox ThichPic;
    }
}
