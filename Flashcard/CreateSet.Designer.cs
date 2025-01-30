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
            this.SetNameTxt = new System.Windows.Forms.TextBox();
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
            // SetNameTxt
            // 
            this.SetNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.SetNameTxt.Location = new System.Drawing.Point(202, 20);
            this.SetNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetNameTxt.Name = "SetNameTxt";
            this.SetNameTxt.Size = new System.Drawing.Size(907, 41);
            this.SetNameTxt.TabIndex = 2;
            // 
            // FlashLabel
            // 
            this.FlashLabel.AutoSize = true;
            this.FlashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FlashLabel.Location = new System.Drawing.Point(703, 96);
            this.FlashLabel.Name = "FlashLabel";
            this.FlashLabel.Size = new System.Drawing.Size(156, 31);
            this.FlashLabel.TabIndex = 3;
            this.FlashLabel.Text = "Flashcards:";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.QuestionLabel.Location = new System.Drawing.Point(22, 96);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(131, 31);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Question:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textBox1.Location = new System.Drawing.Point(26, 139);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(636, 35);
            this.textBox1.TabIndex = 5;
            // 
            // AnswerText
            // 
            this.AnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AnswerText.Location = new System.Drawing.Point(28, 242);
            this.AnswerText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerText.Multiline = true;
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(634, 226);
            this.AnswerText.TabIndex = 6;
            // 
            // SetList
            // 
            this.SetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.SetList.FormattingEnabled = true;
            this.SetList.ItemHeight = 25;
            this.SetList.Location = new System.Drawing.Point(709, 139);
            this.SetList.Margin = new System.Windows.Forms.Padding(2);
            this.SetList.Name = "SetList";
            this.SetList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.SetList.Size = new System.Drawing.Size(400, 329);
            this.SetList.TabIndex = 7;
            this.SetList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AnswerLabel.Location = new System.Drawing.Point(22, 206);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(113, 31);
            this.AnswerLabel.TabIndex = 8;
            this.AnswerLabel.Text = "Answer:";
            // 
            // AddBttn
            // 
            this.AddBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AddBttn.Location = new System.Drawing.Point(26, 496);
            this.AddBttn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(636, 49);
            this.AddBttn.TabIndex = 9;
            this.AddBttn.Text = "Add To Set";
            this.AddBttn.UseVisualStyleBackColor = true;
            this.AddBttn.Click += new System.EventHandler(this.AddBttn_Click);
            // 
            // DeleteBttn
            // 
            this.DeleteBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DeleteBttn.Location = new System.Drawing.Point(709, 496);
            this.DeleteBttn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBttn.Name = "DeleteBttn";
            this.DeleteBttn.Size = new System.Drawing.Size(400, 49);
            this.DeleteBttn.TabIndex = 10;
            this.DeleteBttn.Text = "Delete Selected Cards";
            this.DeleteBttn.UseVisualStyleBackColor = true;
            this.DeleteBttn.Click += new System.EventHandler(this.DeleteBttn_Click);
            // 
            // SetNameLabel
            // 
            this.SetNameLabel.AutoSize = true;
            this.SetNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.SetNameLabel.Location = new System.Drawing.Point(19, 21);
            this.SetNameLabel.Name = "SetNameLabel";
            this.SetNameLabel.Size = new System.Drawing.Size(177, 37);
            this.SetNameLabel.TabIndex = 3;
            this.SetNameLabel.Text = "Set Name:";
            // 
            // SaveSetBttn
            // 
            this.SaveSetBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.SaveSetBttn.Location = new System.Drawing.Point(797, 615);
            this.SaveSetBttn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveSetBttn.Name = "SaveSetBttn";
            this.SaveSetBttn.Size = new System.Drawing.Size(312, 69);
            this.SaveSetBttn.TabIndex = 11;
            this.SaveSetBttn.Text = "Save Flashcard Set";
            this.SaveSetBttn.UseVisualStyleBackColor = true;
            this.SaveSetBttn.Click += new System.EventHandler(this.SaveSetBttn_Click);
            // 
            // CreateSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
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
            this.Controls.Add(this.SetNameTxt);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateSet";
            this.Size = new System.Drawing.Size(1150, 726);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox SetNameTxt;
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
