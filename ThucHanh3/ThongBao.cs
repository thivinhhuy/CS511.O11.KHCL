using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static thuchanh3.Program;

namespace thuchanh3
{
    public partial class ThongBao : Form
    {
        public string ID = Globals.idglob;
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=Bank;Integrated Security=True";
        public ThongBao()
        {
            InitializeComponent();
        }
        void add(string Mess)
        {
            var bubble = new SK();
            panel2.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.mess = Mess;


        }
        string sotien;
        private void ThongBao_Load(object sender, EventArgs e)
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

            cmd.CommandText = "select * from tinnhan where id='" + ID + "' ORDER BY ngay DESC";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nhan = reader.GetString(2);
                string ngay = reader.GetDateTime(5).ToString();
                string sodu = reader.GetString(4);
                string nd = reader.GetString(6);
                string[] dates = ngay.ToString().Split(' ');
                Boolean dau = reader.GetBoolean(1);
                if (dau == true)
                {
                    sotien = " + " + reader.GetString(3);
                }
                else
                {
                    sotien = " - " + reader.GetString(3);
                }
                string testfull = "Số dư TK UIT " +ID+sotien+". vào lúc: "+ngay+".Số dư: "+sodu+". Người nhận là "+nhan+"nội dung chuyển khoảng là:  "+ nd+".";
                add(testfull);
            }
            reader.Close();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
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

            cmd.CommandText = "select * from tinnhan where id='" + ID + "' and daxem=0 ORDER BY ngay DESC";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nhan = reader.GetString(2);
                string ngay = reader.GetDateTime(5).ToString();
                string sodu = reader.GetString(4);
                string nd = reader.GetString(6);
                string[] dates = ngay.ToString().Split(' ');
                Boolean dau = reader.GetBoolean(1);
                if (dau == true)
                {
                    sotien = " + " + reader.GetString(3);
                }
                else
                {
                    sotien = " - " + reader.GetString(3);
                }
                string testfull = "Số dư TK UIT " + ID + sotien + ". vào lúc: " + ngay + ".Số dư: " + sodu + ". Người nhận là " + nhan + "nội dung chuyển khoảng là:  " + nd + ".";
                add(testfull);
            }
            reader.Close();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
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

            cmd.CommandText = "select * from tinnhan where id='" + ID + "' and daxem=1 ORDER BY ngay DESC";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nhan = reader.GetString(2);
                string ngay = reader.GetDateTime(5).ToString();
                string sodu = reader.GetString(4);
                string nd = reader.GetString(6);
                string[] dates = ngay.ToString().Split(' ');
                Boolean dau = reader.GetBoolean(1);
                if (dau == true)
                {
                    sotien = " + " + reader.GetString(3);
                }
                else
                {
                    sotien = " - " + reader.GetString(3);
                }
                string testfull = "Số dư TK UIT " + ID + sotien + ". vào lúc: " + ngay + ".Số dư: " + sodu + ". Người nhận là " + nhan + "nội dung chuyển khoảng là:  " + nd + ".";
                add(testfull);
            }
            reader.Close();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ThongBao_Load(sender, e);
        }
    }
}
