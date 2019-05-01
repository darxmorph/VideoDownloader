using System;
using System.ComponentModel;

namespace Formula1Downloader.Downloaders
{
    public abstract class Downloader
    {
        public Video Video { get; protected set; }
        public string OutputFile { get; protected set; }

        public event EventHandler DownloadComplete;
        public event ProgressChangedEventHandler ProgressChanged;


        public abstract void StartDownload();

        protected virtual void OnDownloadComplete(EventArgs e)
        {
            EventHandler handler = DownloadComplete;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnProgressChanged(ProgressChangedEventArgs e)
        {
            ProgressChangedEventHandler handler = ProgressChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
