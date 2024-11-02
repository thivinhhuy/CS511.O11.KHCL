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

namespace Doan
{
    public partial class ChatIn : UserControl
    {
        public ChatIn()
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
        void AdjustHeight()
        {
            rJtext1.Height = HeightUserChatText.GetTextHeight(rJtext1) + 30;
            this.Height = rJtext1.Height;
        }
        void resize()
        {
            AdjustHeight();
        }

        private void rJtext1_Load(object sender, EventArgs e)
        {

        }
    }

}
