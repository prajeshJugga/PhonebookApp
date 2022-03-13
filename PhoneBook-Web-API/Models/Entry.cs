using System.ComponentModel.DataAnnotations;

namespace Phonebook.Models
{
    public class Entry
    {
        public Entry()
        {

        }

        public Entry(DTOs.Entry entry)
        {
            Id = entry.Id;
            Name = entry.Name;
            Number = entry.Number;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Number { get; set; }
        public PhoneBook PhoneBook { get; set; }
    }
}
