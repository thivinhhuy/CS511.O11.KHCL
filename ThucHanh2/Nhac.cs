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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using CustomControls.RJControls;

namespace thuchanh2
{
    public partial class Nhac : Form
    {
        public Nhac()
        {
            InitializeComponent();
        }


        public string TenNhacvideo;
        public string tenvideo;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string strCon = @"Data Source=LAPTOP-24A31P93;Initial Catalog=datavideo;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void formload(object sender, EventArgs e)
        {


        }

        private void load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = tenvideo;
            viewlabel();
            daxem();
            loadPL();
        }
        private void viewlabel()

        {

            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from datafull where pathvideo = '" + TenNhacvideo + "'";
            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                label5.Text = reader.GetString(2);
                label1.Text = reader.GetString(2);
            }
            reader.Close();

        }

        private void daxem()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }


            label7.Text = TenNhacvideo;
            label4.Text = TenNhacvideo;


            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "update datafull set daxem = 1 where pathvideo = '" + TenNhacvideo + "'";
            sqlCmd.Connection = sqlCon;


            int kq = sqlCmd.ExecuteNonQuery();


        }




        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {


        }

        private void rjRadioButton1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            


        }
        private void ckeckBox1(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked==true)
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
                sqlCmd.CommandText = "update datafull set yeuthich = 1 where pathvideo = '" + TenNhacvideo + "'";
                sqlCmd.Connection = sqlCon;

                int kq = sqlCmd.ExecuteNonQuery();

            }

            if (checkBox1.Checked==false)
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
                sqlCmd.CommandText = "update datafull set yeuthich = NULL where pathvideo = '" + TenNhacvideo + "'";
                sqlCmd.Connection = sqlCon;

                int kq = sqlCmd.ExecuteNonQuery();

            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //I declare first my variables
            string sourcePath = @"D:\2023-2024_HKI\C#\TH2_video";
            string targetPath = @"D:\Downloads";
            string TenNhacdown = TenNhacvideo + ".mp4";
            MessageBox.Show("Đã lưu trong " + targetPath);

            string destFile = Path.Combine(targetPath, TenNhacdown);
            string sourceFile = Path.Combine(sourcePath, TenNhacdown);

            // To copy a folder's contents to a new location:
            // Create a new target folder, if necessary.
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            // To copy a file to another location and 
            // overwrite the destination file if it already exists.
            File.Copy(sourceFile, destFile, true);
        }

        private void rjTextBox3_Enter(object sender, EventArgs e)
        {

        }
        void adnu(string Mess)
        {
            var bubble = new chatbotn();
            panel1.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.mess = Mess;

        }
        void adnam(string Mess)
        {
            var bubble = new chatbot();
            panel1.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.mess = Mess;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string seen = rjTextBox3.Texts+" - " + comboBox1.Text;
            if (checkBox3.Checked == true)
            {
                if (rjTextBox3.Texts.Length == 0) return;
                adnam(seen);
                rjTextBox3.Text = string.Empty;

            }
            if (checkBox4.Checked == true)
            {
                if (rjTextBox3.Texts.Length == 0) return;
                adnu(seen);
                rjTextBox3.Text = string.Empty;

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        public string[] danhssachplaylist;
        SqlConnection sqlCond = null;

        string tenimg;


        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=playlist;Integrated Security=True";
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void loadPL()
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
            cmd.CommandText = "select name from sysobjects where xtype = 'U'";
            cmd.Connection = sqlCond;

            SqlDataReader reader = cmd.ExecuteReader();
            List<string> list1 = new List<string>();
            while (reader.Read())
            {
                list1.Add(reader.GetString(0));
            }
            comboBox2.DataSource = list1;


            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select pathimg from datafull where pathvideo = '" + TenNhacvideo + "'";
            cmd.Connection = sqlCon;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tenimg = reader.GetString(0);
            }
            reader.Close();

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
            sqlCmd.CommandText = "INSERT INTO " + comboBox2.Text + " values ('" + tenimg + "')";
            sqlCmd.Connection = sqlCond;
            int kq = sqlCmd.ExecuteNonQuery();

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
