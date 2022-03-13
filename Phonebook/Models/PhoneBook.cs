using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Phonebook.Models
{
    public class PhoneBook
    {
        [Display(Name = "Phone Book Name")]
        public string Name { get; set; }
        public List<Entry> Entries { get; set; }
    }
}
