using Doam;
using Doan;
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
    public partial class BinhLuan : UserControl
    {
        public BinhLuan()
        {
            InitializeComponent();
        }
        public string CmtText
        {
            get
            {
                return Cmt.Texts;
            }
            set
            {
                Cmt.Texts = value;
                AdjustHeight();
            }
        }
        public Image AvtChange
        {
            get
            {
                return Avt.Image;
            }
            set
            {
                Avt.Image = value;
            }
        }
        public string ThoiGianText
        {
            get
            {
                return ThoiGian.Text;
            }
            set
            {
                ThoiGian.Text = value;
            }
        }
        void AdjustHeight()
        {
            Cmt.Height = Utils.GetTextHeight(Cmt) + 20;
            ThoiGian.Location = new Point(Cmt.Location.X,Cmt.Location.Y + Cmt.Height + 10);
            Thich.Location = new Point(ThoiGian.Location.X + ThoiGian.Width + 20, ThoiGian.Location.Y);
            ThichPic.Location = new Point(Cmt.Width + 35, Cmt.Height - 10);
            this.Height = Cmt.Bottom + 50;
        }

        private void BinhLuan_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
        private int like = 0;
        private void Thich_Click(object sender, EventArgs e)
        {
            switch (like)
            {
                case 0:
                    Thich.ForeColor = Color.Blue;
                    ThichPic.Visible = true;
                    like = 1;
                    break;
                case 1:
                    Thich.ForeColor = Color.White;
                    ThichPic.Visible = false;
                    like = 0;
                    break;
            }


        }
    }
}
