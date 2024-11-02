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
    public partial class Form1 : Form
    {
        FDK fdk = null;
        FLienHe flh = null;
        FDN fDN = null;
        FDoAn fDoAn = null;
        FDoVS fDoVS = null;
        FGiatUi fGiatUi = null;
        FTK fFTK = null;
        
        public Form1()
        {
            InitializeComponent();


        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDoVS fDoVS = new FDoVS();
            fDoVS.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            FGiatUi fGiat = new FGiatUi();
            fGiat.Show();
            this.Close();


        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FDoAn fDoAn = new FDoAn();
            fDoAn.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            FTK fTK = new FTK();
            fTK.Show();

            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
             
            FDN fDN = new FDN();    
            fDN.ShowDialog();
            if(fDN.dangnhap == 1)
            {
                label2.Visible = false;
                label14.Visible = true;

            }    


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLienHe fLienHe = new FLienHe();
            fLienHe.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FTK fTK = new FTK();
            fTK.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLienHe fLienHe = new FLienHe();
            fLienHe.Show();
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void panel5_Click(object sender, PaintEventArgs e)
        {
            this.Hide();
            FDoAn fDoAn = new FDoAn();
            fDoAn.Show();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
               
        }
        private void panel3_Click(object sender, PaintEventArgs e)
        {

            this.Hide();
            FGiatUi fGiat = new FGiatUi();
            fGiat.Show();
            this.Close();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel2_Click(object sender, PaintEventArgs e)
        {
            this.Hide();
            FDoVS fDoVS = new FDoVS();
            fDoVS.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            panel6.Visible = true;
            label3.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            panel6.Visible=false;
        }
    }
}
