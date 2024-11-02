using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21522165_TH1.chatiterm
{
    public partial class outcome : UserControl
    {
        public outcome()
        {
            InitializeComponent();
        }
        public string Mess
        {
            get
            {
                return sennd.Text;
            }
            set
            {
                sennd.Text = value;

            }

        }
        void AdjustHeight()
        {
            guna2CirclePictureBox1.Location = new Point(4, 3);
            sennd.Height = Utils.GetTextHeight(sennd) + 10;

            guna2Button1.Height = sennd.Top + guna2Button1.Height + sennd.Height;
            this.guna2Button1.Height = guna2Button1.Height + 10;
        }
        public Image Avatar
        {
            get => guna2CirclePictureBox1.Image; set => guna2CirclePictureBox1.Image = value;
        }
        private void income_Resize(object sender, EventArgs e)
        {
            AdjustHeight();

        }


    }
}

