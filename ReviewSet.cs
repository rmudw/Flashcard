using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Flashcard
{
    public partial class ReviewSet : UserControl
    {
         private JsonFlashcardSet flashcardSet;
         private List<Card> flashcards;
         private int currentIndex = 0;
         private string setsDirectory = Path.Combine(Application.StartupPath, "FlashcardSets");

        public ReviewSet()
        {
            CardQuestText?.Clear();
            InitializeComponent();
            LoadAvailableSets();
            ShowAnsBttn.Enabled = false;
            PrevBttn.Enabled = false;
            NextBttn.Enabled = false;
        }

         public void LoadAvailableSets()
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
                 flashcards = new List<Card>(flashcardSet.GetFlashcards());

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

        private void deleteSetBttn_Click( object sender, EventArgs e )
        {
            if (SetList.SelectedItem == null)
            {
                MessageBox.Show("Please select a flashcard set to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedSetName = SetList.SelectedItem.ToString();
            string filePath = Path.Combine(Application.StartupPath, "FlashcardSets", selectedSetName + ".json");

            DialogResult confirmResult = MessageBox.Show(
                $"Are you sure you want to delete '{selectedSetName}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                flashcards?.Clear();
                flashcardSet = null;
                currentIndex = 0;
                FlashcardSet.DeleteSet(filePath);
                SetList.Items.Remove(selectedSetName); 
                ClearTextBox();
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
            CardQuestText.SelectionAlignment = HorizontalAlignment.Center;
            ShowAnsBttn.Image = Image.FromFile(@"C:\Users\RM\source\repos\Flashcard\showAnsBttn.png");
            ShowAnsBttn.Tag = "showAns";
;
            PrevBttn.Enabled = currentIndex > 0;
            NextBttn.Enabled = currentIndex < flashcards.Count - 1;
          }

        private void showAns_Click(object sender, EventArgs e)
        {
            if (flashcards == null || flashcards.Count == 0)
                return;

            if (ShowAnsBttn.Tag.ToString() == "showAns")
            {
                string answerText = flashcards[currentIndex].Question + Environment.NewLine + Environment.NewLine + "Answer:" + Environment.NewLine + flashcards[currentIndex].Answer;

                if (!string.IsNullOrWhiteSpace(flashcards[currentIndex].Note))
                {
                    answerText += Environment.NewLine + Environment.NewLine + "Note:" + Environment.NewLine + flashcards[currentIndex].Note;
                }

                CardQuestText.SelectionAlignment = HorizontalAlignment.Center;
                CardQuestText.Text = answerText;    
                ShowAnsBttn.Image = Image.FromFile(@"C:\Users\RM\source\repos\Flashcard\hideAnsBttn.png");
                ShowAnsBttn.Tag = "hideAns";
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

        public void ClearTextBox()
        {
            CardQuestText.Clear();
        }
    }
}
