using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ProjectA.Core.Services
{
    public class NetworkHelper
    {
        
        public NetworkHelper()
        {

        }

        public void GetRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {

                    string content = reader.ReadToEnd();
                    Console.WriteLine(content);
                }
            } catch (WebException e)
            {
                Console.WriteLine(e);
            }
            
        }
        private void Download(string url)
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileAsync(
                    // Param1 = Link of file
                    new System.Uri(url),
                    // Param2 = Path to save
                    "..\\Data\\data.json"
                );
                Console.WriteLine("Done");
            }
        }

        static void Main() {
            NetworkHelper n = new NetworkHelper();
           //n.GetRequest("http://www.bom.gov.au/fwo/IDW60801/IDW60801.94802.json");
           n.Download("ftp://ftp.bom.gov.au/anon/gen/gms/IDE00005.201906251930.gif");

        }

    }
}  
