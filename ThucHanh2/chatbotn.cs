using _21522165_TH1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace thuchanh2
{
    public partial class chatbotn : UserControl
    {
        public chatbotn()
        {
            InitializeComponent();
        }
        public string mess
        {
            get
            {
                return rjTextBox1.Texts;
            }
            set { rjTextBox1.Texts = value; }
        }
        void AdjustHeight()
        {
            rjTextBox1.Height = Utils.GetTextHeight(rjTextBox1) + 10;
            this.Height = rjTextBox1.Height;
        }
        void resize()
        {
            AdjustHeight();
        }
    }
}
