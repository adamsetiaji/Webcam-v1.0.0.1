using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Drawing.Imaging;



namespace Webcam
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice VideoSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo DeviceList in CaptureDevice)
            {
                WebCamList.Items.Add(DeviceList.Name);
            }
            WebCamList.SelectedIndex = 0;
            VideoSource = new VideoCaptureDevice();
        }

        private void BtnStartCamera_Click(object sender, EventArgs e)
        {
            if (VideoSource.IsRunning)
            {
                VideoSource.SignalToStop();
                VideoSource.WaitForStop();
                CaptureBox.Image = null;
                CaptureBox.Invalidate();
            }
            VideoSource = new VideoCaptureDevice(CaptureDevice[WebCamList.SelectedIndex].MonikerString);
            VideoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            VideoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            CaptureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }


        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(null);
        }


        private void BtnCapture_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)CaptureBox.Image.Clone();
        }
    }
}