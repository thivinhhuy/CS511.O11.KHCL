using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doan;

namespace Doan
{
    public partial class FormXemAnh : Form
    {
        public FormXemAnh()
        {
            InitializeComponent();
        }
        private int i = 0;
        public int soanh;
        public string[] listanh;
        private void Tat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Phai_Click(object sender, EventArgs e)
        {
            if (i == soanh-1)
            {
                i = 0;
                Anh.Image = Image.FromFile(listanh[i]);
            }
            else
            {
                i++;

                Anh.Image = Image.FromFile(listanh[i]);
            }
        }

        private void Trai_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i = soanh - 1;
                Anh.Image = Image.FromFile(listanh[i]);
            }
            else
            {
                i--;

                Anh.Image = Image.FromFile(listanh[i]);
            }
        }

        private void FormXemAnh_Load(object sender, EventArgs e)
        {

            Anh.Image = Image.FromFile(listanh[0]);
        }
    }
}
