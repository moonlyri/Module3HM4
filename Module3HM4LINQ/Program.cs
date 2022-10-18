using System;
using System.Linq;

namespace Module3HM4LINQ
{
    public class Program
    {
        public List<string> contacts;
        public string Name { get; set; }

        public void Linq()
        {
            contacts.Add(Name = "John");
            contacts.Add(Name = "Ivan");
            contacts.Add(Name = "Jake");
            contacts.Sort((x, y) => string.Compare(Name.StartsWith('A').ToString(), Name.StartsWith('Z').ToString()));
            var orderBy = contacts.Where(name => name.ToUpper().StartsWith('J')).OrderBy(x => Name);
            var selected = contacts.Where(c => Name == "contactname")
                .Select(c => new Program() { contacts = new List<string> { Name } }).ToList();
            var firstofdefault = contacts.FirstOrDefault();
            var skip = contacts.Skip(1);
            var take = contacts.Take(3);
        }
    }
}