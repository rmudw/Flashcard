using System;
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
            DeleteBttn.Enabled = SetList.SelectedIndex != -1;
        }

        private void DeleteBttn_Click(object sender, EventArgs e)
        {
            if (SetList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a flashcard to delete.");
                return;
            }

            int selectedIndex = SetList.SelectedIndex;
            flashcardSet.RemoveFlashcard(selectedIndex);
            SetList.Items.RemoveAt(selectedIndex);
            AutoSaveSet();

            DeleteBttn.Enabled = SetList.Items.Count > 0;
        }

        private void AddBttn_Click(object sender, EventArgs e)
        {
            string question = textBox1.Text.Trim();
            string answer = AnswerText.Text.Trim();

            if (string.IsNullOrEmpty(question) || string.IsNullOrEmpty(answer))
            {
                MessageBox.Show("Both question and answer fields must be filled.");
                return;
            }

            flashcardSet.AddFlashcard(new Flashcard(question, answer));
            SetList.Items.Add(question);
            AutoSaveSet();

            textBox1.Clear();
            AnswerText.Clear();
            DeleteBttn.Enabled = SetList.Items.Count > 0;
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
            SetList.Items.Clear();
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
    }
}
