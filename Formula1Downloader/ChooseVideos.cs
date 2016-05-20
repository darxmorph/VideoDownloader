using System.Windows.Forms;

namespace Formula1Downloader
{
    public partial class ChooseVideos : Form
    {
        public CheckedListBox.CheckedItemCollection CheckedItems { get; set; }
        public ChooseVideos(string[] itemList)
        {
            InitializeComponent();

            this.Load += delegate
            {
                foreach (string s in itemList)
                {
                    videosCheckedListBox.Items.Add(s);
                }
            };

            confirmButton.Click += delegate
            {
                CheckedItems = videosCheckedListBox.CheckedItems;
                this.Close();
            };
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }
}
