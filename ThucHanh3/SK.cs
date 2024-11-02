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
namespace thuchanh3
{
    public partial class SK : UserControl
    {
        public SK()
        {
            InitializeComponent();
        }
        
        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }
        public string mess
        {
            get
            {
                return textBox1.Text;
            }
            set { textBox1.Text = value; }
        }
        void AdjustHeight()
        {
            textBox1.Height = Utils.GetTextHeight(textBox1) + 10;
            this.Height = textBox1.Height;
        }
        void resize()
        {
            AdjustHeight();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightBlue;

        }
    }
}
