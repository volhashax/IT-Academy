using System;
using System.Collections.Generic;
using System.Text;
using WinForms.Business_Logic;
using WinForms.Core;

namespace WinForms.Persistance
{
    internal class NullRepository : IRepository<Question>
    {
        public void Add(Question item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Question> GetAll()
        {
            return new []
            {
                new Question("Are you tired?",
                new [] {
                    new Answer("Yes", true),
                    new Answer("No"),
                    new Answer("Not sure", true)
                }
                ),
                new Question("Do you love c#?",
                new [] {
                    new Answer("Yes", true),
                    new Answer("No"),
                    new Answer("Not sure", true)
                }
                ),
                new Question("How  do you do?",
                new [] {
                    new Answer("Yes", true),
                    new Answer("No"),
                    new Answer("Not sure", true)
                }
                )
            };

        }

        public void Remove(Question item)
        {
            throw new NotImplementedException();
        }
    }
}
