using System;
using System.Windows.Forms;

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
            this.SetList = new System.Windows.Forms.ListBox();
            this.ShowAnsBttn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ReviewSetBttn = new System.Windows.Forms.Button();
            this.PrevBttn = new System.Windows.Forms.Button();
            this.NextBttn = new System.Windows.Forms.Button();
            this.DeleteSetBttn = new System.Windows.Forms.Button();
            this.CardQuestText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SetList
            // 
            this.SetList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.SetList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SetList.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetList.ForeColor = System.Drawing.Color.White;
            this.SetList.FormattingEnabled = true;
            this.SetList.ItemHeight = 29;
            this.SetList.Location = new System.Drawing.Point(477, 276);
            this.SetList.Margin = new System.Windows.Forms.Padding(2);
            this.SetList.Name = "SetList";
            this.SetList.Size = new System.Drawing.Size(958, 116);
            this.SetList.TabIndex = 7;
            // 
            // ShowAnsBttn
            // 
            this.ShowAnsBttn.BackColor = System.Drawing.Color.Transparent;
            this.ShowAnsBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowAnsBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowAnsBttn.FlatAppearance.BorderSize = 0;
            this.ShowAnsBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ShowAnsBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ShowAnsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowAnsBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowAnsBttn.ForeColor = System.Drawing.Color.Transparent;
            this.ShowAnsBttn.Image = ((System.Drawing.Image)(resources.GetObject("ShowAnsBttn.Image")));
            this.ShowAnsBttn.Location = new System.Drawing.Point(778, 887);
            this.ShowAnsBttn.Margin = new System.Windows.Forms.Padding(2);
            this.ShowAnsBttn.Name = "ShowAnsBttn";
            this.ShowAnsBttn.Size = new System.Drawing.Size(363, 50);
            this.ShowAnsBttn.TabIndex = 9;
            this.ShowAnsBttn.Tag = "showAns";
            this.ShowAnsBttn.UseVisualStyleBackColor = true;
            this.ShowAnsBttn.Click += new System.EventHandler(this.showAns_Click);
            // 
            // ReviewSetBttn
            // 
            this.ReviewSetBttn.BackColor = System.Drawing.Color.Transparent;
            this.ReviewSetBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReviewSetBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReviewSetBttn.FlatAppearance.BorderSize = 0;
            this.ReviewSetBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReviewSetBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReviewSetBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewSetBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ReviewSetBttn.ForeColor = System.Drawing.Color.Transparent;
            this.ReviewSetBttn.Image = ((System.Drawing.Image)(resources.GetObject("ReviewSetBttn.Image")));
            this.ReviewSetBttn.Location = new System.Drawing.Point(482, 448);
            this.ReviewSetBttn.Margin = new System.Windows.Forms.Padding(2);
            this.ReviewSetBttn.Name = "ReviewSetBttn";
            this.ReviewSetBttn.Size = new System.Drawing.Size(470, 56);
            this.ReviewSetBttn.TabIndex = 10;
            this.ReviewSetBttn.UseVisualStyleBackColor = false;
            this.ReviewSetBttn.Click += new System.EventHandler(this.loadSetBttn_Click);
            // 
            // PrevBttn
            // 
            this.PrevBttn.BackColor = System.Drawing.Color.Transparent;
            this.PrevBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PrevBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevBttn.FlatAppearance.BorderSize = 0;
            this.PrevBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PrevBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PrevBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PrevBttn.ForeColor = System.Drawing.Color.Transparent;
            this.PrevBttn.Image = ((System.Drawing.Image)(resources.GetObject("PrevBttn.Image")));
            this.PrevBttn.Location = new System.Drawing.Point(280, 621);
            this.PrevBttn.Name = "PrevBttn";
            this.PrevBttn.Size = new System.Drawing.Size(149, 138);
            this.PrevBttn.TabIndex = 12;
            this.PrevBttn.UseVisualStyleBackColor = true;
            this.PrevBttn.Click += new System.EventHandler(this.PrevBttn_Click);
            // 
            // NextBttn
            // 
            this.NextBttn.BackColor = System.Drawing.Color.Transparent;
            this.NextBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBttn.FlatAppearance.BorderSize = 0;
            this.NextBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NextBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NextBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NextBttn.ForeColor = System.Drawing.Color.Transparent;
            this.NextBttn.Image = ((System.Drawing.Image)(resources.GetObject("NextBttn.Image")));
            this.NextBttn.Location = new System.Drawing.Point(1491, 622);
            this.NextBttn.Name = "NextBttn";
            this.NextBttn.Size = new System.Drawing.Size(146, 134);
            this.NextBttn.TabIndex = 13;
            this.NextBttn.UseVisualStyleBackColor = true;
            this.NextBttn.Click += new System.EventHandler(this.NextBttn_Click);
            // 
            // DeleteSetBttn
            // 
            this.DeleteSetBttn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteSetBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteSetBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteSetBttn.FlatAppearance.BorderSize = 0;
            this.DeleteSetBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteSetBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteSetBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSetBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DeleteSetBttn.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteSetBttn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteSetBttn.Image")));
            this.DeleteSetBttn.Location = new System.Drawing.Point(965, 448);
            this.DeleteSetBttn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteSetBttn.Name = "DeleteSetBttn";
            this.DeleteSetBttn.Size = new System.Drawing.Size(473, 56);
            this.DeleteSetBttn.TabIndex = 14;
            this.DeleteSetBttn.UseVisualStyleBackColor = false;
            this.DeleteSetBttn.Click += new System.EventHandler(this.deleteSetBttn_Click);
            // 
            // CardQuestText
            // 
            this.CardQuestText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(46)))), ((int)(((byte)(68)))));
            this.CardQuestText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardQuestText.Cursor = System.Windows.Forms.Cursors.Default;
            this.CardQuestText.Font = new System.Drawing.Font("OCR A Extended", 32F, System.Drawing.FontStyle.Bold);
            this.CardQuestText.ForeColor = System.Drawing.Color.White;
            this.CardQuestText.Location = new System.Drawing.Point(488, 566);
            this.CardQuestText.Name = "CardQuestText";
            this.CardQuestText.ReadOnly = true;
            this.CardQuestText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CardQuestText.SelectionAlignment = HorizontalAlignment.Center;
            this.CardQuestText.Size = new System.Drawing.Size(947, 290);
            this.CardQuestText.TabIndex = 15;
            this.CardQuestText.Text = "";
            // 
            // ReviewSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.CardQuestText);
            this.Controls.Add(this.DeleteSetBttn);
            this.Controls.Add(this.NextBttn);
            this.Controls.Add(this.PrevBttn);
            this.Controls.Add(this.ReviewSetBttn);
            this.Controls.Add(this.ShowAnsBttn);
            this.Controls.Add(this.SetList);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.Name = "ReviewSet";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox SetList;
        private System.Windows.Forms.Button ShowAnsBttn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ReviewSetBttn;
        private System.Windows.Forms.Button PrevBttn;
        private System.Windows.Forms.Button NextBttn;
        private System.Windows.Forms.Button DeleteSetBttn;
        private System.Windows.Forms.RichTextBox CardQuestText;
    }
}
