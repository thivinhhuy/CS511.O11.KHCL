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
using System.IO;
using static thuchanh3.Program;

namespace thuchanh3
{
    public partial class TietKiem : Form
    {
        public string ID = Globals.idglob;
        public TietKiem()
        {
            InitializeComponent();
        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=Bank;Integrated Security=True";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ID = ID;
            
            form1.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CK cK = new CK();
            cK.ID = ID;

            cK.Show();
            this.Close();
        }
        string tientong;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SaoKe saoKe = new SaoKe();
                saoKe.ID = ID;
            saoKe.Show();
            this.Close();
        }
        int f = 0;
        List<string> listid = new List<string>();
        List<string> listname = new List<string>();
        List<string> listls = new List<string>();
        List<string> listtienTK = new List<string>();
        List<string> listsotienloi = new List<string>();
        List<string> listkyhan = new List<string>();
        private void TietKiem_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from TKTK where id='" + ID + "'";
            cmd.Connection = sqlCond;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string name = reader.GetString(1);
                string ls = reader.GetString(2);
                string tienTK = reader.GetString(3);
                string sotienloi = reader.GetString(4);
                string kyhan = reader.GetString(5);

                listid.Add(id);
                listname.Add(name);
                listls.Add(ls);
                listtienTK.Add(tienTK);
                listsotienloi.Add(sotienloi);
                listkyhan.Add(kyhan);
                listView1.Items.Add(name, f);
                f++;
            }
            rjComboBox2.DataSource = listname;
            listView1.LargeImageList = imageList1;
            listView1.View = View.LargeIcon;
            reader.Close();

            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from acc where id='" + ID + "'";
            cmd.Connection = sqlCond;

            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                rjTextBox1.Texts = reader.GetString(0);
                label13.Text = reader.GetString(1);
                tientong = reader.GetString(1);
            }
            reader.Close();
        }
        string tenpl;
        int inx = 0;
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            inx = e.ItemIndex;

        }
        private void listView1_Click(object sender, EventArgs e)
        {
            TTTK tTTK = new TTTK();
            tTTK.ID = ID;
            tTTK.tenTK = listname[inx];
            tTTK.laisuat = listls[inx];
            tTTK.sotien = listtienTK[inx];
            tTTK.tienloi = listsotienloi[inx];
            tTTK.kyhan = listkyhan[inx];
            tTTK.Show();
            this.Close();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel4.Visible = false;
        }
        int tientru;
        private void rjButton1_Click(object sender, EventArgs e)
        {
            

            if (Int32.Parse(tientong) > Int32.Parse(rjTextBox3.Texts))
            {
                tientru = Int32.Parse(tientong) - Int32.Parse(rjTextBox3.Texts);
                SqlCommand sqlCmdd = new SqlCommand();
                sqlCmdd.CommandType = CommandType.Text;
                sqlCmdd.CommandText = "update acc set sotien = '" + tientru + "'where id = '" + ID + "'";
                sqlCmdd.Connection = sqlCond;
                sqlCmdd.ExecuteNonQuery();

                DateTime todaysDate = DateTime.Now;
                string[] dates = todaysDate.ToString().Split(' ');
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "INSERT INTO tinnhan VALUES (" + ID + "," + 0 + "," + rjTextBox1.Texts + "," + rjTextBox3.Texts +
                                                                "," + tientru + ",'" + dates[0] + "','gui tien tiet kiem ',NULL)";
                sqlCmd.Connection = sqlCond;
                int kq = sqlCmd.ExecuteNonQuery();

                SqlCommand sqlCmddd = new SqlCommand();
                sqlCmddd.CommandType = CommandType.Text;
                string[] ls = rjComboBox1.Texts.Split('-');
                string[] laisuat = ls[1].Split(' ');
                int tienloi = (Int32.Parse(laisuat[0])*Int32.Parse(rjTextBox3.Texts))/100;
                sqlCmddd.CommandText = "insert into TKTK values ("+ID+", '"+rjTextBox2.Texts +"', '" + ls[1] +"', '" + rjTextBox3.Texts + "',"+tienloi+" ,'" + ls[0] +"' )";
                sqlCmddd.Connection = sqlCond;
                sqlCmddd.ExecuteNonQuery();
                panel2.Visible = false;
                panel4.Visible = true;
                listView1.Clear();
                TietKiem_Load(sender, e);
            }
        }




        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        string tienhienco;
        private void rjButton2_Click(object sender, EventArgs e)
        {
            // lấy tiền trong tài khoản tiết kiệm
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
            cmd.CommandText = "select * from TKTK where id='" + ID + "'";
            cmd.Connection = sqlCond;

            SqlDataReader reader = cmd.ExecuteReader();
            List<string> lsotien = new List<string>();
            List<string> lsotienloi = new List<string>();
            while (reader.Read())
            {
                lsotien.Add(reader.GetString(3));
                lsotienloi.Add(reader.GetString(4));
            }
            reader.Close();
            // lấy tiên hiện có
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from acc where id='" + ID + "'";
            cmd.Connection = sqlCond;

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tienhienco = reader.GetString(1);
            }
            reader.Close();

            int Lsotien = lsotien.Sum(x => Convert.ToInt32(x));
            int Lsotienloi = lsotienloi.Sum(x => Convert.ToInt32(x));
            int tong = Lsotien + Lsotienloi + Int32.Parse(tienhienco);
            // rút tiền về 
            SqlCommand sqlCmddd = new SqlCommand();
            sqlCmddd.CommandType = CommandType.Text;
            sqlCmddd.CommandText = "update acc set sotien = '"+tong+"' where id = '"+ID+"'";
            sqlCmddd.Connection = sqlCond;
            sqlCmddd.ExecuteNonQuery();

            sqlCmddd = new SqlCommand();
            sqlCmddd.CommandType = CommandType.Text;
            sqlCmddd.CommandText = "delete TKTK where id=' "+ID+"'";
            sqlCmddd.Connection = sqlCond;
            sqlCmddd.ExecuteNonQuery();
        }
        int tongtc;
        private void rjButton4_Click(object sender, EventArgs e)
        {
            //lấy tên tài khoảng tiết kiệm
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
            cmd.CommandText = "select * from TKTK where id='" + ID + "' and tenTK = '"+rjComboBox2.Texts+"'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            string sotien;
            string sotienloi;
            if (reader.Read())
            {
                tongtc = Int32.Parse((reader.GetString(3))) + Int32.Parse((reader.GetString(4)));
            }
            reader.Close();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from acc where id='" + ID + "'";
            cmd.Connection = sqlCond;

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tienhienco = reader.GetString(1);
            }
            reader.Close();

            int tong = tongtc + Int32.Parse(tienhienco);

            //rút tiền về tài khoan
            SqlCommand sqlCmddd = new SqlCommand();
            sqlCmddd.CommandType = CommandType.Text;
            sqlCmddd.CommandText = "update acc set sotien = '" + tong + "' where id = '" + ID + "'";
            sqlCmddd.Connection = sqlCond;
            sqlCmddd.ExecuteNonQuery();



            sqlCmddd = new SqlCommand();
            sqlCmddd.CommandType = CommandType.Text;
            sqlCmddd.CommandText = "delete TKTK where id='" + ID + "' and tenTK = '" + rjComboBox2.Texts + "'";
            sqlCmddd.Connection = sqlCond;
            sqlCmddd.ExecuteNonQuery();
            listView1.Clear();
            TietKiem_Load(sender, e);
        }
    } }
