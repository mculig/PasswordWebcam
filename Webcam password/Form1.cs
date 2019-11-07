using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Webcam_password
{
    public partial class Form1 : Form
    {

        FilterInfoCollection fic;
        VideoCaptureDevice cam;
        EventLog myLog;
        Bitmap lastImage;

        public Form1()
        {
            InitializeComponent();

        }

        private void OnEntryWritten(object source, EntryWrittenEventArgs e)
        {
            
            int e1 = myLog.Entries.Count - 1;
            EventLogEntry last = myLog.Entries[e1];

            if (last.InstanceId == 4625)
                if (cam.IsRunning)
                        lastImage.Save(pathBox.Text + "\\WebcamPassword_Intruder_" + DateTime.Now.ToString("yyyyMMddTHHMMss") + ".png", ImageFormat.Png);
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AForge video stuff
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in fic)
                camBox.Items.Add(Device.Name);
            cam = new VideoCaptureDevice();
            camBox.SelectedIndex = 0;

            //Eventlog stuff

            myLog = new EventLog("Security");
            myLog.EntryWritten += new EntryWrittenEventHandler(OnEntryWritten);
            myLog.EnableRaisingEvents = true;

            pathBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        }

        private void camBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cam.IsRunning)
                cam.Stop();
            cam = new VideoCaptureDevice(fic[camBox.SelectedIndex].MonikerString);
            cam.NewFrame += newFrame;
            cam.Start();
        }

        private void newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            lastImage = (Bitmap)eventArgs.Frame.Clone();
            picBox.Image = (Bitmap) lastImage.Clone();
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void pathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if( dialog.ShowDialog() == DialogResult.OK)
            {
                pathBox.Text = dialog.SelectedPath;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam.IsRunning)
                cam.Stop();
        }
    }
}
