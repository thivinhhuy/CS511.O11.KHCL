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
using System.IO;

namespace thuchanh2
{
    public partial class NgheGanDay : Form
    {
        public NgheGanDay()
        {
            InitializeComponent();
        }
        string listdaxem;
        string strCon = @"Data Source=LAPTOP-24A31P93;Initial Catalog=datavideo;Integrated Security=True";
        SqlConnection sqlCon = null;
        string url = @"D:\2023-2024_HKI\C#\TH2_image\";
        List<string> list = new List<string>();
        private void loadimgdanghe(object sender, EventArgs e)
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
            cmd.CommandText = "select * from datafull where daxem = 1";
            cmd.Connection = sqlCon;
            int i = 0;
            
            SqlDataReader reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            string[] danhsach = new string[100];
            
            string[] listimg;
            int l = 0;
            while (reader.Read())
            {
                
                string path = reader.GetString(0);

                ListViewItem item = new ListViewItem(path);
                //danhsach = Directory.GetFiles(url, path, SearchOption.AllDirectories);
                string ten = url + path;

                imageList1.Images.Add(Image.FromFile(ten));

                string filename = Path.GetFileNameWithoutExtension(path);
                list.Add(filename);
                listView1.Items.Add(filename,l);
                l++;
            }

            listView1.LargeImageList = imageList1;
            listView1.View = View.LargeIcon;

            
            
            reader.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string tennhac;
        
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int inx = e.ItemIndex;
            tennhac = list[inx];
            tennhac = Path.GetFileNameWithoutExtension(tennhac);
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            
            Nhac nhac = new Nhac();
            string pathvideo = @"D:\2023-2024_HKI\C#\TH2_video\" + tennhac + ".mp4";
            nhac.tenvideo = pathvideo;
            nhac.TenNhacvideo = tennhac;
            nhac.ShowDialog();
            
        }
    }
}

