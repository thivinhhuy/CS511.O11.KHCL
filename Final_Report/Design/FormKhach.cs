using Doan.Vietbai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan
{
    public partial class FormKhach : Form
    {
        public string ten;
        public Image avt;
        public FormKhach()
        {
            InitializeComponent();
        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";
        private void FormKhach_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = avt;
            TenNguoiDung.Text = ten;
            addbaiviet();
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
            cmd.CommandText = "select * from info where Ten = '" + ten + "'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            string urlinfo = @"D:\2023-2024_HKI\C#\report\info\";
            string urlacc = @"D:\2023-2024_HKI\C#\report\acc\";
            if (reader.Read())
            {
                pictureBox2.Image = Image.FromFile(urlinfo + reader.GetString(4)+ ".jpg");
                pictureBox3.Image = Image.FromFile(urlinfo + reader.GetString(5) + ".jpg");
                pictureBox4.Image = Image.FromFile(urlinfo + reader.GetString(6) + ".jpg");
                pictureBox5.Image = Image.FromFile(urlinfo + reader.GetString(7) + ".jpg");
                pictureBox6.Image = Image.FromFile(urlinfo + reader.GetString(8) + ".jpg");
                pictureBox11.Image = Image.FromFile(urlacc + reader.GetString(9) + ".jpg");
                pictureBox12.Image = Image.FromFile(urlacc + reader.GetString(11) + ".jpg");
                pictureBox13.Image = Image.FromFile(urlacc + reader.GetString(12) + ".jpg");
                label1.Text = reader.GetString(1);
                label9.Text = reader.GetString(2);
                label10.Text = reader.GetString(3);

            }    
            reader.Close();
        }
        void addbaiviet()
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
            cmd.CommandText = "select * from BaiViet where ten = '"+ten+"'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                if (reader.GetInt32(10) == 1)
                {

                    string url = @"D:\2023-2024_HKI\C#\report\sqlimg\";
                    MessageBox.Show(ten);
                    switch (reader.GetInt32(8))
                    {

                        case 1:
                            var bubble = new Vietbai.BaiViet_Anh_();
                            vietbai.Controls.Add(bubble);
                            bubble.SendToBack();
                            bubble.Dock = DockStyle.Top;
                            bubble.AVT = avt;
                            bubble.TenNguoiDungText = reader.GetString(1);
                            bubble.ThoiGianText = reader.GetDateTime(6).ToString();
                            bubble.BaiVietText = reader.GetString(7);

                            bubble.AnhImg = Image.FromFile(url + reader.GetString(3) + ".jpg");


                            break;
                        case 2:
                            var bubble2 = new Vietbai.BaiViet_2Anh_();
                            vietbai.Controls.Add(bubble2);
                            bubble2.SendToBack();
                            bubble2.Dock = DockStyle.Top;
                            bubble2.AVT = avt;
                            bubble2.TenNguoiDungText = reader.GetString(1);
                            bubble2.ThoiGianText = reader.GetDateTime(6).ToString();
                            bubble2.BaiVietText = reader.GetString(7);

                            bubble2.AnhImg = Image.FromFile(url + reader.GetString(3) + ".jpg");
                            bubble2.Anh2Img = Image.FromFile(url + reader.GetString(4) + ".jpg");
                            break;
                        case 3:
                            var bubble3 = new Vietbai.BaiViet_3Anh_();
                            vietbai.Controls.Add(bubble3);
                            bubble3.SendToBack();
                            bubble3.Dock = DockStyle.Top;
                            bubble3.AVT = avt;
                            bubble3.TenNguoiDungText = reader.GetString(1);
                            bubble3.ThoiGianText = reader.GetDateTime(6).ToString();
                            bubble3.BaiVietText = reader.GetString(7);

                            bubble3.AnhImg = Image.FromFile(url + reader.GetString(3) + ".jpg");
                            bubble3.Anh2Img = Image.FromFile(url + reader.GetString(4) + ".jpg");
                            bubble3.Anh3Img = Image.FromFile(url + reader.GetString(5) + ".jpg");
                            break;
                    }
                }
                else
                {
                    var bubble = new BaiViet_Vid_();
                    vietbai.Controls.Add(bubble);
                    bubble.SendToBack();
                    bubble.Dock = DockStyle.Top;
                    bubble.AVT = avt;
                    bubble.TenNguoiDungText = reader.GetString(1);
                    bubble.ThoiGianText = reader.GetDateTime(6).ToString();
                    bubble.BaiVietText = reader.GetString(7);

                    bubble.VideoUrl = 1.ToString();
                }
            }
            reader.Close();





        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
