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
using AForge.Video;
using AForge.Video.DirectShow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static thuchanh3.Program;

namespace thuchanh3
{
    public partial class Form1 : Form
    {
        public string ID = Globals.idglob;
        public Form1()
        {
            
            InitializeComponent();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=Bank;Integrated Security=True";
        private void load(object sender, EventArgs e)
        {
            panel4.Visible = false;
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
                rjTextBox1.Texts = reader.GetString(2);
                rjTextBox2.Texts = reader.GetString(1);
                rjTextBox3.Texts = reader.GetString(3);
                rjTextBox4.Texts = reader.GetString(0);
            }
            reader.Close();
            


        }
        private void loadtien()
        {
            
        }

        private void xemthem_Click(object sender, EventArgs e)
        {
            panel4.Visible=true;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ThongBao thongBao = new ThongBao();
            thongBao.ID = ID;
            thongBao.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            QRcode qR = new QRcode();
            qR.Show();
            qR.ID = ID;
            this.Close();
        }

        private void rjTextBox3__TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            QRcode qRcode = new QRcode();
            qRcode.ID = ID;
            qRcode.Show();
            this.Close();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Taikhoan taikhoan = new Taikhoan();
            taikhoan.ID = ID;
            taikhoan.Show();
            this.Close();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
