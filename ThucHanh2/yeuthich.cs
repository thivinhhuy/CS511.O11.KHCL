using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh2
{
    public partial class yeuthich : Form
    {
        public yeuthich()
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
            cmd.CommandText = "select * from datafull where yeuthich = 1";
            cmd.Connection = sqlCon;
            int i = 0;

            SqlDataReader reader = cmd.ExecuteReader();
            listView1.Items.Clear();
            string[] danhsach = new string[100];

            string[] listimg;
            int a = 0;
            while (reader.Read())
            {

                string pathk = reader.GetString(0);


                ListViewItem item = new ListViewItem(pathk);
                //danhsach = Directory.GetFiles(url, path, SearchOption.AllDirectories);
                string ten = url + pathk;

                imageList1.Images.Add(Image.FromFile(ten));

                string filename = Path.GetFileNameWithoutExtension(pathk);
                list.Add(filename);
                listView1.Items.Add(filename, a);
                a++;

            }

            listView1.LargeImageList = imageList1;
            listView1.View = View.LargeIcon;
            reader.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
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

            if (MessageBox.Show("Mở hay xóa Nhạc khỏi Yêu thích", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                sqlCmd.CommandText = "update datafull set yeuthich = NULL where pathvideo = '" + tennhac + "'";
                sqlCmd.Connection = sqlCon;
                int kq = sqlCmd.ExecuteNonQuery();
                listView1.Clear();
                loadimgdanghe(sender, e);

            }
        }
    }
}
