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

namespace Doan
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            FormDangki formDangki = new FormDangki();
            formDangki.ShowDialog();
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

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ID";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if(rJtext1.Texts == reader.GetString(3) ^ rJtext1.Texts == reader.GetString(2) )
                {
                    if (rJtext2.Texts == reader.GetString(4))
                    {
                        Program.ID.Ten = reader.GetString(1);
                        Form1 form1 = new Form1();
                        form1.Show();

                    }    
                }
            }
            reader.Close();
            this.Close();
        }
    }
}
