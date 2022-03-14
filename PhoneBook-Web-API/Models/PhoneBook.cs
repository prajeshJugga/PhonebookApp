using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Phonebook.Models
{
    public class PhoneBook
    {
        public PhoneBook()
        {
            Entries = new List<Entry>();
        }

        public PhoneBook(DTOs.PhoneBook phoneBook)
        {
            Id = phoneBook.Id;
            Name = phoneBook.Name;
            if (phoneBook.Entries != null)
            {
                Entries = phoneBook.Entries.Select(i => new Entry(i)).ToList();
            }
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Entry> Entries { get; set; }
    }
}
