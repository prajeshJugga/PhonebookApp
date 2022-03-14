using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Phonebook.DTOs
{
    public class PhoneBook
    {
        public PhoneBook()
        {
            Entries = new List<Entry>();
        }

        public PhoneBook(Models.PhoneBook phoneBook)
        {
            Id = phoneBook.Id;
            Name = phoneBook.Name;
            if (phoneBook.Entries != null)
            {
                Entries = Entries = phoneBook.Entries.Select(i => new Entry(i)).ToList();
            }
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Entry> Entries { get; set; }
    }
}
