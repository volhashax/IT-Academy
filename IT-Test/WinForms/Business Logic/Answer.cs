using System;
using System.Collections.Generic;
using System.Text;

namespace WinForms.Business_Logic
{
    internal class Answer
    {
        public string Text { get;  }
        public bool IsCorrect { get;  }

        public Answer(string text, bool isCorrect = false)
        {
            Text = text;
            IsCorrect = isCorrect;
        }
    }
}
