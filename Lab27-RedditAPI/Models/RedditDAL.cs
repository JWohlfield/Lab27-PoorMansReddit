using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Lab27_RedditAPI.Models
{
    public class RedditDAL
    {
        public string GetPostData()
        {
            string url = @"https://www.reddit.com/r/aww/.json";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            //Grab the response from our request
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());
            string JSON = rd.ReadToEnd();

            return JSON;
        }

        public Rootobject PostData()
        {
            string posts = GetPostData();
            Rootobject ro = JsonConvert.DeserializeObject<Rootobject>(posts);
            return ro;
        }
    }
}
