using GoogleApisYoutube.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GoogleApisYoutube.Common
{
    public class ApiHelp
    {
        public SearchJsonModel GetData(string SearchText)
        {
            string Uri = @"https://www.googleapis.com/youtube/v3/search?part=snippet&q={0}&maxResults=20&order=relevance&type=video&key=AIzaSyBsNbEER0Vg4t_kQYUeNxXj1rK-JUGD6Q4";
            Uri = string.Format(Uri, SearchText);

            string content = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Uri);
            WebResponse response = request.GetResponse();

            Encoding encoding = Encoding.UTF8;
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), encoding))
            {
                content = reader.ReadToEnd();
            }

            SearchJsonModel Data = JsonConvert.DeserializeObject<SearchJsonModel>(content);

            return Data;
        }
    }
}
