using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard
{
    public class Flashcard
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public Flashcard(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }

        internal class ReviewSet : global::Flashcard.ReviewSet
        {
        }

        internal class CreateSet : global::Flashcard.CreateSet
        {
        }
    }
}
