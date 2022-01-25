using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinForms.Business_Logic
{
    internal class Question
    {
        public string Text { get; }
        public IEnumerable<Answer> Answers { get; }

        public Question(string text, ICollection<Answer> answers)
        {
            Text = text;

            if (answers == null || answers.Count < 2 || answers.All (x => !x.IsCorrect))
            {
                throw new ArgumentException("There should be at least two answers and one correct");
            }
            Answers = answers;
        }
    }
}
