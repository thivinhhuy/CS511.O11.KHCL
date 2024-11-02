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
    public partial class FDN : Form
    {
        public FDN()
        {
            InitializeComponent();
            
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FDK fDK = new FDK();
            fDK.ShowDialog();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            FDK fDK = new FDK();
            fDK.ShowDialog();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTkDn_Enter(object sender, EventArgs e)
        {
            if (txtTkDn.Text == "Số điện thoại")
            {
                txtTkDn.Text = "";
                txtTkDn.ForeColor = Color.Black;
            }
        }


        private void txtTkDn_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTkDn.Text))
            {
                txtTkDn.Text = "Số điện thoại";
                txtTkDn.ForeColor = Color.Gray;
            }
        }
        private void txtMKDN_Enter(object sender, EventArgs e)
        {
            if (txtMKDN.Text == "Nhập Mật Khẩu")
            {
                txtMKDN.Text = "";
                txtMKDN.ForeColor = Color.Black;
            }
        }
        private void txtMKDN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMKDN.Text))
            {
                txtMKDN.Text = "Nhập Mật Khẩu";
                txtMKDN.ForeColor = Color.Gray;
            }
        }
        public int dangnhap = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            

            this.Close();
            dangnhap = 1;
        }

        private void txtMKDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
