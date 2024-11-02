using Doan.Vietbai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Doan.Chat;

namespace Doan
{
    public partial class FormCaNhan : Form
    {
        public FormCaNhan()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            
        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";

        string URL = @"D:\2023-2024_HKI\C#\report\acc\";
        string[] listanh = new string[5];
        private void FormCaNhan_Load(object sender, EventArgs e)
        {
            string ten = Program.ID.Ten;
            vietbai.Controls.Clear();
            addbaiviet();
            panel7.Visible = false;
            pictureBox1.Image =  Image.FromFile(URL + ten + ".jpg");
            TenNguoiDung.Text = ten;
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
            cmd.CommandText = "select * from info where Ten = '" + Program.ID.Ten + "'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            string urlinfo = @"D:\2023-2024_HKI\C#\report\info\";
            string urlacc = @"D:\2023-2024_HKI\C#\report\acc\";

            if (reader.Read())
            {
                pictureBox2.Image = Image.FromFile(urlinfo + reader.GetString(4) + ".jpg");
                pictureBox3.Image = Image.FromFile(urlinfo + reader.GetString(5) + ".jpg");
                pictureBox4.Image = Image.FromFile(urlinfo + reader.GetString(6) + ".jpg");
                pictureBox7.Image = Image.FromFile(urlinfo + reader.GetString(7) + ".jpg");
                pictureBox6.Image = Image.FromFile(urlinfo + reader.GetString(8) + ".jpg");

                listanh[0] = urlinfo + reader.GetString(4) + ".jpg";
                listanh[1] = urlinfo + reader.GetString(5) + ".jpg";
                listanh[2] = urlinfo + reader.GetString(6) + ".jpg";
                listanh[3] = urlinfo + reader.GetString(7) + ".jpg";
                listanh[4] = urlinfo + reader.GetString(8) + ".jpg";
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
            string ten = Program.ID.Ten;
            Image avt = Image.FromFile(URL + ten + ".jpg");
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
            cmd.CommandText = "select * from BaiViet where ten = '" + ten + "'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                if (reader.GetInt32(10) == 1)
                {

                    string url = @"D:\2023-2024_HKI\C#\report\sqlimg\";

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
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            FormXemAnh  formXemAnh = new FormXemAnh();
            formXemAnh.listanh = listanh;
            formXemAnh.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void rjButton10_Click(object sender, EventArgs e)
        {

        }

        private void rjButton9_Click(object sender, EventArgs e)
        {

        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {

        }

        private void rjButton6_Click(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rJtext1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            FormVideo formVideo = new FormVideo();      
            formVideo.Show();
            this.Close();   
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();       
        }

        private void rjButton13_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp;)|*.png;*.jpg;*.jpeg;*.gif;*.bmp;";
            openFileDialog.Multiselect = false;

            rjButton1.Visible = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                foreach (string filePath in openFileDialog.FileNames)
                {
                    pictureBox1.Image = Image.FromFile(filePath);
                }

            }
        }

        private void rjButton12_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void rjButton14_Click(object sender, EventArgs e)
        {
            //doi acc
            
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
            cmd.CommandText = "update acc set Ten = '"+rJtext2.Texts+"' , avt ='"+ rJtext2.Texts + "' where Ten ='"+Program.ID.Ten+"' ";
            cmd.Connection = sqlCond;
            cmd.ExecuteNonQuery();
            //doi BaiViet
            if (sqlCond == null)
            {
                sqlCond = new SqlConnection(strCond);
            }
            if (sqlCond.State == ConnectionState.Closed)
            {
                sqlCond.Open();
            }

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update BaiViet set ten = '" + rJtext2.Texts + "' , avt ='" + rJtext2.Texts + "' where ten ='" + Program.ID.Ten + "' ";
            cmd.Connection = sqlCond;
            cmd.ExecuteNonQuery();


            //doi cmt
            if (sqlCond == null)
            {
                sqlCond = new SqlConnection(strCond);
            }
            if (sqlCond.State == ConnectionState.Closed)
            {
                sqlCond.Open();
            }

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update cmt set ten = '" + rJtext2.Texts + "' , avt ='" + rJtext2.Texts + "' where ten ='" + Program.ID.Ten + "' ";
            cmd.Connection = sqlCond;
            cmd.ExecuteNonQuery();
            //doi Id
            if (sqlCond == null)
            {
                sqlCond = new SqlConnection(strCond);
            }
            if (sqlCond.State == ConnectionState.Closed)
            {
                sqlCond.Open();
            }

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update ID set ten = '" + rJtext2.Texts + "'  where ten ='" + Program.ID.Ten + "' ";
            cmd.Connection = sqlCond;
            cmd.ExecuteNonQuery();
            //doi info
            if (sqlCond == null)
            {
                sqlCond = new SqlConnection(strCond);
            }
            if (sqlCond.State == ConnectionState.Closed)
            {
                sqlCond.Open();
            }

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update info set Ten = '" + rJtext2.Texts + "'  where Ten ='" + Program.ID.Ten + "' ";
            cmd.Connection = sqlCond;
            cmd.ExecuteNonQuery();
            //doi thich
            if (sqlCond == null)
            {
                sqlCond = new SqlConnection(strCond);
            }
            if (sqlCond.State == ConnectionState.Closed)
            {
                sqlCond.Open();
            }

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update thich set Ten = '" + rJtext2.Texts + "'  where Ten ='" + Program.ID.Ten + "' ";
            cmd.Connection = sqlCond;
            cmd.ExecuteNonQuery();
            panel7.Visible = false;
            Program.ID.Ten = rJtext2.Texts;
            TenNguoiDung.Text = rJtext2.Texts;
        }
    }
}