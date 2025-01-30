using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Flashcard
{
    public abstract class FlashcardSet
    {
        private List<Flashcard> _flashcards = new List<Flashcard>();

        public void AddFlashcard(Flashcard flashcard)
        {
            if (flashcard == null) throw new ArgumentNullException(nameof(flashcard));
            _flashcards.Add(flashcard);
        }

        public void RemoveFlashcard(int index)
        {
            if (index >= 0 && index < _flashcards.Count)
            {
                _flashcards.RemoveAt(index);
            }
        }

        public IReadOnlyList<Flashcard> GetFlashcards() => _flashcards.AsReadOnly();

        public abstract void SaveSet(string filePath);
    }

    public class JsonFlashcardSet : FlashcardSet
    {
        public override void SaveSet(string filePath)
        {
            try
            {
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
            var flashcards = JsonSerializer.Deserialize<List<Flashcard>>(jsonData);

            var loadedSet = new JsonFlashcardSet();
            foreach (var card in flashcards)
            {
                loadedSet.AddFlashcard(card);
            }
            return loadedSet;
        }
    }
}
