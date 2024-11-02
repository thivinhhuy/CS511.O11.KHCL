using Doan.Vietbai;
using Doan;
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

namespace Doan
{
    public partial class BaiViet_nAnh_ : UserControl
    {
        public BaiViet_nAnh_()
        {
            InitializeComponent();
        }
        public Image ImgTemp;
        public Image Img2Temp;
        public Image Img3Temp;
        private string[] listAnh;
        private int soanh;
        public int Id;
        public int Soanh
        {
            get
            {
                return soanh;
            }
            set
            {
                soanh = value;
            }
        }
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
        public Image AnhImg
        {
            get
            {
                return ImgTemp;
            }
            set
            {
                Anh.Image = value;
            }
        }
        public Image Anh2Img
        {
            get
            {
                return Img2Temp;
            }
            set
            {
                Anh2.Image = value;
            }
        }
        public Image Anh3Img
        {
            get
            {
                return Img3Temp;
            }
            set
            {
                Anh3.Image = value;
            }
        }
        public string[] ListAnh
        {
            get
            {
                return listAnh;
            }
            set
            {
                listAnh = value;
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
        public Image CheDO
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
        public void XoaControl(string controlName)
        {
            {
                foreach (Control control in Controls)
                {
                    if (control.Name == controlName)
                    {
                        Controls.Remove(control);
                    }
                }
            }
        }
        private void More_Click(object sender, EventArgs e)
        {
            FormXemAnh formXemAnh = new FormXemAnh();
            formXemAnh.soanh = Soanh;
            formXemAnh.listanh = listAnh;
            formXemAnh.ShowDialog();
        }

        private void thichBinhLuan1_Load(object sender, EventArgs e)
        {
            
        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";
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
