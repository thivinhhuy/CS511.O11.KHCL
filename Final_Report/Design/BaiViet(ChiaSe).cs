using Doan.Vietbai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Doan.Program;

namespace Doan
{
    public partial class BaiViet_ChiaSe_ : UserControl
    {
        public BaiViet_ChiaSe_()
        {
            InitializeComponent();
        }
        public string idbaiviet;


        public int Id;
        public string BaiVietText
        {
            get
            {
                return BaiViet.Text;
            }
            set
            {
                BaiViet.Text = value;
            }
        }
        public string TenNguoiDungText
        {
            get
            {
                return TenNguoiDung.Text;
            }
            set
            {
                TenNguoiDung.Text = value;
            }
        }
        public string ThoiGianText
        {
            get
            {
                return ThoiGian.Text;
            }
            set
            {
                ThoiGian.Text = value;
            }
        }
        public Image CHEDO
        {
            get
            {
                return CheDo.Image;
            }
            set
            {
                CheDo.Image = value;
            }
        }

        public Image AVT
        {
            get
            {
                return Avt.Image;
            }
            set
            {
                Avt.Image = value;
            }
        }

        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";
        string Url = @"D:\2023-2024_HKI\C#\report\acc\";
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
            cmd.CommandText = "select * from BaiViet where ID = '"+idbaiviet+"'";
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
                    if (reader.GetInt32(10) == 1)
                    {

                        switch (reader.GetInt32(8))
                        {
                            case 1:
                                var bubble = new Vietbai.BaiViet_Anh_();
                                bubble.XoaControl("panel1");
                                bubble.XoaControl("SoThich");
                                bubble.XoaControl("socmt");
                                bubble.XoaControl("pictureBox1");
                                bubble.XoaControl("pictureBox2");
                                bubble.XoaControl("panel2");
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
                                bubble2.XoaControl("panel1");
                                bubble2.XoaControl("SoThich");
                                bubble2.XoaControl("socmt");
                                bubble2.XoaControl("pictureBox1");
                                bubble2.XoaControl("pictureBox2");
                                bubble2.XoaControl("panel2");
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
                                bubble3.XoaControl("panel1");
                                bubble3.XoaControl("SoThich");
                                bubble3.XoaControl("socmt");
                                bubble3.XoaControl("pictureBox1");
                                bubble3.XoaControl("pictureBox2");
                                bubble3.XoaControl("panel2");
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
                                bubble4.XoaControl("panel1");
                                bubble4.XoaControl("SoThich");
                                bubble4.XoaControl("socmt");
                                bubble4.XoaControl("pictureBox1");
                                bubble4.XoaControl("pictureBox2");
                                bubble4.XoaControl("panel2");
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

                    if (reader.GetInt32(10) == 0)
                    {
                        var bubble = new BaiViet_Vid_();
                        bubble.XoaControl("panel1");
                        bubble.XoaControl("SoThich");
                        bubble.XoaControl("socmt");
                        bubble.XoaControl("pictureBox1");
                        bubble.XoaControl("pictureBox2");
                        bubble.XoaControl("panel2");
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
        }
            private void BaiViet_ChiaSe__Load(object sender, EventArgs e)
        {
            panel2.Visible= false;

            addbaiviet();
            thichBinhLuan1_Load_1(sender, e);
        }

        private void thichBinhLuan1_Load_1(object sender, EventArgs e)
        {
            panel2.Visible = false;

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
            cmd.CommandText = "select * from thich where ID = '" + Id + "'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> listten = new List<string>();
            while (reader.Read())
            {

                listten.Add(reader.GetString(1));
            }
            int SoLuotThich = listten.Count;
            SoThich.Text = SoLuotThich.ToString();
            reader.Close();

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from cmt where ID = '" + Id + "'";
            cmd.Connection = sqlCond;
            reader = cmd.ExecuteReader();
            List<string> listcmt = new List<string>();
            while (reader.Read())
            {

                listcmt.Add(reader.GetString(1));
            }

            int SoLuotcmt = listcmt.Count;
            socmt.Text = SoLuotcmt.ToString();
            reader.Close();
            addthichbinhluan(Id);
        }
        private void addthichbinhluan(int Id)
        {
            var bubble = new ThichBinhLuan();
            bubble.Id = Id;
            panel1.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;

        }


        private void SoThich_MouseEnter(object sender, EventArgs e)
        {
            listView1.Clear();
            panel2.Visible = true;
            listView1.Visible = true;
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
            cmd.CommandText = "select * from thich where ID = '" + Id + "'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> listten = new List<string>();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(1));
                listView1.Items.Add(item);
            }

            reader.Close();

        }

        private void SoThich_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
