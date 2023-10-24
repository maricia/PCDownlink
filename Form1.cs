using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;

namespace PCDownlink
{
    public partial class ItemsForm : Form
    {
        public string imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/latest.jpg".Trim();
        public string simage = "ContinentalUS";
        string myPath = @"C:\BackGroundImage\latest.jpg";
        private int counter;
        private int myCount;
        Stopwatch stopwatch;

        public ItemsForm()
        {
            InitializeComponent();

        }
        private void ItemsForm_Load(object sender, EventArgs e)
        {
            fillInLabels();
            ImageDownloader.DownloadImage(imageLocation);
            Wallpaper.Set(myPath);
            StartTimer();

        }

        private void StartTimer()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            myCount = 0;
            counter = 0;
            //myTimer.Interval = 300000;
            myTimer.Enabled = true;
            resultLabel.Text = "";
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            //throw new NotImplementedException();

        }
        private void CountDown()
        {
            if (counter != 1)
            {
                // lblCountDown.Text = "Time: " + (stopwatch.ElapsedMilliseconds / 1000).ToString();
                lblCountDown.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", stopwatch.Elapsed);
                //string.Format("{0:hh\\:mm\\:ss\\.ff}", stopwatch.ElapsedMilliseconds /1000 );
            }
        }
        private void myTimer_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show(resultLabel.Text, lblCountDown.ToString());
            lblCountDown.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", stopwatch.Elapsed);
            if (counter >= 1)//300000
            {
                //resultLabel.Text = "Procedure Run: " + counter.ToString();
                //exit code
                myTimer.Enabled = false;
                counter = 0;
            }
            else
            {
                ImageDownloader.DownloadImage(imageLocation);
                Wallpaper.Set(myPath);
                fillInLabels();
                //counter++;
                myCount++;
                resultLabel.Text = "Procedure Run: " + myCount.ToString();
                //counter = 0;
            }
        }

        public void LoadImages()
        {
            var Rootobject = new Rootobject();
            var Source = new Source();
            var Url = new Url();
            var i = 1;
            PictureBox[] pictureBox = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10 };

            using (StreamReader r = new StreamReader(@"C:\Users\maric\source\repos\PCDownlink\ImageSource.json"))
            {
                string json = r.ReadToEnd();
                Rootobject = JsonSerializer.Deserialize<Rootobject>(json);
                Source = JsonSerializer.Deserialize<Source>(json);
                Url = JsonSerializer.Deserialize<Url>(json);
            }
            //check for data in your list
            if (Rootobject != null && Rootobject.sources.Count() > 0)
            {
                foreach (var satimg in Rootobject.sources)
                {
                    var simage = satimg.name;
                    var surl = satimg.url.tiny;
                    pictureBox[i].ImageLocation = surl;
                    i++;
                    Console.WriteLine($"{simage} : {surl}");
                }


            }

        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton? button = sender as RadioButton;
            string imagename = button.Name;
            simage = imagename;
            switchImage(simage);
        }


        private void switchImage(string simage)
        {

            switch (simage)
            {
                case "ContinentalUS":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "TropicalAtlantic":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/taw/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "TropicalPacific":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/SECTOR/tpw/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "USWestCoast":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/CONUS/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "NorthernSouthAmerica":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/ssa/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "SouthernSouthAmerica":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/SECTOR/ssa/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "Himawari8FullDisk":
                    imageLocation = "http://rammb.cira.colostate.edu/ramsdis/online/images/latest_hi_res/himawari-8/full_disk_ahi_true_color.jpg".Trim();
                    break;
                case "NorthernPacific":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/SECTOR/np/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "GOESEastFullDisk":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES17/ABI/FD/GEOCOLOR/latest.jpg".Trim();
                    break;
                case "GOESWestFullDisk":
                    imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/FD/GEOCOLOR/latest.jpg".Trim();
                    break;
                default:
                    break;
            }

        }
        //string imageLocation, BackgroundWorker worker, DoWorkEventArgs e
        private void RefreshBackground(object sender, EventArgs e)
        {
            ImageDownloader.DownloadImage(imageLocation);
            Wallpaper.Set(myPath);
            fillInLabels();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (imageLocation == null)
            {
                throw new Exception("image location is emoty");
            }
            //MessageBox.Show("download fresh image");
            ImageDownloader.DownloadImage(imageLocation);
            fillInLabels();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(myPath))
            {
                Wallpaper.Set(myPath);
                //MessageBox.Show("refresh background / set wallpaper");

            }
            else throw new Exception("myPath is empty");

        }
        private void fillInLabels()
        {
            lbllastwritetime.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", File.GetLastWriteTime(myPath).ToString());//;
            lblcurrenttime.Text = DateTime.Now.ToString();
            //minutes = (milliseconds/1000)/60) resultLabel.Text =
        }


    }
}