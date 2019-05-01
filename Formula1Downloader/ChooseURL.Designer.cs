namespace Formula1Downloader
{
    partial class ChooseURL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseURL));
            this.downloadButton = new System.Windows.Forms.Button();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.someDetails = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.creditsAndStuff = new System.Windows.Forms.LinkLabel();
            this.videoTitleLabel = new System.Windows.Forms.Label();
            this.preferMP4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(876, 168);
            this.downloadButton.Margin = new System.Windows.Forms.Padding(6);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(196, 63);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(0, 271);
            this.downloadProgressBar.Margin = new System.Windows.Forms.Padding(6);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(1111, 65);
            this.downloadProgressBar.TabIndex = 1;
            // 
            // someDetails
            // 
            this.someDetails.AutoSize = true;
            this.someDetails.Location = new System.Drawing.Point(22, 20);
            this.someDetails.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.someDetails.Name = "someDetails";
            this.someDetails.Size = new System.Drawing.Size(155, 25);
            this.someDetails.TabIndex = 5;
            this.someDetails.Text = "Insert video URL";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(28, 92);
            this.urlTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(1066, 29);
            this.urlTextBox.TabIndex = 7;
            // 
            // creditsAndStuff
            // 
            this.creditsAndStuff.AutoSize = true;
            this.creditsAndStuff.Location = new System.Drawing.Point(895, 17);
            this.creditsAndStuff.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.creditsAndStuff.Name = "creditsAndStuff";
            this.creditsAndStuff.Size = new System.Drawing.Size(204, 25);
            this.creditsAndStuff.TabIndex = 11;
            this.creditsAndStuff.TabStop = true;
            this.creditsAndStuff.Text = "With <3 by darxmorph";
            this.creditsAndStuff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditsAndStuff_LinkClicked);
            // 
            // videoTitleLabel
            // 
            this.videoTitleLabel.AutoSize = true;
            this.videoTitleLabel.Location = new System.Drawing.Point(22, 138);
            this.videoTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.videoTitleLabel.Name = "videoTitleLabel";
            this.videoTitleLabel.Size = new System.Drawing.Size(96, 25);
            this.videoTitleLabel.TabIndex = 12;
            this.videoTitleLabel.Text = "videoTitle";
            this.videoTitleLabel.Visible = false;
            // 
            // preferMP4
            // 
            this.preferMP4.AutoSize = true;
            this.preferMP4.Checked = true;
            this.preferMP4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preferMP4.Location = new System.Drawing.Point(27, 202);
            this.preferMP4.Name = "preferMP4";
            this.preferMP4.Size = new System.Drawing.Size(136, 29);
            this.preferMP4.TabIndex = 13;
            this.preferMP4.Text = "Prefer MP4";
            this.preferMP4.UseVisualStyleBackColor = true;
            // 
            // ChooseURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 336);
            this.Controls.Add(this.preferMP4);
            this.Controls.Add(this.videoTitleLabel);
            this.Controls.Add(this.creditsAndStuff);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.someDetails);
            this.Controls.Add(this.downloadProgressBar);
            this.Controls.Add(this.downloadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "ChooseURL";
            this.Text = "Formula1 Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.ProgressBar downloadProgressBar;
        private System.Windows.Forms.Label someDetails;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.LinkLabel creditsAndStuff;
        private System.Windows.Forms.Label videoTitleLabel;
        private System.Windows.Forms.CheckBox preferMP4;
    }
}

