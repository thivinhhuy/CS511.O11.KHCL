namespace Doan
{
    partial class ChatIn
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
            this.rJtext1 = new Doan .Roundedtext.RJtext();
            this.SuspendLayout();
            // 
            // rJtext1
            // 
            this.rJtext1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJtext1.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.rJtext1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJtext1.BorderRadius = 10;
            this.rJtext1.BorderSize = 2;
            this.rJtext1.Font = new System.Drawing.Font("UTM Centur", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJtext1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rJtext1.Location = new System.Drawing.Point(52, 7);
            this.rJtext1.Margin = new System.Windows.Forms.Padding(4);
            this.rJtext1.Multiline = true;
            this.rJtext1.Name = "rJtext1";
            this.rJtext1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJtext1.PasswordChar = false;
            this.rJtext1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJtext1.PlaceholderText = "";
            this.rJtext1.ReadOnly = false;
            this.rJtext1.Size = new System.Drawing.Size(427, 60);
            this.rJtext1.TabIndex = 6;
            this.rJtext1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJtext1.Texts = "";
            this.rJtext1.UnderlinedStyle = false;
            this.rJtext1.Load += new System.EventHandler(this.rJtext1_Load);
            // 
            // ChatIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.rJtext1);
            this.Name = "ChatIn";
            this.Size = new System.Drawing.Size(493, 75);
            this.ResumeLayout(false);

        }

        #endregion

        private Doan.Roundedtext.RJtext rJtext1;
    }
}
