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
using System.Data.SqlTypes;

namespace Doan
{
    public partial class Chat : UserControl
    {
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";
        public static class Avt
        {
            static Image _avt;
            public static Image avt
            {
                set { _avt = value; }
                get { return _avt; }
            }
        }

        public Chat()
        {
            InitializeComponent();
        }
        void AddIn(string nd)
        {
            var bubble = new ChatIn();
            panel2.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.mess = nd;
        }
        void AddOut(string nd, Image Avatar)
        {
            var bubble = new ChatOut();
            panel2.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;
            bubble.avatar = Avatar;
            bubble.mess = nd;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Chat_Load(object sender, EventArgs e)
        {

            if (sqlCond == null)
            {
                sqlCond = new SqlConnection(strCond);
            }
            if (sqlCond.State == ConnectionState.Closed)
            {
                sqlCond.Open();
            }
            pictureBox2.Image = Avt.avt;
            label1.Text = Globals.idglob;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from chat";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if(reader.GetString(1) == Program.ID.Ten)
                {
                    if(reader.GetString(0) == Program.Globals.idglob)
                    {
                        AddIn(reader.GetString(3));
                    }    
                }
                if(reader.GetString(1) == Program.Globals.idglob)
                {
                    if (reader.GetString(0) == Program.ID.Ten)
                    {
                        AddOut(reader.GetString(3),Avt.avt);
                    }    
                }    
            }
            reader.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            Checkchat.refer = 0;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (sqlCond == null)
            {
                sqlCond = new SqlConnection(strCond);
            }
            if (sqlCond.State == ConnectionState.Closed)
            {
                sqlCond.Open();
            }
            pictureBox2.Image = Avt.avt;
            label1.Text = Globals.idglob;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into chat(tennhan,tengui,noidung) values ('"+Program.Globals.idglob+"','"+Program.ID.Ten+"',N'"+rJtext1.Texts+"')";
            cmd.Connection = sqlCond;
            cmd.ExecuteNonQuery();
        }
    }
}
