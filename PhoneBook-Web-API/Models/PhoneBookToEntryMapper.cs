using System.ComponentModel.DataAnnotations;

namespace PhoneBook_Web_API.Models
{
    public class PhoneBookToEntryMapper
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int EntryId { get; set; }
        [Required]
        public int PhoneBookId { get; set; }
    }
}
