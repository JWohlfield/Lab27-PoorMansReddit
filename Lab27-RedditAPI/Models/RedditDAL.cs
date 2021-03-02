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
        public string GetPostData(string subreddit)
        {
            string url = @$"https://www.reddit.com/r/{subreddit.Trim()}/.json";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            //Grab the response from our request
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());
            string JSON = rd.ReadToEnd();

            return JSON;
        }

        public List<Child> GetPosts(string sub)
        {
            string json = GetPostData(sub);
            Rootobject r = JsonConvert.DeserializeObject<Rootobject>(json);
            return r.data.children.ToList();
        }
        
    }
}
