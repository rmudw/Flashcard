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
            this.button2 = new System.Windows.Forms.Button();
            this.BackBttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.createSet1 = new Flashcard.CreateSet();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateBttn
            // 
            this.CreateBttn.AutoSize = true;
            this.CreateBttn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.CreateBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateBttn.ForeColor = System.Drawing.Color.White;
            this.CreateBttn.Location = new System.Drawing.Point(773, 264);
            this.CreateBttn.Name = "CreateBttn";
            this.CreateBttn.Size = new System.Drawing.Size(366, 101);
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
            this.ReviewBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ReviewBttn.ForeColor = System.Drawing.Color.White;
            this.ReviewBttn.Location = new System.Drawing.Point(773, 431);
            this.ReviewBttn.Name = "ReviewBttn";
            this.ReviewBttn.Size = new System.Drawing.Size(366, 101);
            this.ReviewBttn.TabIndex = 2;
            this.ReviewBttn.Text = "Review Flashcard Set";
            this.ReviewBttn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(773, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(366, 101);
            this.button2.TabIndex = 3;
            this.button2.Text = "Quit App";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BackBttn
            // 
            this.BackBttn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBttn.ForeColor = System.Drawing.Color.White;
            this.BackBttn.Location = new System.Drawing.Point(61, 37);
            this.BackBttn.Name = "BackBttn";
            this.BackBttn.Size = new System.Drawing.Size(140, 57);
            this.BackBttn.TabIndex = 4;
            this.BackBttn.Text = "Back";
            this.BackBttn.UseVisualStyleBackColor = false;
            this.BackBttn.Click += new System.EventHandler(this.back_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.BackBttn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ReviewBttn);
            this.panel1.Controls.Add(this.CreateBttn);
            this.panel1.Controls.Add(this.createSet1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1842, 894);
            this.panel1.TabIndex = 1;
            // 
            // createSet1
            // 
            this.createSet1.AutoScroll = true;
            this.createSet1.AutoSize = true;
            this.createSet1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.createSet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.createSet1.Location = new System.Drawing.Point(473, 121);
            this.createSet1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.createSet1.Name = "createSet1";
            this.createSet1.Size = new System.Drawing.Size(948, 538);
            this.createSet1.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1842, 894);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flashcard";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BackBttn;
        private System.Windows.Forms.Panel panel1;
    }
}

