using System.ComponentModel.DataAnnotations;

namespace Phonebook.Models
{
    public class Entry
    {
        public string Name { get; set; }
        public string Number { get; set; }
        [Display(Name = "Phone Book Name")]
        public string PhoneBookName { get; set; }
    }
}
