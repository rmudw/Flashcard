namespace Flashcard
{
    partial class CreateSet
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FlashLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.SetList = new System.Windows.Forms.ListBox();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.AddBttn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DeleteBttn = new System.Windows.Forms.Button();
            this.SetNameLabel = new System.Windows.Forms.Label();
            this.SaveSetBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBox2.Location = new System.Drawing.Point(199, 12);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(981, 38);
            this.textBox2.TabIndex = 2;
            // 
            // FlashLabel
            // 
            this.FlashLabel.AutoSize = true;
            this.FlashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.FlashLabel.Location = new System.Drawing.Point(829, 70);
            this.FlashLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FlashLabel.Name = "FlashLabel";
            this.FlashLabel.Size = new System.Drawing.Size(124, 26);
            this.FlashLabel.TabIndex = 3;
            this.FlashLabel.Text = "Flashcards:";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.QuestionLabel.Location = new System.Drawing.Point(28, 70);
            this.QuestionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(105, 26);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Question:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(33, 99);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(739, 30);
            this.textBox1.TabIndex = 5;
            // 
            // AnswerText
            // 
            this.AnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AnswerText.Location = new System.Drawing.Point(33, 210);
            this.AnswerText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AnswerText.Multiline = true;
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(739, 282);
            this.AnswerText.TabIndex = 6;
            // 
            // SetList
            // 
            this.SetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SetList.FormattingEnabled = true;
            this.SetList.ItemHeight = 25;
            this.SetList.Items.AddRange(new object[] {
            "Set 1",
            "Set 2"});
            this.SetList.Location = new System.Drawing.Point(834, 99);
            this.SetList.Name = "SetList";
            this.SetList.Size = new System.Drawing.Size(346, 404);
            this.SetList.TabIndex = 7;
            this.SetList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.AnswerLabel.Location = new System.Drawing.Point(28, 171);
            this.AnswerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(91, 26);
            this.AnswerLabel.TabIndex = 8;
            this.AnswerLabel.Text = "Answer:";
            // 
            // AddBttn
            // 
            this.AddBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddBttn.Location = new System.Drawing.Point(33, 519);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(743, 42);
            this.AddBttn.TabIndex = 9;
            this.AddBttn.Text = "Add To Set";
            this.AddBttn.UseVisualStyleBackColor = true;
            // 
            // DeleteBttn
            // 
            this.DeleteBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteBttn.Location = new System.Drawing.Point(834, 519);
            this.DeleteBttn.Name = "DeleteBttn";
            this.DeleteBttn.Size = new System.Drawing.Size(346, 42);
            this.DeleteBttn.TabIndex = 10;
            this.DeleteBttn.Text = "Delete Selected Cards";
            this.DeleteBttn.UseVisualStyleBackColor = true;
            // 
            // SetNameLabel
            // 
            this.SetNameLabel.AutoSize = true;
            this.SetNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.SetNameLabel.Location = new System.Drawing.Point(27, 15);
            this.SetNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SetNameLabel.Name = "SetNameLabel";
            this.SetNameLabel.Size = new System.Drawing.Size(151, 31);
            this.SetNameLabel.TabIndex = 3;
            this.SetNameLabel.Text = "Set Name:";
            // 
            // SaveSetBttn
            // 
            this.SaveSetBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaveSetBttn.Location = new System.Drawing.Point(834, 608);
            this.SaveSetBttn.Name = "SaveSetBttn";
            this.SaveSetBttn.Size = new System.Drawing.Size(346, 62);
            this.SaveSetBttn.TabIndex = 11;
            this.SaveSetBttn.Text = "Save Flashcard Set";
            this.SaveSetBttn.UseVisualStyleBackColor = true;
            // 
            // CreateSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.SaveSetBttn);
            this.Controls.Add(this.DeleteBttn);
            this.Controls.Add(this.AddBttn);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.SetList);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.FlashLabel);
            this.Controls.Add(this.SetNameLabel);
            this.Controls.Add(this.textBox2);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CreateSet";
            this.Size = new System.Drawing.Size(1200, 744);
            this.Load += new System.EventHandler(this.CreateSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label FlashLabel;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.ListBox SetList;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button AddBttn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button DeleteBttn;
        private System.Windows.Forms.Label SetNameLabel;
        private System.Windows.Forms.Button SaveSetBttn;
    }
}
