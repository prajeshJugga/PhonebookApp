using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Phonebook.Models
{
    public class PhoneBook
    {
        public PhoneBook()
        {
            Entries = new List<Entry>();
        }

        [Display(Name = "Phone Book Name")]
        [Required]
        //[StringLength(150, MinimumLength = 3, ErrorMessage = "Last name should be between 3 and 150 characters")]
        public string Name { get; set; }
        public List<Entry> Entries { get; set; }
    }
}
