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
    public partial class FDK : Form
    {
        public FDK()
        {
            InitializeComponent();
            
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FDN fDN = new FDN();
            fDN.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FDN fDN = new FDN();
            fDN.ShowDialog();
            this.Close();
            fDN.dangnhap = 1;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtTkDK.Text == "Nhập tên đăng nhập")
            {
                txtTkDK.Text = "";
                txtTkDK.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace("Nhập tên đăng nhập"))
            {
                txtTkDK.Text = "Nhập tên đăng nhập";
                txtTkDK.ForeColor = Color.Gray;
            }
        }

        private void txtTkDK_Enter(object sender, EventArgs e)
        {
            if (txtTkDK.Text == "Nhập tên đăng nhập")
            {
                txtTkDK.Text = "";
                txtTkDK.ForeColor = Color.Black;
            }
        }
        private void txtTkDK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace("Nhập tên đăng nhập"))
            {
                txtTkDK.Text = "Nhập tên đăng nhập";
                txtTkDK.ForeColor = Color.Gray;
            }
        }
        private void txtmailDK_Enter(object sender, EventArgs e)
        {
            if (txtmailDK.Text == "Nhập mail")
            {
                txtmailDK.Text = "";
                txtmailDK.ForeColor = Color.Black;
            }
        }


        private void txtmailDK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmailDK.Text))
            {
                txtmailDK.Text = "Nhập mail";
                txtmailDK.ForeColor = Color.Gray;
            }
        }
        private void txtMKDK_Enter(object sender, EventArgs e)
        {

        }


        private void txtMKDK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMKDK.Text))
            {
                txtMKDK.Text = "Nhập mật khẩu";
                txtMKDK.ForeColor = Color.Gray;
            }
        }
        private void txtLMKDK_Enter(object sender, EventArgs e)
        {
            if (txtLMKDK.Text == "Nhập lại mật khẩu")
            {
                txtLMKDK.Text = "";
                txtLMKDK.ForeColor = Color.Black;
            }
        }


        private void txtLMKDK_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLMKDK.Text))
            {
                txtLMKDK.Text = "Nhập lại mật khẩu";
                txtLMKDK.ForeColor = Color.Gray;
            }
        }
        private void txtsdtDK_Enter(object sender, EventArgs e)
        {
            if (txtsdtDK.Text == "Nhập số điện thoại")
            {
                txtsdtDK.Text = "";
                txtsdtDK.ForeColor = Color.Black;
            }
        }


        private void txtsdtDK_Leave(object sender, EventArgs e)
        {
            if (txtsdtDK.Text == "Nhập số điện thoại")
            {
                txtsdtDK.Text = "";
                txtsdtDK.ForeColor = Color.Black;
            }
        }

        private void txtsdtDK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
