using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;

namespace Formula1Downloader
{
    public class Video
    {
        private string _title;

        public string Title => _title ?? (_title = GetVideoTitle());
        public string Id { get; }

        public Video(string id)
        {
            Id = id;
        }

        private string GetVideoTitle()
        {
            using (var webClient = new WebClient() { Encoding = Encoding.UTF8 })
            {
                string infoURL = string.Format("https://player.ooyala.com/player_api/v1/content_tree/embed_code/tudTgyOkO_Oa2kec6fNFnApvZ8ig/{0}?codecPriority=avc", Id);

                JObject infoJSON = JObject.Parse(webClient.DownloadString(infoURL));
                return infoJSON["content_tree"][Id]["title"].Value<string>();
            }
        }
    }
}
