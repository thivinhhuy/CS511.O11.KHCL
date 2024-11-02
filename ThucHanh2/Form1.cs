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

namespace thuchanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Nhac nhac = new Nhac();
            nhac.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            NgheGanDay ngheGanDay = new NgheGanDay();
            ngheGanDay.ShowDialog();
        }

        string[] danhsach;
        string[] danhsachvideo;
        private void MyMusic_load(object sender, EventArgs e)
        {

        }
        string dirFull = @"D:\2023-2024_HKI\C#\TH2_image";
        string dirvideo = @"D:\2023-2024_HKI\C#\TH2_video";
        private void imageload(object sender, EventArgs e)
        {
            listView2.Visible = false;
            listView1.Items.Clear();
            danhsach = Directory.GetFiles(dirFull, "*", SearchOption.AllDirectories);
            danhsachvideo = Directory.GetFiles(dirvideo, "*", SearchOption.AllDirectories);
            int i = 0;
            foreach (string file in danhsach)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                listView1.Items.Add(fileName, i);
                i++;
            }

            listView1.LargeImageList = imageList1;
            listView1.View = View.LargeIcon;
        }


        public string Fullpath;
        public string pathvideo;
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int inx = e.ItemIndex;
            Fullpath = danhsach[inx].ToString();
            pathvideo = danhsachvideo[inx].ToString();
               }

        private void listView1_Click(object sender, EventArgs e)
        {

            Nhac phatnhac = new Nhac();
            phatnhac.TenNhacvideo = Path.GetFileNameWithoutExtension(pathvideo);
            phatnhac.tenvideo = pathvideo;
            phatnhac.ShowDialog();
        }

        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            NgheGanDay ngheGanDay = new NgheGanDay();
            ngheGanDay.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            yeuthich yeuthich = new yeuthich();
            yeuthich.ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            NgheGanDay ngheGanDay = new NgheGanDay();
            ngheGanDay.ShowDialog();
        }
        private void label3_Click_1(object sender, EventArgs e)
        {
            yeuthich yeuthich = new yeuthich();
            yeuthich.ShowDialog();
        }

        private void label3_Click_2(object sender, EventArgs e)
        {
            yeuthich yeuthich = new yeuthich();
            yeuthich.ShowDialog();
        }
        
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string strCon = @"Data Source=LAPTOP-24A31P93;Initial Catalog=datavideo;Integrated Security=True";
        SqlConnection sqlCon = null;
        string url = @"D:\2023-2024_HKI\C#\TH2_image\";
        private void rjTextBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
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
            cmd.CommandText = "select * from datafull where pathvideo like '" + timkiem.Texts + "%'";
            cmd.Connection = sqlCon;

            int i = 0;
            string listtimkiem;
            SqlDataReader reader = cmd.ExecuteReader();
            string[] danhsachtimkiem = new string[100];
            listView2.Items.Clear();
            imageList2.Images.Clear();

            int l = 0;
            
            while (reader.Read())
            {
                listView2.Visible = true;
                string path = reader.GetString(0);
                ListViewItem item = new ListViewItem(path);
                string ten = url + path;
                imageList2.Images.Add(Image.FromFile(ten));

                string filename = Path.GetFileNameWithoutExtension(path);
                listView2.Items.Add(filename, l);
                l++;
            }
            if (timkiem.Texts.IsNullOrEmpty())
            {
                listView2.Visible = false;
            }    
            listView2.LargeImageList = imageList2;
            listView2.View = View.LargeIcon;



            reader.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Playlist playlist = new Playlist();
            playlist.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
