using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace thuchanh2
{
    public partial class Playlist : Form
    {
        public Playlist()
        {
            InitializeComponent();
        }
        int i = 0;
        int f = 0;


        string strCon = @"Data Source=LAPTOP-24A31P93;Initial Catalog=playlist;Integrated Security=True";
        SqlConnection sqlCon = null;
        private void button1_Click(object sender, EventArgs e)
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
            sqlCmd.CommandText = "CREATE TABLE "+rjTextBox1.Texts+"( tem varchar(40),)";
            sqlCmd.Connection = sqlCon;
            int kq = sqlCmd.ExecuteNonQuery();
            listView1.Clear();
            load(sender, e);

        }
        List<string > list = new List<string>();
        private void load(object sender, EventArgs e)
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
            cmd.CommandText = "select name from sysobjects  where xtype = 'U'";
            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                string namePL = reader.GetString(0);
                list.Add(namePL);
                ListViewItem item = new ListViewItem(namePL);
                string filename = Path.GetFileNameWithoutExtension(namePL);
                listView1.Items.Add(filename,f);
                f++;
            }
            
            listView1.LargeImageList = imageList1; 
            listView1.View = View.LargeIcon;
            reader.Close();

        }
        
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string tenpl;
        int inx;
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            inx = e.ItemIndex;
            tenpl = list[inx];

        }

        private void listView1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Mở hay xóa Playlist", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PL pl = new PL();
                pl.tenPL = tenpl;
                pl.Show();
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
                sqlCmd.CommandText = "drop table " + tenpl;
                sqlCmd.Connection = sqlCon;
                int kq = sqlCmd.ExecuteNonQuery();
                listView1.Clear();
                load(sender, e);
            }
                

            
        }
        
    }
}
