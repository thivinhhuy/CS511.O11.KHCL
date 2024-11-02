using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Data.SqlClient;
using static thuchanh3.Program;

namespace thuchanh3
{
    public partial class Taikhoan : Form
    {
        public Taikhoan()
        {
            InitializeComponent();
        }
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=Bank;Integrated Security=True";
        SqlConnection sqlCond = null;
        public string ID = Globals.idglob;
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string matkhau = random.Next(10000, 99999).ToString();
            MessageBox.Show("Mật khẩu mới đã được gửi về mail ");
            MailMessage mailMessage = new MailMessage("21522165@gm.uit.edu.vn", "huythi121022@gmail.com","Đổi mật khẩu",matkhau);
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"); 
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("21522165@gm.uit.edu.vn", "ctdt2209");
            smtpClient.Send(mailMessage);
            if (sqlCond == null)
            {
                sqlCond = new SqlConnection(strCond);
            }
            if (sqlCond.State == ConnectionState.Closed)
            {
                sqlCond.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update acc set pass = '"+matkhau+"' where ID = '"+ID+"'";
            sqlCmd.Connection = sqlCond;
            int kq = sqlCmd.ExecuteNonQuery();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ID = ID;
            form.Show();
            this.Close();

        }

        private void Taikhoan_Load(object sender, EventArgs e)
        {
            if (sqlCond == null)
            {
                sqlCond = new SqlConnection(strCond);
            }
            if (sqlCond.State == ConnectionState.Closed)
            {
                sqlCond.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from acc where id = '" + ID + "'";
            cmd.Connection = sqlCond;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                rjTextBox1.Texts = reader.GetString(2);
                rjTextBox2.Texts = reader.GetString(1);
                rjTextBox3.Texts = reader.GetString(3);
                rjTextBox4.Texts = reader.GetString(0);
            }
            reader.Close();
        }
    }
}
