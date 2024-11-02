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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static thuchanh3.Program;

namespace thuchanh3
{
    
    public partial class CK : Form
    {
        public string ID = Globals.idglob;
        public string tennganhang;
        public string sotaikhoan;
        public CK()
        {
            InitializeComponent();
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

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TietKiem tietKiem = new TietKiem();
            tietKiem.ID = ID;
            tietKiem.Show();
            this.Close();
        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=Bank;Integrated Security=True";
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SaoKe saoKe = new SaoKe();
            saoKe.ID = ID;
            saoKe.Show();
            this.Close();
        }

        private void CK_Load(object sender, EventArgs e)
        {
            rjTextBox3.Texts = sotaikhoan;
            comboBox1.Text = tennganhang;
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
            cmd.CommandText = "select * from acc where id = '"+ID+"'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                TKN.Texts = reader.GetString(0);
                label13.Text = reader.GetString(1);
            }
            reader.Close();

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from TKCK";
            cmd.Connection = sqlCond;
            reader = cmd.ExecuteReader();
            List<string> NHs = new List<string>();
            while(reader.Read())
            {
                NHs.Add(reader.GetString(2));
                
            }
            comboBox1.DataSource = NHs;
            comboBox1.Text = tennganhang;
            reader.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox3_Enter(object sender, EventArgs e)
        {

        }
        int flat = 1;
        private void rjTextBox3_Leave(object sender, EventArgs e)
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
            cmd.CommandText = "select * from TKCK ";
            cmd.Connection = sqlCond;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (rjTextBox3.Texts == reader.GetString(0) && comboBox1.Text == reader.GetString(2))
                    {
                    label15.Text = reader.GetString(1);
                    label15.ForeColor = System.Drawing.Color.Cyan;
                    break;
                }
                else
                {
                    label15.Text = "Tài khoản không tồn tại";
                }    
                
            }


            reader.Close();
        }
        string tientong;
        int tientru;
        private void rjButton1_Click(object sender, EventArgs e)
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
            cmd.CommandText = "select * from acc where id ='"+ID+"'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
               tientong =  reader.GetString(1);
            }
            reader.Close();
            if (Int32.Parse(tientong) > Int32.Parse(rjTextBox4.Texts))
            {
                tientru = Int32.Parse(tientong) - Int32.Parse(rjTextBox4.Texts);
                SqlCommand sqlCmdd = new SqlCommand();
                sqlCmdd.CommandType = CommandType.Text;
                sqlCmdd.CommandText = "update acc set sotien = '" + tientru + "'where id = '"+ID+"'";
                sqlCmdd.Connection = sqlCond;
                sqlCmdd.ExecuteNonQuery();

                DateTime todaysDate = DateTime.Now;
                string[] dates = todaysDate.ToString().Split(' ');
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO tinnhan VALUES (" + ID + "," + 0 + "," + rjTextBox3.Texts + "," + rjTextBox4.Texts +
                                                                "," + tientru + ",'" + dates[0] + "','" + nd.Texts + "',NULL)";
                sqlCmd.Connection = sqlCond;
                int kq = sqlCmd.ExecuteNonQuery();
                TBCK tBCK = new TBCK();
                tBCK.tien = rjTextBox4.Texts;
                tBCK.ngay = todaysDate.ToString();
                tBCK.TK = rjTextBox3.Texts;
                tBCK.NH = comboBox1.Text;
                tBCK.ND = nd.Texts;
                tBCK.ten = label15.Text;
                tBCK.ID = ID;
                tBCK.sodu = tientru.ToString();
                tBCK.Show();
                this.Close();

            }    
            else
            {
                rjTextBox4.Texts = string.Empty;
                MessageBox.Show("Số dư khong đủ");
            }



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
