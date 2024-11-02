using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan.Vietbai;
using static Doan.Program;

namespace Doan
{
    public partial class FormDangBaiViet : Form
    {
        
        public FormDangBaiViet()
        {
            InitializeComponent();
        }
        private List<string> Fileanh;


        public string ten;
        public Image avt;
        public string ID;
        private void Photo_Click(object sender, EventArgs e)
        {
            ThemAnh themAnh = new ThemAnh();
            ThemAnh.Controls.Add(themAnh);
        }
        SqlConnection sqlCond = null;
        int CHEDO;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";
        private void rjButton1_Click(object sender, EventArgs e)
        {
            int IDs = Program.ID.id + 1;
            int soanh = Program.FileThemAnh.Fileanh.Count();
            if (Program.FileThemAnh.video == 0)
            {
                string fileName = Path.GetFileNameWithoutExtension(Program.FileThemAnh.Fileanh[0]);
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
                string filesourch = @"D:\2023-2024_HKI\C#\report\sqlimg\" + fileName+ ".mp4";
                File.Copy(Program.FileThemAnh.Fileanh[0], filesourch);

                cmd.CommandText = "insert into Baiviet (ID,ten,avt,anh1,thoigian,noidung,soanh,chedo,video)  values  ('" + IDs + "','" + Program.ID.Ten + "','" + Program.ID.Ten + "','" + fileName + "','1-12-2024','" + BaiViet.Texts + "'," + soanh + ",'3','0')";
                cmd.Connection = sqlCond;
                cmd.ExecuteNonQuery();
            }
            else
            {
                if (soanh == 1)
                {
                    string fileName = Path.GetFileNameWithoutExtension(Program.FileThemAnh.Fileanh[0]);
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
                    string filesourch = @"D:\2023-2024_HKI\C#\report\sqlimg\" + fileName + ".jpg";
                    File.Copy(Program.FileThemAnh.Fileanh[0], filesourch);

                    cmd.CommandText = "insert into Baiviet (ID,ten,avt,anh1,thoigian,noidung,soanh,chedo,video)  values  ('" + IDs + "','" + Program.ID.Ten + "','" + Program.ID.Ten + "','" + fileName + "','1-12-2024','" + BaiViet.Texts + "'," + soanh + ",'3','1')";
                    cmd.Connection = sqlCond;
                    cmd.ExecuteNonQuery();
                }
                if (soanh == 2)
                {
                    string fileName1 = Path.GetFileNameWithoutExtension(Program.FileThemAnh.Fileanh[0]);
                    string fileName2 = Path.GetFileNameWithoutExtension(Program.FileThemAnh.Fileanh[1]);
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
                    string filesourch1 = @"D:\2023-2024_HKI\C#\report\sqlimg\" + fileName1 + ".jpg";
                    string filesourch2 = @"D:\2023-2024_HKI\C#\report\sqlimg\" + fileName2 + ".jpg";
                    File.Copy(Program.FileThemAnh.Fileanh[0], filesourch1, true);
                    File.Copy(Program.FileThemAnh.Fileanh[1], filesourch2, true);
                    cmd.CommandText = "insert into Baiviet (ID,ten,avt,anh1,anh2,thoigian,noidung,soanh,chedo,video)  values  ('" + IDs + "','" + Program.ID.Ten + "','" + Program.ID.Ten + "','" + fileName1 + "','" + fileName2 + "','1-12-2024','" + BaiViet.Texts + "'," + soanh + ",'3','1')";
                    cmd.Connection = sqlCond;
                    cmd.ExecuteNonQuery();
                }
                if (soanh == 3)
                {
                    string fileName1 = Path.GetFileNameWithoutExtension(Program.FileThemAnh.Fileanh[0]);
                    string fileName2 = Path.GetFileNameWithoutExtension(Program.FileThemAnh.Fileanh[1]);
                    string fileName3 = Path.GetFileNameWithoutExtension(Program.FileThemAnh.Fileanh[2]);
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
                    string filesourch1 = @"D:\2023-2024_HKI\C#\report\sqlimg\" + fileName1 + ".jpg";
                    string filesourch2 = @"D:\2023-2024_HKI\C#\report\sqlimg\" + fileName2 + ".jpg";

                    string filesourch3 = @"D:\2023-2024_HKI\C#\report\sqlimg\" + fileName3 + ".jpg";
                    File.Copy(Program.FileThemAnh.Fileanh[0], filesourch1, true);
                    File.Copy(Program.FileThemAnh.Fileanh[1], filesourch2, true);
                    File.Copy(Program.FileThemAnh.Fileanh[2], filesourch3, true);
                    cmd.CommandText = "insert into Baiviet (ID,ten,avt,anh1,anh2,anh3,thoigian,noidung,soanh,chedo,video)  values  ('" + IDs + "','" + Program.ID.Ten + "','" + Program.ID.Ten + "','" + fileName1 + "','" + fileName2 + "','" + fileName3 + "','1-12-2024','" + BaiViet.Texts + "'," + soanh + ",'3','1')";
                    cmd.Connection = sqlCond;
                    cmd.ExecuteNonQuery();
                }
                if (soanh >= 4)
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
                    Random rand = new Random();
                    int filedir = rand.Next(1000);
                    Directory.CreateDirectory(@"D:\2023-2024_HKI\C#\report\nhieuanh\" + "nhieuanh" + filedir);

                    for (int i = 0; i < soanh; i++)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(Program.FileThemAnh.Fileanh[i]);
                        string filesourch = @"D:\2023-2024_HKI\C#\report\nhieuanh\" + "nhieuanh" + filedir + @"\" + fileName + ".jpg";
                        File.Copy(Program.FileThemAnh.Fileanh[i], filesourch, true);
                    }
                    cmd.CommandText = "insert into Baiviet (ID,ten,avt,anh1,thoigian,noidung,soanh,chedo,video)  values  ('" + IDs + "','" + Program.ID.Ten + "','" + Program.ID.Ten + "','" + "nhieuanh" + filedir + "','1-12-2024','" + BaiViet.Texts + "'," + soanh + ",'3','1')";
                    cmd.Connection = sqlCond;
                    cmd.ExecuteNonQuery();
                }


            }
            Form1 form1 = new Form1();
            form1.Form1_Load(sender, e);
            this.Close();
        }




        private void FormDangBaiViet_Load(object sender, EventArgs e)
        {
            string url = @"D:\2023-2024_HKI\C#\report\acc\";
            Avt.Image = Image.FromFile(url + Program.ID.Ten + ".jpg");
            TenNguoiDung.Text = Program.ID.Ten;

        }

        private void Avt_Click(object sender, EventArgs e)
        {

        }

        private void Tat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
