using System;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSet));
            this.SetNameTxt = new System.Windows.Forms.TextBox();
            this.QuesTxt = new System.Windows.Forms.TextBox();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.CardsList = new System.Windows.Forms.ListBox();
            this.AddBttn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DeleteBttn = new System.Windows.Forms.Button();
            this.SaveSetBttn = new System.Windows.Forms.Button();
            this.EnableNoteCheckBox = new System.Windows.Forms.CheckBox();
            this.NoteTxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // SetNameTxt
            // 
            this.SetNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.SetNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SetNameTxt.Font = new System.Drawing.Font("OCR A Extended", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetNameTxt.Location = new System.Drawing.Point(894, 126);
            this.SetNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SetNameTxt.Name = "SetNameTxt";
            this.SetNameTxt.Size = new System.Drawing.Size(539, 42);
            this.SetNameTxt.TabIndex = 2;
            // 
            // QuesTxt
            // 
            this.QuesTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.QuesTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuesTxt.Font = new System.Drawing.Font("OCR A Extended", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuesTxt.Location = new System.Drawing.Point(280, 298);
            this.QuesTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuesTxt.Multiline = true;
            this.QuesTxt.Name = "QuesTxt";
            this.QuesTxt.Size = new System.Drawing.Size(762, 62);
            this.QuesTxt.TabIndex = 5;
            // 
            // AnswerText
            // 
            this.AnswerText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.AnswerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnswerText.Font = new System.Drawing.Font("OCR A Extended", 29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerText.Location = new System.Drawing.Point(284, 477);
            this.AnswerText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnswerText.Multiline = true;
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(758, 113);
            this.AnswerText.TabIndex = 6;
            // 
            // CardsList
            // 
            this.CardsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.CardsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardsList.Font = new System.Drawing.Font("OCR A Extended", 23F, System.Drawing.FontStyle.Bold);
            this.CardsList.FormattingEnabled = true;
            this.CardsList.HorizontalScrollbar = true;
            this.CardsList.ItemHeight = 33;
            this.CardsList.Location = new System.Drawing.Point(1156, 298);
            this.CardsList.Margin = new System.Windows.Forms.Padding(2);
            this.CardsList.Name = "CardsList";
            this.CardsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.CardsList.Size = new System.Drawing.Size(447, 297);
            this.CardsList.TabIndex = 7;
            this.CardsList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AddBttn
            // 
            this.AddBttn.BackColor = System.Drawing.Color.Transparent;
            this.AddBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBttn.FlatAppearance.BorderSize = 0;
            this.AddBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AddBttn.ForeColor = System.Drawing.Color.Transparent;
            this.AddBttn.Image = ((System.Drawing.Image)(resources.GetObject("AddBttn.Image")));
            this.AddBttn.Location = new System.Drawing.Point(768, 722);
            this.AddBttn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(274, 85);
            this.AddBttn.TabIndex = 9;
            this.AddBttn.UseVisualStyleBackColor = true;
            this.AddBttn.Click += new System.EventHandler(this.AddBttn_Click);
            // 
            // DeleteBttn
            // 
            this.DeleteBttn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBttn.FlatAppearance.BorderSize = 0;
            this.DeleteBttn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteBttn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DeleteBttn.ForeColor = System.Drawing.Color.Transparent;
            this.DeleteBttn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteBttn.Image")));
            this.DeleteBttn.Location = new System.Drawing.Point(1188, 722);
            this.DeleteBttn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBttn.Name = "DeleteBttn";
            this.DeleteBttn.Size = new System.Drawing.Size(372, 88);
            this.DeleteBttn.TabIndex = 10;
            this.DeleteBttn.UseVisualStyleBackColor = false;
            this.DeleteBttn.Click += new System.EventHandler(this.DeleteBttn_Click);
            // 
            // SaveSetBttn
            // 
            this.SaveSetBttn.BackColor = System.Drawing.Color.Transparent;
            this.SaveSetBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveSetBttn.FlatAppearance.BorderSize = 0;
            this.SaveSetBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSetBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.SaveSetBttn.ForeColor = System.Drawing.Color.Transparent;
            this.SaveSetBttn.Image = ((System.Drawing.Image)(resources.GetObject("SaveSetBttn.Image")));
            this.SaveSetBttn.Location = new System.Drawing.Point(556, 887);
            this.SaveSetBttn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveSetBttn.Name = "SaveSetBttn";
            this.SaveSetBttn.Size = new System.Drawing.Size(774, 119);
            this.SaveSetBttn.TabIndex = 11;
            this.SaveSetBttn.UseVisualStyleBackColor = false;
            this.SaveSetBttn.Click += new System.EventHandler(this.SaveSetBttn_Click);
            // 
            // EnableNoteCheckBox
            // 
            this.EnableNoteCheckBox.AutoSize = true;
            this.EnableNoteCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.EnableNoteCheckBox.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnableNoteCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("EnableNoteCheckBox.Image")));
            this.EnableNoteCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EnableNoteCheckBox.Location = new System.Drawing.Point(427, 645);
            this.EnableNoteCheckBox.Name = "EnableNoteCheckBox";
            this.EnableNoteCheckBox.Size = new System.Drawing.Size(185, 29);
            this.EnableNoteCheckBox.TabIndex = 12;
            this.EnableNoteCheckBox.Text = "           ";
            this.EnableNoteCheckBox.UseVisualStyleBackColor = false;
            this.EnableNoteCheckBox.CheckedChanged += new System.EventHandler(this.AddNote_Checked);
            // 
            // NoteTxt
            // 
            this.NoteTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.NoteTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteTxt.Enabled = false;
            this.NoteTxt.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteTxt.Location = new System.Drawing.Point(297, 693);
            this.NoteTxt.Multiline = true;
            this.NoteTxt.Name = "NoteTxt";
            this.NoteTxt.Size = new System.Drawing.Size(405, 137);
            this.NoteTxt.TabIndex = 13;
            this.NoteTxt.TextChanged += new System.EventHandler(this.NoteTxt_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CreateSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.NoteTxt);
            this.Controls.Add(this.EnableNoteCheckBox);
            this.Controls.Add(this.SaveSetBttn);
            this.Controls.Add(this.DeleteBttn);
            this.Controls.Add(this.AddBttn);
            this.Controls.Add(this.CardsList);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.QuesTxt);
            this.Controls.Add(this.SetNameTxt);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateSet";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox SetNameTxt;
        private System.Windows.Forms.TextBox QuesTxt;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.ListBox CardsList;
        private System.Windows.Forms.Button AddBttn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button DeleteBttn;
        private System.Windows.Forms.Button SaveSetBttn;
        private System.Windows.Forms.CheckBox EnableNoteCheckBox;
        private System.Windows.Forms.TextBox NoteTxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
