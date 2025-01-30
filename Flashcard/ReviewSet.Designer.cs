namespace Flashcard
{
    partial class ReviewSet
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewSet));
            this.FlashSetsLabel = new System.Windows.Forms.Label();
            this.CardQuestText = new System.Windows.Forms.TextBox();
            this.SetList = new System.Windows.Forms.ListBox();
            this.ShowAnsBttn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ReviewSetBttn = new System.Windows.Forms.Button();
            this.PrevBttn = new System.Windows.Forms.Button();
            this.NextBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlashSetsLabel
            // 
            this.FlashSetsLabel.AutoSize = true;
            this.FlashSetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FlashSetsLabel.Location = new System.Drawing.Point(20, 18);
            this.FlashSetsLabel.Name = "FlashSetsLabel";
            this.FlashSetsLabel.Size = new System.Drawing.Size(204, 31);
            this.FlashSetsLabel.TabIndex = 3;
            this.FlashSetsLabel.Text = "Flashcard Sets:";
            // 
            // CardQuestText
            // 
            this.CardQuestText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.CardQuestText.Location = new System.Drawing.Point(522, 63);
            this.CardQuestText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardQuestText.Multiline = true;
            this.CardQuestText.Name = "CardQuestText";
            this.CardQuestText.Size = new System.Drawing.Size(544, 354);
            this.CardQuestText.TabIndex = 6;
            this.CardQuestText.Text = "Question goes here";
            this.CardQuestText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetList
            // 
            this.SetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SetList.FormattingEnabled = true;
            this.SetList.ItemHeight = 25;
            this.SetList.Items.AddRange(new object[] { });
            this.SetList.Location = new System.Drawing.Point(26, 63);
            this.SetList.Margin = new System.Windows.Forms.Padding(2);
            this.SetList.Name = "SetList";
            this.SetList.Size = new System.Drawing.Size(373, 354);
            this.SetList.TabIndex = 7;
            // 
            // ShowAnsBttn
            // 
            this.ShowAnsBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowAnsBttn.Location = new System.Drawing.Point(522, 432);
            this.ShowAnsBttn.Margin = new System.Windows.Forms.Padding(2);
            this.ShowAnsBttn.Name = "ShowAnsBttn";
            this.ShowAnsBttn.Size = new System.Drawing.Size(544, 49);
            this.ShowAnsBttn.TabIndex = 9;
            this.ShowAnsBttn.Text = "Show Answer";
            this.ShowAnsBttn.UseVisualStyleBackColor = true;
            this.ShowAnsBttn.Click += new System.EventHandler(this.showAns_Click);
            // 
            // ReviewSetBttn
            // 
            this.ReviewSetBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ReviewSetBttn.Location = new System.Drawing.Point(26, 442);
            this.ReviewSetBttn.Margin = new System.Windows.Forms.Padding(2);
            this.ReviewSetBttn.Name = "ReviewSetBttn";
            this.ReviewSetBttn.Size = new System.Drawing.Size(373, 49);
            this.ReviewSetBttn.TabIndex = 10;
            this.ReviewSetBttn.Text = "Review Selected Set";
            this.ReviewSetBttn.UseVisualStyleBackColor = true;
            this.ReviewSetBttn.Click += new System.EventHandler(this.loadSetBttn_Click);
            // 
            // PrevBttn
            // 
            this.PrevBttn.Image = ((System.Drawing.Image)(resources.GetObject("PrevBttn.Image")));
            this.PrevBttn.Location = new System.Drawing.Point(460, 63);
            this.PrevBttn.Name = "PrevBttn";
            this.PrevBttn.Size = new System.Drawing.Size(56, 354);
            this.PrevBttn.TabIndex = 12;
            this.PrevBttn.UseVisualStyleBackColor = true;
            this.PrevBttn.Click += new System.EventHandler(this.PrevBttn_Click);
            // 
            // NextBttn
            // 
            this.NextBttn.Image = ((System.Drawing.Image)(resources.GetObject("NextBttn.Image")));
            this.NextBttn.Location = new System.Drawing.Point(1072, 63);
            this.NextBttn.Name = "NextBttn";
            this.NextBttn.Size = new System.Drawing.Size(56, 354);
            this.NextBttn.TabIndex = 13;
            this.NextBttn.UseVisualStyleBackColor = true;
            this.NextBttn.Click += new System.EventHandler(this.NextBttn_Click);
            // 
            // ReviewSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.NextBttn);
            this.Controls.Add(this.PrevBttn);
            this.Controls.Add(this.CardQuestText);
            this.Controls.Add(this.ReviewSetBttn);
            this.Controls.Add(this.ShowAnsBttn);
            this.Controls.Add(this.SetList);
            this.Controls.Add(this.FlashSetsLabel);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.Name = "ReviewSet";
            this.Size = new System.Drawing.Size(1235, 590);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label FlashSetsLabel;
        private System.Windows.Forms.TextBox CardQuestText;
        private System.Windows.Forms.ListBox SetList;
        private System.Windows.Forms.Button ShowAnsBttn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ReviewSetBttn;
        private System.Windows.Forms.Button PrevBttn;
        private System.Windows.Forms.Button NextBttn;
    }
}
