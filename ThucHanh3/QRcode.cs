using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing.Imaging;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using QRCoder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace thuchanh3
{
    public partial class QRcode : Form
    {
        FilterInfoCollection cameras;
        VideoCaptureDevice cam;
        private Panel BorderBtn;
        public int id = 0;
        public string ID;
        public QRcode()
        {
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                comboBox1.Items.Add(info.Name);
            }
            comboBox1.SelectedIndex = 0;
        }
        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap b = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = b;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null && cam.IsRunning) cam.Stop();
        }

        private void FormQRcode_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning) cam.Stop();
            cam = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GiaiMa();
        }
        void GiaiMa()
        {
            Bitmap imgQRCode = (Bitmap)pictureBox1.Image;
            if (imgQRCode != null)
            {
                ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                Result result = Reader.Decode(imgQRCode);
                if (result != null)
                {

                    string qrText = result.Text;
                    string[] qrData = qrText.Split(' ');
                    CK cK = new CK();
                    cK.sotaikhoan = qrData[0];
                    cK.tennganhang = qrData[1];
                    cK.ID = ID;
                    cK.Show();
                    this.Close();
                    imgQRCode.Dispose();
                    timer1.Stop();

                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning) cam.Stop();
            cam = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
            timer1.Start();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning) cam.Stop();
            cam = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();
            timer1.Start();
        }
    }
}
