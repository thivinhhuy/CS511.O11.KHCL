using Doan.Height;
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

namespace Doan
{
    public partial class ChatOut : UserControl
    {
        public ChatOut()
        {
            InitializeComponent();
        }
        public string mess
        {
            get
            {
                return rJtext1.Texts;
            }
            set
            {
                rJtext1.Texts = value;
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
            rJtext1.Height = HeightUserChatText.GetTextHeight(rJtext1) + 30;
            this.Height = rJtext1.Height;
        }
        void resize()
        {
            AdjustHeight();
        }
    }
}
