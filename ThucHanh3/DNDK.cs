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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Xml.Schema;
using static thuchanh3.Program;

namespace thuchanh3
{
    public partial class DNDK : Form
    {
        public DNDK()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=Bank;Integrated Security=True";
        private void label3_Click(object sender, EventArgs e)
        {
            DK dK = new DK();
            dK.ShowDialog();
        }
        int flat;
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
            cmd.CommandText = "select * from acc where id= '"+rjTextBox1.Texts+"'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.Read())
            {
                if (rjTextBox2.Text == reader.GetString(4))
                {
                    idload(rjTextBox1.Texts);
                    Globals.idglob = rjTextBox1.Texts;
                }
            }
            reader.Close();


        }
        private void idload(string id)
        {
            CK cK = new CK();
            cK.ID = id;
            Form1 form1 = new Form1();
            form1.ID = id;
            form1.Show();
            SaoKe saoKe = new SaoKe();
            saoKe.ID = id;
            ThongBao thongBao = new ThongBao();
            thongBao.ID = id;
            TietKiem tietKiem = new TietKiem();
            tietKiem.ID = id;
            this.Close();
        }
        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_Enter(object sender, EventArgs e)
        {
            if (rjTextBox1.Texts== "Nhập số điện thoại")
            {
                rjTextBox1.Texts = "";
                rjTextBox1.ForeColor = Color.Black;
            }
        }

        private void rjTextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace("Nhập số điện thoại"))
            {
                rjTextBox1.Texts = "Nhập số điện thoại";
                rjTextBox1.ForeColor = Color.Gray;
            }
        }

        private void rjTextBox2_Enter(object sender, EventArgs e)
        {
            if (rjTextBox2.Text == "Nhập mật khẩu")
            {
                rjTextBox2.Text = "";
                rjTextBox2.ForeColor = Color.Black;
            }
        }

        private void rjTextBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace("Nhập mật khẩu"))
            {
                rjTextBox2.Text = "Nhập mật khẩu";
                rjTextBox2.ForeColor = Color.Gray;
            }
        }
    }
}
