using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh3
{
    

    public partial class TBCK : Form
    {
        public string ID;
        public string tien;
        public string ngay;
        public string ten;
        public string TK;
        public string NH;
        public string ND;
        public string sodu;
        public TBCK()
        {
            InitializeComponent();
        }

        private void TBCK_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            label16.Text = random.Next(10000,99999).ToString();
            label7.Text = tien;
            label11.Text = ten;
            label14.Text = TK;
            label15.Text = NH;
            label17.Text = ND;
            label8.Text = ngay;
            label18.Text = sodu;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ID = ID;
            form1.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CK cK = new CK();
            cK.ID = ID;
            cK.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TietKiem tietKiem = new TietKiem();
            tietKiem.ID = ID;
            tietKiem.Show();
            this.Close();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SaoKe saoKe = new SaoKe();
            saoKe.ID = ID;
            saoKe.Show();
            this.Close();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
