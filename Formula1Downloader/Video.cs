using System;

namespace Formula1Downloader
{
    public class Video
    {
        #region Computed Propoperties
        public string Title { get; }
        public string Id { get; }
        public string ManifestUrl { get; }
        #endregion

        #region Constructors
        public Video(string title, string id, string manifesturl)
        {
            this.Title = title;
            this.Id = id;
            this.ManifestUrl = manifesturl;
        }
        #endregion
    }
}
