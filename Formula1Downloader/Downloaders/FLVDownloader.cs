using hdsdump;
using System;
using System.ComponentModel;

namespace Formula1Downloader.Downloaders
{
    public class FLVDownloader : Downloader
    {
        public FLVDownloader(Video video, string outFile)
        {
            Video = video;
            OutputFile = outFile;
        }


        public override void StartDownload()
        {
            BackgroundWorker downloadWorker = new BackgroundWorker();
            downloadWorker.DoWork += delegate
            {
                F4F f4f = new F4F();
                f4f.outPath = OutputFile;
                f4f.DownloadFragments(GetF4MManifestURLForVideoId(Video.Id), (fragNum, fragCount) => {
                    downloadWorker.ReportProgress(fragNum * 100 / fragCount);
                });
            };
            downloadWorker.ProgressChanged += (sender, e) =>
            {
                OnProgressChanged(e);
            };
            downloadWorker.RunWorkerCompleted += delegate
            {
                OnDownloadComplete(new EventArgs());
            };
            downloadWorker.WorkerReportsProgress = true;
            downloadWorker.RunWorkerAsync();
        }

        private static string GetF4MManifestURLForVideoId(string videoId)
        {
            return string.Format("http://f1.pc.cdn.bitgravity.com/{0}/{0}_1.f4m", videoId);
        }
    }
}
