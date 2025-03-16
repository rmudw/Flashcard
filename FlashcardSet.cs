using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Flashcard
{
    public abstract class FlashcardSet // class is an abstract type
    {
        private List<Card> _flashcards = new List<Card>();

        public void AddFlashcard(Card flashcard)
        {
            if (flashcard == null) throw new ArgumentNullException(nameof(flashcard));
            _flashcards.Add(flashcard);
        }

        public void AddFlashcard(string question, string answer)
        {
            AddFlashcard(new Card(question, answer));
        }

        public void AddFlashcard(string question, string answer, string note)
        {
            AddFlashcard(new Card(question, answer, note));
        }

        public void RemoveFlashcard(int index)
        {
            if (index >= 0 && index < _flashcards.Count)
            {
                _flashcards.RemoveAt(index);
            }
        }

        public static void DeleteSet(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    MessageBox.Show("Flashcard set deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The selected flashcard set does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public IReadOnlyList<Card> GetFlashcards() => _flashcards.AsReadOnly();

        public abstract void SaveSet(string filePath);
    }

    public class JsonFlashcardSet : FlashcardSet  // JsonFlashcardSet inherits from FlashcardSet
    {
        public override void SaveSet(string filePath)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
                };

                var flashcards = GetFlashcards().Select(card => new
                {
                    card.Question,
                    card.Answer,
                    Note = string.IsNullOrWhiteSpace(card.Note) ? null : card.Note 
                });

                string jsonData = JsonSerializer.Serialize(GetFlashcards(), new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonData);
                MessageBox.Show("Flashcard set saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving flashcard set: {ex.Message}");
            }
        }

        public static JsonFlashcardSet LoadSet(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException("The specified file does not exist.");

            string jsonData = File.ReadAllText(filePath);
            var flashcards = JsonSerializer.Deserialize<List<Card>>(jsonData);

            var loadedSet = new JsonFlashcardSet();
            foreach (var card in flashcards)
            {
                if (!string.IsNullOrWhiteSpace(card.Note))
                {
                    loadedSet.AddFlashcard(card.Question, card.Answer, card.Note);
                }
                else
                {
                    loadedSet.AddFlashcard(card.Question, card.Answer);
                }
            }
            return loadedSet;
        }


    }
}
