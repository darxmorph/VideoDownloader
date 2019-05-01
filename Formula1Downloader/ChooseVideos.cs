using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Formula1Downloader
{
    public partial class ChooseVideos : Form
    {
        private List<Video> AvailableVideos { get; }

        public ChooseVideos(List<Video> itemList)
        {
            InitializeComponent();
            AvailableVideos = itemList;

            this.Load += delegate
            {
                foreach (Video v in itemList)
                {
                    videosCheckedListBox.Items.Add(v.Title);
                }
            };

            confirmButton.Click += delegate
            {
                this.Close();
            };
        }

        public List<Video> GetCheckedVideos()
        {
            List<Video> result = new List<Video>();

            foreach (string s in videosCheckedListBox.CheckedItems.Cast<string>())
            {
                foreach (Video v in AvailableVideos)
                {
                    if (v.Title == s)
                    {
                        result.Add(v);
                    }
                }
            }

            return result;
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle |= CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
