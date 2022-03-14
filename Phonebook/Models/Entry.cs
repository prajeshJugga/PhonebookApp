using System.ComponentModel.DataAnnotations;

namespace Phonebook.Models
{
    public class Entry
    {
        [Required]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Last name should be between 3 and 150 characters")]
        public string Name { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Number should be 10 characters and only numbers")]
        public string Number { get; set; }
        [Display(Name = "Phone Book Name")]
        public string PhoneBookName { get; set; }
    }
}
