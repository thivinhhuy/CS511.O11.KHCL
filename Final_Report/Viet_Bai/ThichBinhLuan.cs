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

namespace Doan.Vietbai
{
    public partial class ThichBinhLuan : UserControl
    {
        public ThichBinhLuan()
        {
            InitializeComponent();
        }
        public int Id;


        int a = 0;
        private void Thich_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                a = 2;
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
                cmd.CommandText = " delete thich where ID ='" + Id + "' and Ten = '" + Program.ID.Ten + "'";
                cmd.Connection = sqlCond;
                cmd.ExecuteNonQuery(); 
                Thich.Image = Image.FromFile(@"D:\2023-2024_HKI\C#\report\Doan\like (1).png");
                Thich.ForeColor = Color.White;
            }
            else
            {
                a = 1;
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
                cmd.CommandText = " insert into thich values('" + Id + "','" + Program.ID.Ten + "')";
                cmd.Connection = sqlCond;
                cmd.ExecuteNonQuery();

                Thich.Image = Image.FromFile(@"D:\2023-2024_HKI\C#\report\Doan\like.png");
                Thich.ForeColor = Color.Blue;
            }
        }

        private void BinhLuan_Click(object sender, EventArgs e)
        {
            FormBinhLuan formBinhLuan = new FormBinhLuan();
            formBinhLuan.Id = Id;
            formBinhLuan.ShowDialog();  
        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";
        string Url = @"D:\2023-2024_HKI\C#\report\acc\";
        int SoLuotThich;
        List<string> listten;
        private void ThichBinhLuan_Load(object sender, EventArgs e)
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
            cmd.CommandText = "select * from thich where ID = " + Id + " and Ten = '" + Program.ID.Ten + "'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                a = 1;
            }
            reader.Close();
            if (a == 0)
            {
                Thich.Image = Image.FromFile(@"D:\2023-2024_HKI\C#\report\Doan\like (1).png");
                Thich.ForeColor = Color.White;
            }
            else
            {
                Thich.Image = Image.FromFile(@"D:\2023-2024_HKI\C#\report\Doan\like.png");
                Thich.ForeColor = Color.Blue;
            }
        }

        private void SoThich_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
