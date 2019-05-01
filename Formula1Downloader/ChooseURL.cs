using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using Microsoft.WindowsAPICodePack.Taskbar;
using Formula1Downloader.Downloaders;

namespace Formula1Downloader
{
    public partial class ChooseURL : Form
    {
        private readonly Queue<Tuple<Video, string>> _downloadQueue = new Queue<Tuple<Video, string>>();

        public ChooseURL()
        {
            InitializeComponent();
        }
        private void downloadButton_Click(object sender, EventArgs e)
        {
            ToggleUI(false);

            Uri videoURI = null;

            if (!(urlTextBox.Text.StartsWith("http://") || urlTextBox.Text.StartsWith("https://")))
                urlTextBox.Text = "https://" + urlTextBox.Text;

            bool isURLvalid = (urlTextBox.Text.StartsWith("http://www.formula1.com") || urlTextBox.Text.StartsWith("https://www.formula1.com"))
                && Uri.TryCreate(urlTextBox.Text, UriKind.Absolute, out videoURI)
                && (videoURI.Scheme == Uri.UriSchemeHttp || videoURI.Scheme == Uri.UriSchemeHttps);

            if (!isURLvalid)
            {
                MessageBox.Show("That doesn't look like a valid URL", ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToggleUI(true);
                return;
            }

            List<Video> videos = GetVideosFromUri(videoURI);

            if (videos.Count == 1)
            {
                var video = videos.First();
                var whereToSave = new SaveFileDialog
                {
                    Filter = preferMP4.Checked ? "MP4 video (*.mp4)|*.mp4|All files (*.*)|*.*" : "FLV video (*.flv)|*.flv|All files (*.*)|*.*",
                    FileName = CleanFileName(video.Title)
                };

                if (whereToSave.ShowDialog() == DialogResult.OK)
                {
                    AddToQueue(video, whereToSave.FileName);
                    ProcessQueue();
                }
                else
                {
                    ToggleUI(true);
                }
            }
            else if (videos.Count > 1)
            {
                using (var cv = new ChooseVideos(videos))
                {
                    cv.ShowDialog();
                    List<Video> checkedVideos = cv.GetCheckedVideos();
                    if (checkedVideos.Count > 0)
                    {
                        FolderBrowserDialog saveToDirectory = new FolderBrowserDialog();
                        if (saveToDirectory.ShowDialog() == DialogResult.OK)
                        {
                            foreach (var vid in checkedVideos)
                            {
                                string saveFilePath = Path.Combine(saveToDirectory.SelectedPath, CleanFileName(vid.Title)) + (preferMP4.Checked ? ".mp4" : ".flv");
                                AddToQueue(vid, saveFilePath);
                            }
                            ProcessQueue();
                            return;
                        }
                    }
                }

                ToggleUI(true);
            }
            else
            {
                MessageBox.Show("Error obtaning video info from URL", ActiveForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ToggleUI(true);
            }
        }

        private void AddToQueue(Video video, string filePath)
        {
            _downloadQueue.Enqueue(Tuple.Create(video, filePath));
        }

        private bool ProcessQueue()
        {
            if (_downloadQueue.Count > 0)
            {
                var item = _downloadQueue.Dequeue();

                videoTitleLabel.Text = item.Item1.Title;
                videoTitleLabel.Visible = true;
                DownloadVideo(item.Item1, item.Item2);
                return true;
            }

            return false;
        }

        private void DownloadVideo(Video video, string filePath)
        {
            Downloader d;

            if (preferMP4.Checked)
                d = new MP4Downloader(video, filePath);
            else
                d = new FLVDownloader(video, filePath);

            d.ProgressChanged += OnProgressChanged;
            d.DownloadComplete += OnDownloadComplete;
            d.StartDownload();
        }

        private void OnProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            downloadProgressBar.Value = e.ProgressPercentage;
            TaskbarManager.Instance.SetProgressValue(e.ProgressPercentage, 100);
        }

        private void OnDownloadComplete(object sender, EventArgs e)
        {
            if (!ProcessQueue())
            {
                downloadProgressBar.Value = 0;
                videoTitleLabel.Visible = false;
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);

                ToggleUI(true);
            }
        }

        private List<Video> GetVideosFromUri(Uri videoURI)
        {
            List<Video> vids = new List<Video>();

            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument htmlDoc = web.Load(videoURI.AbsoluteUri);
            HtmlNodeCollection mdNodeCol = htmlDoc.DocumentNode.SelectNodes("//div[@data-videoid]");

            if (mdNodeCol != null)
            {
                foreach (HtmlNode mdnode in mdNodeCol)
                {
                    HtmlAttribute desc = mdnode.Attributes["data-videoid"];
                    vids.Add(new Video(desc.Value));
                }
            }

            return vids;
        }

        private void ToggleUI(bool enable)
        {
            downloadButton.Enabled = enable;
            urlTextBox.Enabled = enable;
            preferMP4.Enabled = enable;
        }

        private void creditsAndStuff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/darxmorph");
        }

        private static string CleanFileName(string fileName)
        {
            return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
        }
    }
}
