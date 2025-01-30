namespace Flashcard
{
    partial class MainWindow
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CreateBttn = new System.Windows.Forms.Button();
            this.ReviewBttn = new System.Windows.Forms.Button();
            this.QuitBttn = new System.Windows.Forms.Button();
            this.BackBttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reviewSet1 = new Flashcard.ReviewSet();
            this.createSet1 = new Flashcard.CreateSet();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateBttn
            // 
            this.CreateBttn.AutoSize = true;
            this.CreateBttn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CreateBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CreateBttn.ForeColor = System.Drawing.Color.White;
            this.CreateBttn.Location = new System.Drawing.Point(1031, 325);
            this.CreateBttn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateBttn.Name = "CreateBttn";
            this.CreateBttn.Size = new System.Drawing.Size(488, 124);
            this.CreateBttn.TabIndex = 0;
            this.CreateBttn.Text = "Create Flashcard Set";
            this.CreateBttn.UseVisualStyleBackColor = false;
            this.CreateBttn.Click += new System.EventHandler(this.create_Click);
            // 
            // ReviewBttn
            // 
            this.ReviewBttn.AutoSize = true;
            this.ReviewBttn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ReviewBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReviewBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ReviewBttn.ForeColor = System.Drawing.Color.White;
            this.ReviewBttn.Location = new System.Drawing.Point(1031, 530);
            this.ReviewBttn.Margin = new System.Windows.Forms.Padding(4);
            this.ReviewBttn.Name = "ReviewBttn";
            this.ReviewBttn.Size = new System.Drawing.Size(488, 124);
            this.ReviewBttn.TabIndex = 2;
            this.ReviewBttn.Text = "Review Flashcard Set";
            this.ReviewBttn.UseVisualStyleBackColor = false;
            this.ReviewBttn.Click += new System.EventHandler(this.review_Click);
            // 
            // QuitBttn
            // 
            this.QuitBttn.AutoSize = true;
            this.QuitBttn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.QuitBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QuitBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.QuitBttn.ForeColor = System.Drawing.Color.White;
            this.QuitBttn.Location = new System.Drawing.Point(1031, 736);
            this.QuitBttn.Margin = new System.Windows.Forms.Padding(4);
            this.QuitBttn.Name = "QuitBttn";
            this.QuitBttn.Size = new System.Drawing.Size(488, 124);
            this.QuitBttn.TabIndex = 3;
            this.QuitBttn.Text = "Quit App";
            this.QuitBttn.UseVisualStyleBackColor = false;
            this.QuitBttn.Click += new System.EventHandler(this.quit_Click);
            // 
            // BackBttn
            // 
            this.BackBttn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BackBttn.ForeColor = System.Drawing.Color.White;
            this.BackBttn.Location = new System.Drawing.Point(191, 73);
            this.BackBttn.Margin = new System.Windows.Forms.Padding(4);
            this.BackBttn.Name = "BackBttn";
            this.BackBttn.Size = new System.Drawing.Size(187, 70);
            this.BackBttn.TabIndex = 4;
            this.BackBttn.Text = "Back";
            this.BackBttn.UseVisualStyleBackColor = false;
            this.BackBttn.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.QuitBttn);
            this.panel1.Controls.Add(this.ReviewBttn);
            this.panel1.Controls.Add(this.CreateBttn);
            this.panel1.Controls.Add(this.reviewSet1);
            this.panel1.Controls.Add(this.BackBttn);
            this.panel1.Controls.Add(this.createSet1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 1061);
            this.panel1.TabIndex = 1;
            // 
            // reviewSet1
            // 
            this.reviewSet1.AutoScroll = true;
            this.reviewSet1.AutoSize = true;
            this.reviewSet1.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.reviewSet1.Location = new System.Drawing.Point(518, 204);
            this.reviewSet1.Name = "reviewSet1";
            this.reviewSet1.Size = new System.Drawing.Size(1153, 686);
            this.reviewSet1.TabIndex = 5;
            // 
            // createSet1
            // 
            this.createSet1.AutoScroll = true;
            this.createSet1.AutoSize = true;
            this.createSet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.createSet1.Location = new System.Drawing.Point(534, 188);
            this.createSet1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.createSet1.Name = "createSet1";
            this.createSet1.Size = new System.Drawing.Size(1137, 795);
            this.createSet1.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAMA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CreateSet createSet1;
        private System.Windows.Forms.Button CreateBttn;
        private System.Windows.Forms.Button ReviewBttn;
        private System.Windows.Forms.Button QuitBttn;
        private System.Windows.Forms.Button BackBttn;
        private System.Windows.Forms.Panel panel1;
        private ReviewSet reviewSet1;
    }
}

