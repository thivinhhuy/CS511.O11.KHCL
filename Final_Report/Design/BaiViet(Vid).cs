using Doan.Vietbai;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Doan
{
    public partial class BaiViet_Vid_ : UserControl
    {
        public BaiViet_Vid_()
        {
            InitializeComponent();
        }
        private bool isPlaying = false;
        private bool isMuted = false;
        public string videoURL;
        public int Id;
        public string BaiVietText
        {
            get
            {
                return BaiViet.Text;
            }
            set
            {
                BaiViet.Text = value;
            }
        }
        public string TenNguoiDungText
        {
            get
            {
                return TenNguoiDung.Text;
            }
            set
            {
                TenNguoiDung.Text = value;
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
        public string VideoUrl
        {
            get
            {
                return videoURL;
            }
            set
            {
                videoURL = value;
            }
        }
        public Image AVT
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
        public Image CheDO
        {
            get
            {
                return CheDo.Image;
            }
            set
            {
                CheDo.Image = value;
            }
        }
        private void BaiViet_Vid__Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.URL = videoURL;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            thichBinhLuan1_Load_1(sender, e);
        }

        private void TatTieng_Click(object sender, EventArgs e)
        {
            if (!isMuted)
            {
                axWindowsMediaPlayer1.settings.mute = true;
                TatTieng.Image = Image.FromFile(@"D:\2023-2024_HKI\C#\report\Anhtrongvideo\volume-mute.png");
                isMuted = true;
            }
            else
            {
                axWindowsMediaPlayer1.settings.mute = false;
                TatTieng.Image = Image.FromFile(@"D:\2023-2024_HKI\C#\report\Anhtrongvideo\medium-volume.png");
                isMuted = false;
            }
        }

        private void PhatVideo_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                PhatVideo.Image = Image.FromFile(@"D:\2023-2024_HKI\C#\report\Anhtrongvideo\pause-button.png");
                isPlaying = true;
                timer1.Start();
                rjProgressBar1.Visible = true;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                PhatVideo.Image = Image.FromFile(@"D:\2023-2024_HKI\C#\report\Anhtrongvideo\play-button-arrowhead.png");
                isPlaying = false;
                timer1.Stop();
                if(rjProgressBar1.Value == rjProgressBar1.Maximum)
                {
                    rjProgressBar1.Value = 0;
                }
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                double videoLength = axWindowsMediaPlayer1.currentMedia.duration;
                rjProgressBar1.Maximum = Convert.ToInt32(videoLength * 20) ;
                double currentPosition = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
        }

        private void rjProgressBar1_MouseClick(object sender, MouseEventArgs e)
        {
            double videoLength = axWindowsMediaPlayer1.currentMedia.duration;
            double newPosition = (e.X / (double)rjProgressBar1.Width) * videoLength;
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = newPosition;
            rjProgressBar1.Value = (int)(newPosition * 20);
        }

        private void PanelAnh_MouseEnter(object sender, EventArgs e)
        {
            rjProgressBar1.Visible = true;
            PhatVideo.Visible = true;
        }

        private void PanelAnh_MouseLeave(object sender, EventArgs e)
        {
            rjProgressBar1.Visible = false;
            PhatVideo.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(rjProgressBar1.Value < rjProgressBar1.Maximum)
            {
                rjProgressBar1.Value++;
            }
        }

        private void Avt_Click(object sender, EventArgs e)
        {
            if (TenNguoiDung.Text == Program.ID.Ten)
            {
                FormCaNhan formCaNhan = new FormCaNhan();
                formCaNhan.Show();
            }
            else
            {
                FormKhach formKhach = new FormKhach();
                formKhach.ten = TenNguoiDung.Text;
                formKhach.avt = Avt.Image;
                formKhach.Show();
            }
        }

        private void TenNguoiDung_Click(object sender, EventArgs e)
        {
            if (TenNguoiDung.Text == Program.ID.Ten)
            {
                FormCaNhan formCaNhan = new FormCaNhan();
                formCaNhan.Show();
            }
            else
            {
                FormKhach formKhach = new FormKhach();
                formKhach.ten = TenNguoiDung.Text;
                formKhach.avt = Avt.Image;
                formKhach.Show();
            }
        }
        public void XoaControl(string controlName)
        {
            {
                foreach (Control control in Controls)
                {
                    if (control.Name == controlName)
                    {
                        Controls.Remove(control);
                    }
                }
            }
        }
        private void SoBinhLuan_Click(object sender, EventArgs e)
        {

        }

        private void thichBinhLuan1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection sqlCond = null;
        string strCond = @"Data Source=LAPTOP-24A31P93;Initial Catalog=facebook;Integrated Security=True";
        private void thichBinhLuan1_Load_1(object sender, EventArgs e)
        {
            panel2.Visible = false;

            if (sqlCond == null)
            {
                sqlCond = new SqlConnection(strCond);
            }
            if (sqlCond.State == ConnectionState.Closed)
            {
                sqlCond.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from thich where ID = '" + Id + "'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> listten = new List<string>();
            while (reader.Read())
            {
                
                listten.Add(reader.GetString(1));
            }
            int SoLuotThich = listten.Count;
            SoThich.Text = SoLuotThich.ToString();
            reader.Close();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from cmt where ID = '" + Id + "'";
            cmd.Connection = sqlCond;
            reader = cmd.ExecuteReader();
            List<string> listcmt = new List<string>();
            while (reader.Read())
            {

                listcmt.Add(reader.GetString(1));
            }

            int SoLuotcmt = listcmt.Count;
            socmt.Text = SoLuotcmt.ToString();
            reader.Close();
            addthichbinhluan(Id);
        }

        private void addthichbinhluan(int Id)
        {
            var bubble = new ThichBinhLuan();
            bubble.Id = Id;
            panel1.Controls.Add(bubble);
            bubble.BringToFront();
            bubble.Dock = DockStyle.Top;

        }

        private void SoThich_MouseEnter(object sender, EventArgs e)
        {
            listView1.Clear();
            panel2.Visible = true;
            listView1.Visible = true;
            if (sqlCond == null)
            {
                sqlCond = new SqlConnection(strCond);
            }
            if (sqlCond.State == ConnectionState.Closed)
            {
                sqlCond.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from thich where ID = '" + Id + "'";
            cmd.Connection = sqlCond;
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> listten = new List<string>();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader.GetString(1));
                listView1.Items.Add(item);
            }

            reader.Close();
        }

        private void SoThich_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false; 
        }
    }
}
