using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuchanh3
{
    public partial class TB : UserControl
    {
        public TB()
        {
            InitializeComponent();
        }

        public string mess
        {
            get
            {
                return label1.Text;
            }
            set { label1.Text = value; }
        }
        public string mess1
        {
            get
            {
                return label2.Text;
            }
            set { label2.Text = value; }
        }
        public string mess2
        {
            get
            {
                return label3.Text;
            }
            set { label3.Text = value; }
        }
        void AdjustHeight()
        {
            panel1.Height = HTB.GetTextHeight(panel1) + 10;
            this.Height = panel1.Height;
        }
        void resize()
        {
            AdjustHeight();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
