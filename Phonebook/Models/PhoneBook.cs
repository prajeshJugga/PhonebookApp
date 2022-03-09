using System.Collections.Generic;

namespace Phonebook.Models
{
    public class PhoneBook
    {
        public string Name { get; set; }
        public List<Entry> Entries { get; set; }
    }
}
