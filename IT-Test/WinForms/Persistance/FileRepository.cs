using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WinForms.Business_Logic;
using WinForms.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace WinForms.Persistance
{
    internal class FileRepository :IRepository<Question>
    {
        private const string FileName = "Questions";
        public void Add(Question item)
        {
            
            var list = new List<Question>(GetAll());
            list.Add(item);

            var str = JsonSerializer.Serialize(list);

            File.WriteAllText(FileName, str);

            Console.WriteLine("file.Add");
        }

        public IEnumerable<Question> GetAll()
        {
            if (!File.Exists(FileName))
                return Enumerable.Empty<Question>();
            
            var str = File.ReadAllText(FileName);

            var res = JsonSerializer.Deserialize<List<Question>>(str);


            Console.WriteLine("file.GetAll");

            return res;


            return Enumerable.Empty<Question>();
        }

        public void Remove(Question item)
        {
            Console.WriteLine("file.Remove");
        }
    }
}
