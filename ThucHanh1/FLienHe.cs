using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21522165_TH1
{
    public partial class FLienHe : Form
    {
        public FLienHe()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FLienHe_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textsend.Text.Trim().Length == 0) return ;

            Addoutcome(textsend.Text);
            textsend.Text = string.Empty;
            timer1.Start();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        int curTop = 10;
        void Addincome(string mess)
        {
            var bubble = new chatiterm.income();
            panel3.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Mess = mess;

            curTop += bubble.Height;
        }
        void Addoutcome(string mess)    
        {
            var bubble = new chatiterm.outcome();
            panel3.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.Mess = mess;

            curTop += bubble.Height;
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textsend_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                if (textsend.Text.Trim().Length == 0) 
                    return ;
                Addoutcome(textsend.Text);
                textsend.Text = string.Empty;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Addincome("Xin Lỗi Hiện Tại Tôi Đang Bận:");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            Addincome("Xin Lỗi Hiện Tại Tôi Đang Bận:");
        }

        private void FLienHe_Shown(object sender, EventArgs e)
        {
            Addincome("Xin chào người dùng Vinhhuy");
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); 
            form1.Show();
            this.Close();
        }

    }
}

