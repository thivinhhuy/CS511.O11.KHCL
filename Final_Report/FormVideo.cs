using Doan.Vietbai;
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

namespace Doan
{
    public partial class FormVideo : Form
    {
        public FormVideo()
        {
            InitializeComponent();
        }

        private void FormVideo_Load(object sender, EventArgs e)
        {

        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";
        void adduser(string ten, Image Avatar)
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
            cmd.CommandText = "select * from baiviet";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var bubble = new BaiViet_Vid_();
                panel2.Controls.Add(bubble);
                bubble.SendToBack();
                bubble.Dock = DockStyle.Top;
                bubble.AVT = Image.FromFile(reader.GetString(2));
                bubble.TenNguoiDungText = reader.GetString(1);
                bubble.ThoiGianText = reader.GetString(6);
                bubble.BaiVietText = reader.GetString(7);

                bubble.VideoUrl = reader.GetString(3);

            }
            reader.Close();
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Close();
        }
    }
}
