namespace Doan
{
    partial class FormXemAnh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXemAnh));
            this.Anh = new System.Windows.Forms.PictureBox();
            this.Trai = new System.Windows.Forms.PictureBox();
            this.Phai = new System.Windows.Forms.PictureBox();
            this.Tat = new Doan.RJUserControl.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phai)).BeginInit();
            this.SuspendLayout();
            // 
            // Anh
            // 
            this.Anh.Location = new System.Drawing.Point(310, 3);
            this.Anh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Anh.Name = "Anh";
            this.Anh.Size = new System.Drawing.Size(885, 1064);
            this.Anh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Anh.TabIndex = 0;
            this.Anh.TabStop = false;
            // 
            // Trai
            // 
            this.Trai.Image = ((System.Drawing.Image)(resources.GetObject("Trai.Image")));
            this.Trai.Location = new System.Drawing.Point(18, 488);
            this.Trai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Trai.Name = "Trai";
            this.Trai.Size = new System.Drawing.Size(104, 97);
            this.Trai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Trai.TabIndex = 1;
            this.Trai.TabStop = false;
            this.Trai.Click += new System.EventHandler(this.Trai_Click);
            // 
            // Phai
            // 
            this.Phai.Image = ((System.Drawing.Image)(resources.GetObject("Phai.Image")));
            this.Phai.Location = new System.Drawing.Point(1378, 488);
            this.Phai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Phai.Name = "Phai";
            this.Phai.Size = new System.Drawing.Size(104, 97);
            this.Phai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Phai.TabIndex = 2;
            this.Phai.TabStop = false;
            this.Phai.Click += new System.EventHandler(this.Phai_Click);
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
            this.Tat.Location = new System.Drawing.Point(1400, 19);
            this.Tat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tat.Name = "Tat";
            this.Tat.Size = new System.Drawing.Size(82, 86);
            this.Tat.TabIndex = 3;
            this.Tat.TextColor = System.Drawing.Color.White;
            this.Tat.UseVisualStyleBackColor = false;
            this.Tat.Click += new System.EventHandler(this.Tat_Click);
            // 
            // FormXemAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1500, 1070);
            this.Controls.Add(this.Tat);
            this.Controls.Add(this.Phai);
            this.Controls.Add(this.Trai);
            this.Controls.Add(this.Anh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormXemAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXemAnh";
            this.Load += new System.EventHandler(this.FormXemAnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Anh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Phai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Anh;
        private System.Windows.Forms.PictureBox Trai;
        private System.Windows.Forms.PictureBox Phai;
        private Doan.RJUserControl.RJButton Tat;
    }
}