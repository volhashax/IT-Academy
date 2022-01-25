using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinForms.Core;

namespace WinForms.Persistance
{
    internal class FileRepository<T> :IRepository<T>
    {
        public void Add(T item)
        {
            Console.WriteLine("file.Add");
        }

        public IEnumerable<T> GetAll()
        {
            Console.WriteLine("file.GetAll");
            return Enumerable.Empty<T>();
        }

        public void Remove(T item)
        {
            Console.WriteLine("file.Remove");
        }
    }
}
