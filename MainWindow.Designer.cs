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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CreateBttn = new System.Windows.Forms.Button();
            this.ReviewBttn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackBttn = new System.Windows.Forms.Button();
            this.createSet1 = new Flashcard.CreateSet();
            this.reviewSet1 = new Flashcard.ReviewSet();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateBttn
            // 
            this.CreateBttn.AutoSize = true;
            this.CreateBttn.BackColor = System.Drawing.Color.Transparent;
            this.CreateBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CreateBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBttn.FlatAppearance.BorderSize = 0;
            this.CreateBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CreateBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CreateBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.CreateBttn.ForeColor = System.Drawing.Color.Transparent;
            this.CreateBttn.Image = ((System.Drawing.Image)(resources.GetObject("CreateBttn.Image")));
            this.CreateBttn.Location = new System.Drawing.Point(716, 500);
            this.CreateBttn.Name = "CreateBttn";
            this.CreateBttn.Size = new System.Drawing.Size(487, 122);
            this.CreateBttn.TabIndex = 0;
            this.CreateBttn.UseVisualStyleBackColor = false;
            this.CreateBttn.Click += new System.EventHandler(this.create_Click);
            // 
            // ReviewBttn
            // 
            this.ReviewBttn.AutoSize = true;
            this.ReviewBttn.BackColor = System.Drawing.Color.Transparent;
            this.ReviewBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReviewBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReviewBttn.FlatAppearance.BorderSize = 0;
            this.ReviewBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReviewBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReviewBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ReviewBttn.ForeColor = System.Drawing.Color.Transparent;
            this.ReviewBttn.Image = ((System.Drawing.Image)(resources.GetObject("ReviewBttn.Image")));
            this.ReviewBttn.Location = new System.Drawing.Point(715, 639);
            this.ReviewBttn.Name = "ReviewBttn";
            this.ReviewBttn.Size = new System.Drawing.Size(489, 124);
            this.ReviewBttn.TabIndex = 0;
            this.ReviewBttn.UseVisualStyleBackColor = false;
            this.ReviewBttn.Click += new System.EventHandler(this.review_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BackBttn);
            this.panel1.Controls.Add(this.ReviewBttn);
            this.panel1.Controls.Add(this.CreateBttn);
            this.panel1.Controls.Add(this.createSet1);
            this.panel1.Controls.Add(this.reviewSet1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 862);
            this.panel1.TabIndex = 1;
            // 
            // BackBttn
            // 
            this.BackBttn.BackColor = System.Drawing.Color.Transparent;
            this.BackBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBttn.FlatAppearance.BorderSize = 0;
            this.BackBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BackBttn.ForeColor = System.Drawing.Color.Transparent;
            this.BackBttn.Image = ((System.Drawing.Image)(resources.GetObject("BackBttn.Image")));
            this.BackBttn.Location = new System.Drawing.Point(11, 12);
            this.BackBttn.Name = "BackBttn";
            this.BackBttn.Size = new System.Drawing.Size(176, 150);
            this.BackBttn.TabIndex = 4;
            this.BackBttn.UseVisualStyleBackColor = false;
            this.BackBttn.Click += new System.EventHandler(this.back_Click);
            // 
            // createSet1
            // 
            this.createSet1.AutoScroll = true;
            this.createSet1.AutoSize = true;
            this.createSet1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createSet1.BackgroundImage")));
            this.createSet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createSet1.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.createSet1.Location = new System.Drawing.Point(0, 0);
            this.createSet1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createSet1.Name = "createSet1";
            this.createSet1.Size = new System.Drawing.Size(1443, 862);
            this.createSet1.TabIndex = 8;
            // 
            // reviewSet1
            // 
            this.reviewSet1.AutoScroll = true;
            this.reviewSet1.AutoSize = true;
            this.reviewSet1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reviewSet1.BackgroundImage")));
            this.reviewSet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewSet1.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.reviewSet1.Location = new System.Drawing.Point(0, 0);
            this.reviewSet1.Name = "reviewSet1";
            this.reviewSet1.Size = new System.Drawing.Size(1443, 862);
            this.reviewSet1.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1443, 862);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button CreateBttn;
        private System.Windows.Forms.Button ReviewBttn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackBttn;
        private CreateSet createSet1;
        private ReviewSet reviewSet1;
    }
}

