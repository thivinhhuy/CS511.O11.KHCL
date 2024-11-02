using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan;

namespace Doan
{
    public partial class FormBinhLuan : Form
    {
        public FormBinhLuan()
        {
            InitializeComponent();
        }

        public int Id;
        void Add(string Msg, string Date, Image A)
        {
            var Bubble = new Doan.BinhLuan();
            PanelCmt.Controls.Add(Bubble);
            Bubble.BringToFront();
            Bubble.Dock = DockStyle.Top;
            Bubble.CmtText = Msg;
            Bubble.ThoiGianText = Date;
            Bubble.AvtChange = A;
        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";
        string Url = @"D:\2023-2024_HKI\C#\report\acc\";
        private void FormBinhLuan_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from cmt where ID = '" +Id+"'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Image i = Image.FromFile(Url + reader.GetString(1) + ".jpg");
                string ngay = reader.GetDateTime(5).ToString();
                string[] dates = ngay.ToString().Split(' ');
                Add(reader.GetString(4), dates[0],i);

            }

            reader.Close();





        }

        private void Tat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rJtext1_Enter(object sender, EventArgs e)
        {

        }

        private void rJtext1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            PanelCmt.Controls.Clear();
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
            DateTime dt = DateTime.Now;

            cmd.CommandText = "insert into cmt(ID,ten,avt,noidung,ngay) values ('"+Id+"','"+Program.ID.Ten+"','"+ Program.ID.Ten + "','"+rJtext1.Texts+"','"+dt+"')";
            cmd.Connection = sqlCond;
            cmd.ExecuteNonQuery();
            FormBinhLuan_Load(sender, e);
        }
    }
}
