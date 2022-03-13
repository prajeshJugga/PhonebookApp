namespace Phonebook.DTOs
{
    public class Entry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public PhoneBook PhoneBook { get; set; }
    }
}
