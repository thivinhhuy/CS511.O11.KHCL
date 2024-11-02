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
using static Doan.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Security.Policy;
using System.IO;
using System.Collections;

namespace Doan
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";
        string Url = @"D:\2023-2024_HKI\C#\report\acc\";
        string ID;
        
        public void Form1_Load(object sender, EventArgs e)
        {
            panel6.Visible = false;
            vietbai.Controls.Clear();   
            panel5.Visible = false;
            label1.Text = Program.ID.Ten;
            pictureBox11.Image = Image.FromFile(Url + Program.ID.Ten + ".jpg");
            pictureBox8.Image = Image.FromFile(Url + Program.ID.Ten + ".jpg");

            Checkchat.refer = 0;
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
            cmd.CommandText = "select * from acc";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if(reader.GetString(0) != Program.ID.Ten)
                {
                    string im = Url + reader.GetString(1) + ".jpg";
                    Image img = Image.FromFile(im);
                    adduser(reader.GetString(0), img);
                    
                }    

            }
            
            reader.Close();
            addvietbai(Program.ID.Ten, Image.FromFile(Url +Program.ID.Ten + ".jpg"));
            addbaiviet();

            timer1.Start();


        }

        public void addbaiviet()
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
            cmd.CommandText = "select * from BaiViet order by thoigian DESC";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string url = @"D:\2023-2024_HKI\C#\report\sqlimg\";
                if (reader.GetInt32(9) == 1 && reader.GetString(1) != Program.ID.Ten)
                {
                    continue;

                }
                else
                {
                    ID = reader.GetString(0);
                    if (reader.GetInt32(10) == 1)
                    {
                        
                        switch (reader.GetInt32(8))
                        {
                            case 1:
                                var bubble = new Vietbai.BaiViet_Anh_();
                                bubble.Id = Convert.ToInt32(reader.GetString(0));
                                vietbai.Controls.Add(bubble);
                                bubble.SendToBack();
                                bubble.Dock = DockStyle.Top;
                                bubble.AVT = Image.FromFile(Url + reader.GetString(2) + ".jpg");
                                bubble.TenNguoiDungText = reader.GetString(1);
                                bubble.ThoiGianText = reader.GetDateTime(6).ToString();
                                bubble.BaiVietText = reader.GetString(7);
                                bubble.CheDO = Image.FromFile(url + "chedo" + reader.GetInt32(9) + ".png");
                                bubble.AnhImg = Image.FromFile(url + reader.GetString(3) + ".jpg");
                                break;
                            case 2:
                                var bubble2 = new Vietbai.BaiViet_2Anh_();
                                bubble2.Id = Convert.ToInt32(reader.GetString(0));
                                vietbai.Controls.Add(bubble2);
                                bubble2.SendToBack();
                                bubble2.Dock = DockStyle.Top;
                                bubble2.AVT = Image.FromFile(Url + reader.GetString(2) + ".jpg");
                                bubble2.TenNguoiDungText = reader.GetString(1);
                                bubble2.ThoiGianText = reader.GetDateTime(6).ToString();
                                bubble2.BaiVietText = reader.GetString(7);
                                bubble2.CheDO = Image.FromFile(url + "chedo" + reader.GetInt32(9) + ".png");
                                bubble2.AnhImg = Image.FromFile(url + reader.GetString(3) + ".jpg");
                                bubble2.Anh2Img = Image.FromFile(url + reader.GetString(4) + ".jpg");
                                break;
                            case 3:
                                var bubble3 = new Vietbai.BaiViet_3Anh_();
                                bubble3.Id = Convert.ToInt32(reader.GetString(0));
                                vietbai.Controls.Add(bubble3);
                                bubble3.SendToBack();
                                bubble3.Dock = DockStyle.Top;
                                bubble3.AVT = Image.FromFile(Url + reader.GetString(2) + ".jpg");
                                bubble3.TenNguoiDungText = reader.GetString(1);
                                bubble3.ThoiGianText = reader.GetDateTime(6).ToString();
                                bubble3.BaiVietText = reader.GetString(7);

                                bubble3.CheDO = Image.FromFile(url + "chedo" + reader.GetInt32(9) + ".png");
                                bubble3.AnhImg = Image.FromFile(url + reader.GetString(3) + ".jpg");
                                bubble3.Anh2Img = Image.FromFile(url + reader.GetString(4) + ".jpg");
                                bubble3.Anh3Img = Image.FromFile(url + reader.GetString(5) + ".jpg");
                                break;
                            default:

                                var bubble4 = new BaiViet_nAnh_();
                                bubble4.Id = Convert.ToInt32(reader.GetString(0));
                                vietbai.Controls.Add(bubble4);
                                bubble4.SendToBack();
                                bubble4.Dock = DockStyle.Top;
                                bubble4.AVT = Image.FromFile(Url + reader.GetString(2) + ".jpg");
                                bubble4.TenNguoiDungText = reader.GetString(1);
                                bubble4.ThoiGianText = reader.GetDateTime(6).ToString();
                                bubble4.BaiVietText = reader.GetString(7);

                                bubble4.CheDO = Image.FromFile(url + "chedo" + reader.GetInt32(9) + ".png");

                                string urlnhieuanh = @"D:\2023-2024_HKI\C#\report\nhieuanh\";
                                string floderanh = reader.GetString(3);

                                string[] Fullpathlist = Directory.GetFiles(urlnhieuanh + floderanh, "*.jpg", SearchOption.AllDirectories);

                                bubble4.AnhImg = Image.FromFile(Fullpathlist[0]);
                                bubble4.Anh2Img = Image.FromFile(Fullpathlist[1]);
                                bubble4.Anh3Img = Image.FromFile(Fullpathlist[2]);
                                bubble4.ListAnh = Fullpathlist;
                                bubble4.Soanh = reader.GetInt32(8);
                                break;

                        }
                    }
                    if(reader.GetInt32(10) == 2)
                    {
                        var bubble = new BaiViet_ChiaSe_();

                        bubble.Id = Convert.ToInt32(reader.GetString(0));
                        bubble.idbaiviet = reader.GetString(3); 
                        vietbai.Controls.Add(bubble);
                        bubble.SendToBack();
                        bubble.CHEDO = Image.FromFile(url + "chedo" + reader.GetInt32(9) + ".png");
                        bubble.AVT = Image.FromFile(Url + reader.GetString(2) + ".jpg");
                        bubble.TenNguoiDungText = reader.GetString(1);
                        bubble.ThoiGianText = reader.GetDateTime(6).ToString();
                        bubble.BaiVietText = reader.GetString(7);


                    }    
                    if (reader.GetInt32(10) == 0)
                    {
                        var bubble = new BaiViet_Vid_();
                        bubble.Id = Convert.ToInt32(reader.GetString(0));
                        bubble.videoURL = url + reader.GetString(3) + ".mp4";
                        vietbai.Controls.Add(bubble);
                        bubble.SendToBack();
                        bubble.Dock = DockStyle.Top;
                        bubble.CheDO = Image.FromFile(url + "chedo" + reader.GetInt32(9) + ".png");
                        bubble.AVT = Image.FromFile(Url + reader.GetString(2) + ".jpg");
                        bubble.TenNguoiDungText = reader.GetString(1);
                        bubble.ThoiGianText = reader.GetDateTime(6).ToString();
                        bubble.BaiVietText = reader.GetString(7);

                    }
                }
            }
            reader.Close();

            Program.ID.id = Convert.ToInt32(ID);



        }
        public void addvietbai(string Ten, Image Avt)
        {
            var bubble = new Vietbai.Vietbai();
            vietbai.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.TenNguoiDungText = Ten;
            bubble.AVT = Avt;
        }
        void adduser(string ten, Image Avatar)
        {
            var bubble = new ChatUser();
            panel2.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.avatar = Avatar;
            bubble.mess = ten;     
        }
        void add()
        {
            var bubble = new Chat();
            panel4.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            panel4.Visible=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Checkchat.refer == 1)
            {
                panel4.Visible = true;
                panel4.Controls.Clear();
                add();
                
            }
            else
            {
                panel4.Visible = false;
            }    
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FormCaNhan formCaNhan = new FormCaNhan();
            formCaNhan.Show();
            this.Close();   

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            FormVideo formVideo = new FormVideo();
            formVideo.Show();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormVideo formVideo = new FormVideo();
            formVideo.Show();
            this.Close();

        }
        int caidat = 0;
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            caidat = caidat + 1;
            if (caidat % 2 == 1)
            {
                panel5.Visible = true;

            }
            else
            {
                panel5.Visible=false;
            }    
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            FormVideo formVideo = new FormVideo();
            formVideo.Show();
            this.Close();

        }

        private void Tat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }


        private void rjText1_TextChanged(object sender, EventArgs e)
        {

        }
        void addusersearch(string ten, Image Avatar)
        {
            var bubble = new ChatUser();
            panel6.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.avatar = Avatar;
            bubble.mess = ten;
        }
        private void rJtext1__TextChanged(object sender, EventArgs e)
        {
            panel6.Controls.Clear();
            panel6.Visible = true;

            if (rJtext1.Texts == string.Empty)
            {
                panel6.Visible = false;
            }
            else
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
                cmd.CommandText = "select * from ID where ten like  '" + rJtext1.Texts + "%' or sdt like '" + rJtext1.Texts + "%'";
                cmd.Connection = sqlCond;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    addusersearch(reader.GetString(1), Image.FromFile(Url + reader.GetString(1) +".jpg"));
                }
                reader.Close();
            }
        }
    }
}
