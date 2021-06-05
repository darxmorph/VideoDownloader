using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
using System.Text;

namespace Formula1Downloader
{
    public class Video
    {
        public string Id { get; }
        public string Title { get; }
        public Uri Uri { get; }

        public Video(string id)
        {
            Id = id;

            using (var webClient = new WebClient() { Encoding = Encoding.UTF8 })
            {
                webClient.Headers[HttpRequestHeader.Accept] =
                    "application/json;pk=BCpkADawqM1hQVBuXkSlsl6hUsBZQMmrLbIfOjJQ3_n8zmPOhlNSwZhQBF6d5xggxm0t052lQjYyhqZR3FW2eP03YGOER9ihJkUnIhRZGBxuLhnL-QiFpvcDWIh_LvwN5j8zkjTtGKarhsdV";

                string infoURL = string.Format("https://edge.api.brightcove.com/playback/v1/accounts/6057949432001/videos/{0}", Id);

                JObject infoJSON = JObject.Parse(webClient.DownloadString(infoURL));
                Title = infoJSON["name"].Value<string>();
                JToken stream = infoJSON["sources"].Where(s => s["container"]?.Value<string>() == "MP4")
                    .Where(s => s["src"].Value<string>().StartsWith("https"))
                    .OrderByDescending(s => s["avg_bitrate"].Value<int>())
                    .First();
                Uri = new Uri(stream["src"].Value<string>());
            }
        }
    }
}
