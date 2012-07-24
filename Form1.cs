using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GraphTools;
using GraphTools.OSM;
using System.Net;
using System.IO;
using System.Globalization;

namespace CLCRelationMerge
{
    public partial class Form1 : Form
    {
        private String dataFile;
        private String clcFile;
        private String outputFile;
        private String polyFile;

        private double ExpandBoundingBoxValue = 0.01;
        private string tmpApiFileName = "tmp.osm";

        public BoundingBox BoundingBox { get; protected set; }

        public String DataFile
        {
            get { return dataFile; }
            set {
                dataFile = value;
                OriginalFileBox.Text = value;
            }
        }        

        public String ClcFile
        {
            get { return clcFile; }
            set {
                clcFile = value;
                CLCFileBox.Text = value;
                BoundingBox = null;
            }
        }        

        public String OutputFile
        {
            get { return outputFile; }
            set {
                outputFile = value;
                OutputFileBox.Text = value;
            }
        }

        public String PolyFile
        {
            get { return polyFile; }
            set
            {
                polyFile = value;
                polyFileBox.Text = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            OSMAPIHandler.DownloadResult += new OSMAPIHandler.DownloadEventHandler(client_DownloadDataCompleted);
        }

        private void OriginalButton_Click(object sender, EventArgs e)
        {
            OFD1.FileName = String.Empty;
            if (OFD1.ShowDialog() == DialogResult.OK)
            {
                DataFile = OFD1.FileName;
            }
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            if (SFD1.ShowDialog() == DialogResult.OK)
            {
                OutputFile = SFD1.FileName;
            }
        }

        private void CLCButton_Click(object sender, EventArgs e)
        {
            OFD1.FileName = String.Empty;
            if (OFD1.ShowDialog() == DialogResult.OK)
            {
                ClcFile = OFD1.FileName;
            }
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void MergeButton_Click(object sender, EventArgs e)
        {
            if (fromFileRadioButton.Checked && (DataFile == null || DataFile.Length <= 0))
            {
                MessageBox.Show("Please, select first a Data file.");
                return;
            }

            if (ClcFile == null || ClcFile.Length <= 0)
            {
                MessageBox.Show("Please, select first a CLC file.");
                return;
            }

            if (OutputFile == null || OutputFile.Length <= 0)
            {
                MessageBox.Show("Please, select first an output file.");
                return;
            }

            //Get bounding box from CLC file or Polyfile (depends radioButton) and increase with value of ExpandBoundingBoxvalue (default: 0.01)
            this.BoundingBox = GetBoundingBox();
            if (this.BoundingBox == null && fromApiRadioButton.Checked)
            {
                return;
            }

            this.Enabled = false;

            if (fromApiRadioButton.Checked)
            {
                if (Math.Abs(BoundingBox.Left - BoundingBox.Right) > 0.25 ||
                Math.Abs(BoundingBox.Bottom - BoundingBox.Top) > 0.25)
                {
                    MessageBox.Show("Error! Downloadable area too large. Please download it manually.");
                    this.Enabled = true;
                    return;
                }
                OutputLabel.Text = "Downloading file...";

                try
                {
                    OSMAPIHandler.GetMap(BoundingBox);
                }
                catch (WebException ex)
                {
                    MessageBox.Show("File download failed: " + ex.Message);
                    this.Enabled = true;
                    return;
                }
            }
            else
            {
                OutputLabel.Text="Processing data...";
                bgWorker1.RunWorkerAsync();
            }
        }

        private void bgWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Worker worker = new Worker(DataFile, ClcFile, OutputFile);
            worker.LoadFromFiles();
            worker.BoundingBox = BoundingBox;
            worker.DoJob();
        }

        private void bgWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GC.Collect();
            MessageBox.Show("Job Done!");
            if (fromApiRadioButton.Checked)
            {
                File.Delete(DataFile);
                DataFile = string.Empty;
            }
            OutputLabel.Text = "Job Done.";
            this.Enabled = true;
        }

        private void showClcAreaButton_Click(object sender, EventArgs e)
        {
            if (ClcFile == null || ClcFile.Length <= 0)
            {
                MessageBox.Show("Please, select first a CLC file below.");
                return;
            }
            if (BoundingBox == null)
            {
                BoundingBox = GetBoundingBox();
                if (BoundingBox == null) return;
            }
            //change comma to dot
            System.Globalization.NumberFormatInfo myFormat = new System.Globalization.NumberFormatInfo();
            myFormat.CurrencyDecimalSeparator = ".";

            //open in browser
            string mapUrl = string.Format(myFormat,@"http://openstreetmap.org/?minlon={0}&maxlon={1}&minlat={2}&maxlat={3}&box=yes",
                BoundingBox.Left, BoundingBox.Right,
                BoundingBox.Bottom, BoundingBox.Top);
            System.Diagnostics.Process.Start(mapUrl);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            OriginalButton.Enabled = fromFileRadioButton.Checked;
        }

        void client_DownloadDataCompleted(object sender, OSMAPIHandler.DownloadEventArgs e)
        {
            if (e.Success)
            {
                DataFile = tmpApiFileName;
                File.WriteAllBytes(DataFile, e.Result);
                OutputLabel.Text = "Download completed. Processing data...";
                bgWorker1.RunWorkerAsync();
            }
            else
            {
                OutputLabel.Text = "Error: ";
                if (e.Exception != null) OutputLabel.Text += e.Exception.Message;
                else OutputLabel.Text += "Unknown";
                this.Enabled = true;
            }
        }

        protected BoundingBox GetBoundingBox()
        {
            BoundingBox result = null;
            if (fromExternalPolyRadioButton.Checked)
            {
                if (PolyFile == null || !File.Exists(PolyFile))
                {
                    MessageBox.Show("Error! Invalid Poly file.");
                    return null;
                }
                result = BoundingBox.GetFromPolyFile(PolyFile);
            }
            else
            {
                if (ClcFile==null || !File.Exists(ClcFile)){
                    MessageBox.Show("Error! Invalid CLC file.");
                    return null;
                }
                result = BoundingBox.GetFromOSMFile(ClcFile);
            }
            result.ExpandBorder(ExpandBoundingBoxValue);
            return result;
        }

        private void fromExternalPolyRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            boundingBoxSelectButton.Enabled = fromExternalPolyRadioButton.Checked;
            this.BoundingBox = null;
            
        }

        private void boundingBoxSelectButton_Click(object sender, EventArgs e)
        {
            if (OFD2.ShowDialog() == DialogResult.OK)
            {
                this.PolyFile = OFD2.FileName;
            }
        }
    }
}
