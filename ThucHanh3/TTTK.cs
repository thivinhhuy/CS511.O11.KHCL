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
    public partial class TTTK : Form
    {
        public TTTK()
        {
            InitializeComponent();
        }
        public string ID;
        public string tenTK;
        public string laisuat;
        public string sotien;
        public string tienloi;
        public string kyhan;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            TietKiem tietKiem = new TietKiem();
            tietKiem.ID = ID;
            tietKiem.Show();
            this.Close();
        }

        private void TTTK_Load(object sender, EventArgs e)
        {
            label7.Text = tenTK;
            label11.Text = ID;
            label14.Text = laisuat;
            label15.Text = sotien;
            label16.Text = tienloi;
            label17.Text = kyhan;
        }
    }
}
