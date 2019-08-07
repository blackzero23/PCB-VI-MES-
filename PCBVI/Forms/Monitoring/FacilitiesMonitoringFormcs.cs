using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;

namespace PCBVI.Forms.Monitoring
{
    public partial class FacilitiesMonitoringFormcs : Form
    {
        public FacilitiesMonitoringFormcs()
        {
            InitializeComponent();
        }

        const string Source = @"http://192.168.0.28:8081/";

        private void OpenVideoSource(IVideoSource source)
        {
            this.CloseCurrentVideoSource();
            this.vspLineTv.VideoSource = source;
            this.vspLineTv.Start();
        }

        private void CloseCurrentVideoSource()
        {
            if (this.vspLineTv.VideoSource == null)
                return;
            this.vspLineTv.SignalToStop();
            for (int index = 0; index < 30 && this.vspLineTv.IsRunning; ++index)
            {
                Thread.Sleep(100);
            }
            if(this.vspLineTv.IsRunning)
                this.vspLineTv.Stop();
            this.vspLineTv.VideoSource = (IVideoSource) null;
        }

        private void FacilitiesMonitoringFormcs_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCurrentVideoSource();
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            CCTVURLForm form = new CCTVURLForm();

            form.Description = "Enter URL of an MJPEG video stream:";
            form.URLs = new string[]
            {
                @"http://192.168.0.28:8081/"
                    ,"http://192.168.0.30.8081."
            };

            if (form.ShowDialog(this) == DialogResult.OK)
            {
          
               MJPEGStream mjpegSource = new MJPEGStream(form.URL);
                // open it
               OpenVideoSource(mjpegSource);
            }
            
        }
    }
}
