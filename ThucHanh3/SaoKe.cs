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
using System.Windows.Forms.DataVisualization.Charting;
using static thuchanh3.Program;

namespace thuchanh3
{
    public partial class SaoKe : Form
    {
        public string ID = Globals.idglob;
        public SaoKe()
        {
            InitializeComponent();
        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=Bank;Integrated Security=True";
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

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
        private void load()
        {


        }

        void add(string Mess, string Mess1, string Mess2)
        {
            var bubble = new TB();
            panel2.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.mess = Mess;
            bubble.mess1 = Mess1;
            bubble.mess2 = Mess2;

        }
        string sotien;
        private void SaoKe_Load(object sender, EventArgs e)
        {
            chartControl.Visible = false;
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

            cmd.CommandText = "select * from tinnhan where id='"+ID+ "' ORDER BY ngay DESC";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nhan = reader.GetString(2);
                string ngay = reader.GetDateTime(5).ToString();
                string[] dates = ngay.ToString().Split(' ');
                Boolean dau = reader.GetBoolean(1);
                if (dau == true)
                {
                    sotien = "+ "+ reader.GetString(3);
                }
                else
                {
                    sotien = "- " + reader.GetString(3);
                }

                add(dates[0], nhan, sotien);
            }
            reader.Close();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            chartControl.Visible = false;
            panel2.Controls.Clear();
            DateTime Date1 = dateTimePicker1.Value;
            DateTime Date2 = dateTimePicker2.Value;
            string[] date1 = Date1.ToString().Split(' ');
            string[] date2 = Date2.ToString().Split(' ');
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
            cmd.CommandText = "select  * from tinnhan where ngay between '" + date1[0] +"' and '" + date2[0] +"'  and id = '"+ID+ "' ORDER BY ngay DESC";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nhan = reader.GetString(2);
                string ngay = reader.GetDateTime(5).ToString();
                string[] dates = ngay.ToString().Split(' ');
                Boolean dau = reader.GetBoolean(1);
                if (dau == true)
                {
                    sotien = "+ " + reader.GetString(3);
                }
                else
                {
                    sotien = "- " + reader.GetString(3);
                }

                add(dates[0], nhan, sotien);
            }
            reader.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            chartControl.Visible = false;   
            panel2.Controls.Clear();
            DateTime Date1 = dateTimePicker1.Value;
            DateTime Date2 = dateTimePicker2.Value;
            string[] date1 = Date1.ToString().Split(' ');
            string[] date2 = Date2.ToString().Split(' ');
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
            cmd.CommandText = "select  * from tinnhan where ngay between '" + date1[0] + "' and '" + date2[0] + "'  and id = '" + ID + "' ORDER BY ngay DESC";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nhan = reader.GetString(2);
                string ngay = reader.GetDateTime(5).ToString();
                string[] dates = ngay.ToString().Split(' ');
                Boolean dau = reader.GetBoolean(1);
                if (dau == false)
                {
                    sotien = "- " + reader.GetString(3);
                }
                add(dates[0], nhan, sotien);
            }
            reader.Close();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            DateTime Date1 = dateTimePicker1.Value;
            DateTime Date2 = dateTimePicker2.Value;
            string[] date1 = Date1.ToString().Split(' ');
            string[] date2 = Date2.ToString().Split(' ');
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
            cmd.CommandText = "select  * from tinnhan where ngay between '" + date1[0] + "' and '" + date2[0] + "'  and id = '" + ID + "' ORDER BY ngay DESC";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nhan = reader.GetString(2);
                string ngay = reader.GetDateTime(5).ToString();
                string[] dates = ngay.ToString().Split(' ');
                Boolean dau = reader.GetBoolean(1);
                if (dau == true)
                {
                    sotien = "+ " + reader.GetString(3);
                }
                add(dates[0], nhan, sotien);
            }
            reader.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {

            panel2.Controls.Clear();
            chartControl.Visible = true;
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
            cmd.CommandText = "select  * from tinnhan where  id = '" + ID + "' ORDER BY ngay DESC";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> ngays = new List<string>();
            List<int> sotienchuyen = new List<int>();
            string daut;
            while (reader.Read())
            {
                ngays.Add(reader.GetDateTime(5).ToString());
                Boolean dau = reader.GetBoolean(1);

                if (dau == true)
                {
                    sotienchuyen.Add(Int32.Parse(reader.GetString(3)));
                }
                else
                {
                    sotienchuyen.Add(0 - Int32.Parse(reader.GetString(3)));
                
                }    

            }

            reader.Close();
            this.chartControl.Titles.Add("Sao kê số tiền chuyển");

            // Add series.
            for (int i = 0; i < ngays.Count; i++)
            {
                Series series = this.chartControl.Series.Add(ngays[i]);
                series.Points.Add(sotienchuyen[i]);
            }


        }
    }
}
