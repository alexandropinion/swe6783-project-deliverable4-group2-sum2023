using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace project_deliverable_4
{
    public partial class Live : Form
    {
        System.Windows.Forms.Timer load_timer = new System.Windows.Forms.Timer();
        public Live()
        {
            InitializeComponent();
            InitializeUI();
        }

        private Thread? cameraLoad = null;  // Thread used to handle loading event
        private VideoCaptureDevice videoCam;
        private FilterInfoCollection availDevices;

        private void button1_Click(object sender, EventArgs e)
        {
            //cameraLoad = new Thread(startCamera);
            startCamera();
            load_timer.Interval = 100; // ms
            load_timer.Start();
            button2.Visible = true;
            //cameraLoad.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (cameraLoad != null)
            {
                //cameraLoad.Stop();
            }
        }

        private void InitializeUI()
        {
            if (!loadCamera())
            {
                button1.Enabled = false;
            }
            button2.Enabled = false;
            button2.Visible = true;
        }

        private void startCamera()
        {
            button1.Enabled = false;
            button2.Enabled = true;
            videoCam = new VideoCaptureDevice(availDevices[comboBox1.SelectedIndex].MonikerString);
            videoCam.NewFrame += new NewFrameEventHandler(videoCam_Event);
            videoCam.Start();
            if (cameraLoad == null)
            {
                load_timer.Stop();
                return;
            }
            else if (cameraLoad.IsAlive)
            {
                return;
            }
            else
            {
                cameraLoad = null;
                load_timer.Stop();
            }
        }

        private void videoCam_Event(object sender, NewFrameEventArgs e)
        {
            pictureBox1.Image = (Bitmap)e.Frame.Clone();
        }

        private bool loadCamera()
        {
            bool deviceIsAvailable = false;
            availDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo camera in availDevices)
            {
                comboBox1.Items.Add(camera.Name);
                deviceIsAvailable = true;
            }
            comboBox1.SelectedIndex = 0;
            videoCam = new VideoCaptureDevice();
            return deviceIsAvailable;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (videoCam.IsRunning == true)
            {
                videoCam.SignalToStop();
            }
            pictureBox1.Image = null; // clear last frame
            button2.Enabled = false;
            button1.Enabled = true;

        }

        private void Live_Closed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
        }
    }
}
