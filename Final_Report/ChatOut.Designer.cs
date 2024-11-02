namespace Doan
{
    partial class ChatOut
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rJtext1 = new Doan.Roundedtext.RJtext();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // rJtext1
            // 
            this.rJtext1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.rJtext1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.rJtext1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJtext1.BorderRadius = 10;
            this.rJtext1.BorderSize = 2;
            this.rJtext1.Font = new System.Drawing.Font("UTM Centur", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJtext1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rJtext1.Location = new System.Drawing.Point(74, 7);
            this.rJtext1.Margin = new System.Windows.Forms.Padding(4);
            this.rJtext1.Multiline = true;
            this.rJtext1.Name = "rJtext1";
            this.rJtext1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJtext1.PasswordChar = false;
            this.rJtext1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJtext1.PlaceholderText = "";
            this.rJtext1.ReadOnly = false;
            this.rJtext1.Size = new System.Drawing.Size(418, 60);
            this.rJtext1.TabIndex = 4;
            this.rJtext1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJtext1.Texts = "";
            this.rJtext1.UnderlinedStyle = false;
            // 
            // ChatOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.rJtext1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChatOut";
            this.Size = new System.Drawing.Size(507, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Doan.Roundedtext.RJtext rJtext1;
    }
}
