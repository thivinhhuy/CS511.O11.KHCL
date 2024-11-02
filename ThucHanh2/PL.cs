using CustomControls.RJControls;
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
    public partial class PL : Form
    {
        public PL()
        {
            InitializeComponent();
        }
        string strCon = @"Data Source=LAPTOP-24A31P93;Initial Catalog=playlist;Integrated Security=True";
        SqlConnection sqlCon = null;
        string url = @"D:\2023-2024_HKI\C#\TH2_image\";
        public string tenPL;
        int f = 0;
        List<string> list = new List<string>();
        private void load(object sender, EventArgs e)
        {
            label2.Text = tenPL;
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
            cmd.CommandText = "select * from " + tenPL;
            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string path = reader.GetString(0);
                list.Add(path);
                ListViewItem item = new ListViewItem(path);
                //danhsach = Directory.GetFiles(url, path, SearchOption.AllDirectories);
                string ten = url + path;

                imageList1.Images.Add(Image.FromFile(ten));

                string filename = Path.GetFileNameWithoutExtension(path);
                listView1.Items.Add(filename, f);
                f++;
            }

            listView1.LargeImageList = imageList1;
            listView1.View = View.LargeIcon;
            reader.Close();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

            if (MessageBox.Show("Mở hay xóa Nhạc khỏi Playlist", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Nhac nhac = new Nhac();
                string pathvideo = @"D:\2023-2024_HKI\C#\TH2_video\" + tennhac + ".mp4";
                nhac.tenvideo = pathvideo;
                nhac.TenNhacvideo = tennhac;
                nhac.ShowDialog();
                

            }
            else
            {
                if (sqlCon == null)
                {
                    sqlCon = new SqlConnection(strCon);
                }
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                }
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "delete from "+ tenPL+" where tem ='"+tennhac+".png'";
                sqlCmd.Connection = sqlCon;
                int kq = sqlCmd.ExecuteNonQuery();
                listView1.Clear();
                load(sender,e);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listView1.Visible = false;
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "delete from " + tenPL ;
            sqlCmd.Connection = sqlCon;
            int kq = sqlCmd.ExecuteNonQuery();
        }
    }
}
