using System;
using System.Collections.Generic;
using System.Text;

namespace WinForms.Core
{
    internal interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        IEnumerable<T> GetAll();
    }

    
}
