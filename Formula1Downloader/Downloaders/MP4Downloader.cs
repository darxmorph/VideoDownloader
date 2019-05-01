using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;

namespace Formula1Downloader.Downloaders
{
    public class MP4Downloader : Downloader
    {
        public MP4Downloader(Video video, string outFile)
        {
            Video = video;
            OutputFile = outFile;
        }

        public override void StartDownload()
        {
            using (var webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);

                webClient.DownloadFileAsync(GetVideoURI(), OutputFile);
            }
        }

        private Uri GetVideoURI()
        {
            using (var webClient = new WebClient())
            {
                string authorizationURL = string.Format("https://player.ooyala.com/sas/player_api/v2/authorization/embed_code/tudTgyOkO_Oa2kec6fNFnApvZ8ig/{0}?codecPriority=avc&device=html5&domain=www.formula1.com&supported_formats=mp4&player_type=video", Video.Id);

                JObject authJSON = JObject.Parse(webClient.DownloadString(authorizationURL));
                JToken stream = authJSON["authorization_data"][Video.Id]["streams"].OrderByDescending(s => s["video_bitrate"].Value<int>()).First();

                return new Uri(Encoding.UTF8.GetString(Convert.FromBase64String(stream["url"]["data"].Value<string>())));
            }
        }

        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            OnProgressChanged(e);
        }

        private void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            OnDownloadComplete(e);
        }
    }
}
