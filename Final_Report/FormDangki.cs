using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static Doan.Chat;
using static Doan.Program;

namespace Doan
{
    public partial class FormDangki : Form
    {
        public FormDangki()
        {
            InitializeComponent();
        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";
        int gioitinh;
        private void rjButton2_Click(object sender, EventArgs e)
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
            if(checkBox1.Checked==true)
            {
                gioitinh = 1;
            }
            if(checkBox2.Checked==true)
            {
                gioitinh = 0;
            }
            string ngaysinh = rjComboBox1.Texts + "/" + rjComboBox2.Texts + "/" + rjComboBox3.Texts;
            cmd.CommandText = "Insert into ID values ('"+ho.Texts+"','"+ten.Texts+"','"+sdt.Texts+"','"+email.Texts+"','"+pass.Texts+"',"+gioitinh+","+ngaysinh+")";
            cmd.Connection = sqlCond;
            cmd.ExecuteNonQuery();
            this.Close();
        }

        private void Tat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
