using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21522165_TH1
{
    public partial class FTK : Form
    {
        public FTK()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            this.Close();
            FDN fDN = new FDN();
            fDN.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1(); 
            form.Show();    
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            FLienHe fLienHe = new FLienHe();
            fLienHe.Show();
            this.Close();
        }
    }
}
