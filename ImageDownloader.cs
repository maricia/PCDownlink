using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PCDownlink
{
    public class ImageDownloader
    {


        private static string myPath = @"C:\BackGroundImage\latest.jpg";//10000x6000.jpg

        public static string imageLocation = "https://cdn.star.nesdis.noaa.gov/GOES16/ABI/CONUS/GEOCOLOR/latest.jpg".Trim();//10000x600
        // A public method that takes an image URL and a local file name as parameters

        public static void CheckDirLocation()
        {
            try
            {
                if (Directory.Exists(myPath))
                {
                    Directory.CreateDirectory(myPath);
                }
                //Directory.CreateDirectory(myPath);
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show("Error Will Robison Can not write to myPath", "ERROR", MessageBoxButtons.OK);
                //throw;
            }

        }



        public static async void DownloadImage(string imageLocation)
        {
            CheckDirLocation();
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(imageLocation))
                {
                    // response.EnsureSuccessStatusCode();
                    using (Stream stream = await response.Content.ReadAsStreamAsync())
                    {
                        using (FileStream fileStream = new FileStream(@"C:\BackGroundImage\latest.jpg", FileMode.Create, FileAccess.Write))//10000x6000
                        {
                            stream.CopyTo(fileStream);
                        }
                    }

                }
            }
           

        }

    }
}

