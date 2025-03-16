using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Flashcard
{
    public partial class CreateSet : UserControl
    {
            private JsonFlashcardSet flashcardSet = new JsonFlashcardSet();
            private string setsDirectory = Path.Combine(Application.StartupPath, "FlashcardSets");
            private string currentSetFilePath;

        public CreateSet()
        {
            InitializeComponent();
            DeleteBttn.Enabled = false;
            Directory.CreateDirectory(setsDirectory);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteBttn.Enabled = CardsList.SelectedIndex != -1;
        }

        private void DeleteBttn_Click(object sender, EventArgs e)
        {
            if (CardsList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flashcard to delete.");
                return;
            }

            int selectedIndex = CardsList.SelectedIndex;
            flashcardSet.RemoveFlashcard(selectedIndex);
            CardsList.Items.RemoveAt(selectedIndex);
            AutoSaveSet();

            DeleteBttn.Enabled = CardsList.Items.Count > 0;
        }

        private void AddBttn_Click(object sender, EventArgs e)
        {
            string question = QuesTxt.Text.Trim();
            string answer = AnswerText.Text.Trim();
            string note = NoteTxt.Text.Trim();

            if (string.IsNullOrEmpty(question) || string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Both question and answer fields must be filled.");
                return;
            }


            if (EnableNoteCheckBox.Checked)
            {
                flashcardSet.AddFlashcard(question, answer, note); // includes note
                NoteTxt.Clear();
                NoteTxt.Enabled = false;
                EnableNoteCheckBox.Checked = false;
            }
            else
            {
                flashcardSet.AddFlashcard(question, answer); // doesn't include note
            }
            //flashcardSet.AddFlashcard(new Card(question, answer));
            CardsList.Items.Add(question);
            //AutoSaveSet();

            QuesTxt.Clear();
            AnswerText.Clear();
            DeleteBttn.Enabled = CardsList.Items.Count > 0;
        }

        private void SaveSetBttn_Click(object sender, EventArgs e)
        {
            string setName = SetNameTxt.Text.Trim();
            if (string.IsNullOrEmpty(setName))
            {
                MessageBox.Show("Please enter a set name.");
                return;
            }

            currentSetFilePath = Path.Combine(setsDirectory, setName + ".json");
            AutoSaveSet();

            SetNameTxt.Clear();
            CardsList.Items.Clear();
            QuesTxt.Clear();
            AnswerText.Clear();
            flashcardSet = new JsonFlashcardSet();
        }

        private void AutoSaveSet()
        {
             if (string.IsNullOrEmpty(currentSetFilePath))
                  return;

              try
              {
                  flashcardSet.SaveSet(currentSetFilePath);
              }
              catch (Exception ex)
              {
                  MessageBox.Show($"Error auto-saving: {ex.Message}");
              }
        }

        private void AddNote_Checked(object sender, EventArgs e)
        {
            if (EnableNoteCheckBox.Checked)
            {
                NoteTxt.Enabled = true;
            } 
            else
            {
                NoteTxt.Enabled = false;
            }
        }

        private void NoteTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
