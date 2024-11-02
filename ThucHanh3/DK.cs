using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace thuchanh3
{
    public partial class DK : Form
    {
        public DK()
        {
            InitializeComponent();
        }
        string strCon = @"Data Source=LAPTOP-24A31P93;Initial Catalog=Bank;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void DK_Load(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO acc VALUES ('" + textBox3.Text + "',10000000,'" + textBox1.Text + "','" + textBox4.Text + "','" + textBox2.Text + "')";
            sqlCmd.Connection = sqlCon;
            MessageBox.Show(textBox2.Text);
            int kq = sqlCmd.ExecuteNonQuery();
            DNDK dndk = new DNDK();
            dndk.Show();
            this.Close();
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nhập tên đăng nhập")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace("Nhập tên đăng nhập"))
            {
                textBox1.Text = "Nhập tên đăng nhập";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Nhập mật khẩu")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace("Nhập mật khẩu"))
            {
                textBox2.Text = "Nhập mật khẩu";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Nhập mail")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace("Nhập mail"))
            {
                textBox3.Text = "Nhập mail";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Nhập số điện thoại")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace("Nhập số điện thoại"))
            {
                textBox4.Text = "Nhập số điện thoại";
                textBox4.ForeColor = Color.Gray;
            }
        }
    }
}
