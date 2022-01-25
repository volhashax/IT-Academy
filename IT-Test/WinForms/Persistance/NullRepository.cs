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
                    new Answer("3", true)
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
