using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashcard
{
    public partial class ReviewSet : UserControl
    {
        private JsonFlashcardSet flashcardSet;
        private List<Flashcard> flashcards;
        private int currentIndex = 0;
        private string setsDirectory = Path.Combine(Application.StartupPath, "FlashcardSets");

        public ReviewSet()
        {
            InitializeComponent();
            LoadAvailableSets();
            ShowAnsBttn.Enabled = false;
            PrevBttn.Enabled = false;
            NextBttn.Enabled = false;
        }

        private void LoadAvailableSets()
        {
            Directory.CreateDirectory(setsDirectory);
            SetList.Items.Clear();

            foreach (string file in Directory.GetFiles(setsDirectory, "*.json"))
            {
                SetList.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void loadSetBttn_Click(object sender, EventArgs e)
        {
            if (SetList.SelectedItem == null)
            {
                MessageBox.Show("Please select a set to review.");
                return;
            }

            string selectedSetName = SetList.SelectedItem.ToString();
            string filePath = Path.Combine(setsDirectory, selectedSetName + ".json");

            try
            {
                flashcardSet = JsonFlashcardSet.LoadSet(filePath);
                flashcards = new List<Flashcard>(flashcardSet.GetFlashcards());

                if (flashcards.Count > 0)
                {
                    currentIndex = 0;
                    DisplayCurrentFlashcard();
                    ShowAnsBttn.Enabled = true;
                    NextBttn.Enabled = flashcards.Count > 1;
                }

                MessageBox.Show($"Flashcard set '{selectedSetName}' loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading set: {ex.Message}");
            }
        }

        private void DisplayCurrentFlashcard()
        {
            if (flashcards == null || flashcards.Count == 0)
            {
                CardQuestText.Text = "No flashcards available.";
                ShowAnsBttn.Enabled = false;
                PrevBttn.Enabled = false;
                NextBttn.Enabled = false;
                return;
            }

            CardQuestText.Text = flashcards[currentIndex].Question;
            ShowAnsBttn.Text = "Show Answer";

            PrevBttn.Enabled = currentIndex > 0;
            NextBttn.Enabled = currentIndex < flashcards.Count - 1;
        }

        private void showAns_Click(object sender, EventArgs e)
        {
            if (flashcards == null || flashcards.Count == 0)
                return;

            if (ShowAnsBttn.Text == "Show Answer")
            {
                CardQuestText.Text = flashcards[currentIndex].Answer;
                ShowAnsBttn.Text = "Hide Answer";
            }
            else
            {
                DisplayCurrentFlashcard();
            }
        }

        private void NextBttn_Click(object sender, EventArgs e)
        {
            if (flashcards != null && currentIndex < flashcards.Count - 1)
            {
                currentIndex++;
                DisplayCurrentFlashcard();
            }
        }

        private void PrevBttn_Click(object sender, EventArgs e)
        {
            if (flashcards != null && currentIndex > 0)
            {
                currentIndex--;
                DisplayCurrentFlashcard();
            }
        }

    }
}
