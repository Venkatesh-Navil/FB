using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Video.VFW;
using AForge;
using AForge.Video.FFMPEG;
using System.IO;

using System.Threading;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;

//using QuartzTypeLib;

namespace FootBallApplication
{
    public partial class Vide_Recorder : UserControl
    {

        #region Declaration
        private bool DeviceExist = false;
        //private FilterInfoCollection videoDevices;
        //private VideoCaptureDevice videoSource = null;
        //private FileVideoSource Filesource = null;
        int timecounter = 0;
        string start = "Start";
        int frate = 25;
        string Rhrs, Rmins, Rsecs, Rmilsecs;
        System.Windows.Forms.Timer tms = new System.Windows.Forms.Timer();
        private FilterInfoCollection videoDevicesPlayer;
        private VideoCaptureDevice videoCaptureSource = null;
        bool FirstTime = true;
        int Height, Width;
        VideoFileWriter Playerwriter = new VideoFileWriter();
        double endt;
        private FilterInfoCollection videoDevices;
        int act = 0;
        double tottm, diff, diff1;
        double starts = 0; string Ftype;
        private const int WM_APP = 0x8000;
        private const int WM_GRAPHNOTIFY = WM_APP + 1;
        string filename = "";
        private Boolean isRecord = false;
        private void btnRecord_Click(object sender, EventArgs e)
        {
            recordstart(1);
        }
        private void getCamList()
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cmbDevice.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cmbDevice.Items.Add(device.Name);
                }
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                cmbDevice.Items.Add("No video capture device on your system");
            }
        }

        private void btndevice_Click(object sender, EventArgs e)
        {
            getCamList();
        }
        void videoCaptureSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ////throw new NotImplementedException();
            //if (isRecord)
            //{
            //    Bitmap img = (Bitmap)eventArgs.Frame.Clone();               
            //    writer.WriteVideoFrame(img);
            //    img.Dispose();
            //    img = null;
            //}
            if (FirstTime)
            {
                Playerwriter = new VideoFileWriter();

                Bitmap imgage1 = (Bitmap)eventArgs.Frame.Clone();
                Width = imgage1.Width;
                Height = imgage1.Height;
                imgage1.Dispose();
                imgage1 = null;
                FirstTime = false;
            }

            if (isRecord)
            {
                try
                {
                    Bitmap image = (Bitmap)eventArgs.Frame.Clone();
                    Playerwriter.WriteVideoFrame(image);
                    image.Dispose();
                    image = null;
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);

                }
            }
        }
        private void cmbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                videoCaptureSource = new VideoCaptureDevice(videoDevices[cmbDevice.SelectedIndex].MonikerString);
                videoCaptureSource.NewFrame += videoCaptureSource_NewFrame;
                videoCaptureSource.Start();
                videoSourcePlayer1.VideoSource = videoCaptureSource;
                videoSourcePlayer1.Start();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private const int EC_COMPLETE = 0x01;
        private const int WS_CHILD = 0x40000000;
        private const int WS_CLIPCHILDREN = 0x2000000;
        //private FilgraphManager ifilmanager = null;
        //private IBasicAudio iaudio = null;
        //private IMediaControl icontrol = null;
        //private IMediaPosition iposition = null;
        //private IMediaEvent ievent = null;
        //private IMediaEventEx ieventex = null;
        //private IVideoWindow iwindow = null;
        #endregion
        public Vide_Recorder()
        {
            InitializeComponent();
        }

        private void Vide_Recorder_Load(object sender, EventArgs e)
        {

           
        }
        public void recordstart(int value)
        {
            try
            {
               
                    if (start == "Start")
                    {

                    isRecord = true;

                    start = "Stop";
                   
                      
                        Playerwriter.Open(filename, Width, Height, 25, VideoCodec.MPEG4, 9000000);
                    }
                    else if (start == "Stop")
                    {
                        
                            Playerwriter.Close();
                            //Playerwriter = new VideoFileWriter();
                        }
                        
                        // General.record = 2;

                    }
                
               
            catch
            {
            }
        }
    }
}
