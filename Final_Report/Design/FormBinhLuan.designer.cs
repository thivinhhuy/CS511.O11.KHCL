namespace Doan
{
    partial class FormBinhLuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBinhLuan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelCmt = new System.Windows.Forms.Panel();
            this.Tat = new Doan.RJUserControl.RJButton();
            this.rJtext1 = new Doan .Roundedtext.RJtext();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjButton1 = new Doan.RJUserControl.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UTM Centur", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(608, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bình luận";
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
            // PanelCmt
            // 
            this.PanelCmt.AutoScroll = true;
            this.PanelCmt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelCmt.Location = new System.Drawing.Point(0, 426);
            this.PanelCmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelCmt.Name = "PanelCmt";
            this.PanelCmt.Size = new System.Drawing.Size(1500, 644);
            this.PanelCmt.TabIndex = 3;
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
            this.Tat.Location = new System.Drawing.Point(1372, 19);
            this.Tat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tat.Name = "Tat";
            this.Tat.Size = new System.Drawing.Size(82, 86);
            this.Tat.TabIndex = 1;
            this.Tat.TextColor = System.Drawing.Color.White;
            this.Tat.UseVisualStyleBackColor = false;
            this.Tat.Click += new System.EventHandler(this.Tat_Click);
            // 
            // rJtext1
            // 
            this.rJtext1.BackColor = System.Drawing.SystemColors.Window;
            this.rJtext1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rJtext1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJtext1.BorderRadius = 0;
            this.rJtext1.BorderSize = 2;
            this.rJtext1.Font = new System.Drawing.Font("UTM Centur", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJtext1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rJtext1.Location = new System.Drawing.Point(122, 182);
            this.rJtext1.Margin = new System.Windows.Forms.Padding(4);
            this.rJtext1.Multiline = true;
            this.rJtext1.Name = "rJtext1";
            this.rJtext1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJtext1.PasswordChar = false;
            this.rJtext1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJtext1.PlaceholderText = "Viết Bình luận";
            this.rJtext1.ReadOnly = false;
            this.rJtext1.Size = new System.Drawing.Size(1217, 87);
            this.rJtext1.TabIndex = 4;
            this.rJtext1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJtext1.Texts = "";
            this.rJtext1.UnderlinedStyle = false;
            this.rJtext1.Enter += new System.EventHandler(this.rJtext1_Enter);
            this.rJtext1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rJtext1_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(1346, 182);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 87);
            this.rjButton1.TabIndex = 6;
            this.rjButton1.Text = "Gửi";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // FormBinhLuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1500, 1070);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rJtext1);
            this.Controls.Add(this.PanelCmt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tat);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBinhLuan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBinhLuan";
            this.Load += new System.EventHandler(this.FormBinhLuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Doan.RJUserControl.RJButton Tat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelCmt;
        private Doan.Roundedtext.RJtext rJtext1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJUserControl.RJButton rjButton1;
    }
}