namespace Formula1Downloader
{
    partial class ChooseVideos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseVideos));
            this.confirmButton = new System.Windows.Forms.Button();
            this.videosCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(296, 226);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // videosCheckedListBox
            // 
            this.videosCheckedListBox.FormattingEnabled = true;
            this.videosCheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.videosCheckedListBox.Name = "videosCheckedListBox";
            this.videosCheckedListBox.Size = new System.Drawing.Size(359, 199);
            this.videosCheckedListBox.TabIndex = 0;
            // 
            // ChooseVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.videosCheckedListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChooseVideos";
            this.Text = "Choose videos to download";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.CheckedListBox videosCheckedListBox;
    }
}