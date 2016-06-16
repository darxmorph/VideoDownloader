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
            this.percentageLabel = new System.Windows.Forms.Label();
            this.creditsAndStuff = new System.Windows.Forms.LinkLabel();
            this.videoCountLabel = new System.Windows.Forms.Label();
            this.fragmentCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(478, 91);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(107, 34);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(0, 147);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(606, 35);
            this.downloadProgressBar.TabIndex = 1;
            // 
            // someDetails
            // 
            this.someDetails.AutoSize = true;
            this.someDetails.Location = new System.Drawing.Point(12, 11);
            this.someDetails.Name = "someDetails";
            this.someDetails.Size = new System.Drawing.Size(87, 13);
            this.someDetails.TabIndex = 5;
            this.someDetails.Text = "Insert video URL";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(15, 50);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(583, 20);
            this.urlTextBox.TabIndex = 7;
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new System.Drawing.Point(12, 131);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(62, 13);
            this.percentageLabel.TabIndex = 10;
            this.percentageLabel.Text = "Percentage";
            this.percentageLabel.Visible = false;
            // 
            // creditsAndStuff
            // 
            this.creditsAndStuff.AutoSize = true;
            this.creditsAndStuff.Location = new System.Drawing.Point(488, 9);
            this.creditsAndStuff.Name = "creditsAndStuff";
            this.creditsAndStuff.Size = new System.Drawing.Size(110, 13);
            this.creditsAndStuff.TabIndex = 11;
            this.creditsAndStuff.TabStop = true;
            this.creditsAndStuff.Text = "With <3 by darxmorph";
            this.creditsAndStuff.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditsAndStuff_LinkClicked);
            // 
            // videoCountLabel
            // 
            this.videoCountLabel.AutoSize = true;
            this.videoCountLabel.Location = new System.Drawing.Point(242, 102);
            this.videoCountLabel.Name = "videoCountLabel";
            this.videoCountLabel.Size = new System.Drawing.Size(61, 13);
            this.videoCountLabel.TabIndex = 12;
            this.videoCountLabel.Text = "videoCount";
            this.videoCountLabel.Visible = false;
            // 
            // fragmentCountLabel
            // 
            this.fragmentCountLabel.AutoSize = true;
            this.fragmentCountLabel.Location = new System.Drawing.Point(12, 102);
            this.fragmentCountLabel.Name = "fragmentCountLabel";
            this.fragmentCountLabel.Size = new System.Drawing.Size(76, 13);
            this.fragmentCountLabel.TabIndex = 13;
            this.fragmentCountLabel.Text = "fragmentCount";
            this.fragmentCountLabel.Visible = false;
            // 
            // ChooseURL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 182);
            this.Controls.Add(this.fragmentCountLabel);
            this.Controls.Add(this.videoCountLabel);
            this.Controls.Add(this.creditsAndStuff);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.someDetails);
            this.Controls.Add(this.downloadProgressBar);
            this.Controls.Add(this.downloadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.LinkLabel creditsAndStuff;
        private System.Windows.Forms.Label videoCountLabel;
        private System.Windows.Forms.Label fragmentCountLabel;
    }
}

