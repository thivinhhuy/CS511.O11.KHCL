using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thuchanh3;
using static Doan.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Doan
{
    public partial class ChatUser : UserControl
    {
        public ChatUser()
        {
            InitializeComponent();
        }
        



        private void rjButton1_Click(object sender, EventArgs e)
        {
            Globals.idglob = rjButton1.Text;
            Checkchat.refer = 1;
            Chat.Avt.avt = avatar;
        }
        public string mess
        {
            get
            {
                return rjButton1.Text;
            }
            set 
            {
                rjButton1.Text = value; 
            }
        }
        public Image avatar
        {
            get
            {
                return pictureBox1.Image;
            }

            set
            {
                pictureBox1.Image = value;
            }
        }
        void AdjustHeight()
        {
            rjButton1.Height = HeightUserChat.GetTextHeight(rjButton1) + 20;
            this.Height = rjButton1.Height;
        }
        void resize()
        {
            AdjustHeight();
        }


    }
}
