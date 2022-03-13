using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Phonebook.DTOs
{
    public class PhoneBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Entry> Entries { get; set; }
    }
}
