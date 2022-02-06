using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace WinForms.Business_Logic
{
    internal class Question
    {
        [JsonPropertyName("Message")]
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }

        public Question()
        {

        }

        public Question(string text, ICollection<Answer> answers)
        {
            Text = text;

            if (answers == null || answers.Count < 2 || answers.All (x => !x.IsCorrect))
            {
                throw new ArgumentException("There should be at least two answers and one correct");
            }
            Answers = answers.ToList();
        }
    }
}
