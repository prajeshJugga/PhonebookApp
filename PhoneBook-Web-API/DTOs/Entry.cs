namespace Phonebook.DTOs
{
    public class Entry
    {
        public Entry()
        {

        }

        public Entry(Models.Entry entry)
        {
            Id = entry.Id;
            Name = entry.Name;
            Number = entry.Number;
            PhoneBookName = entry.PhoneBook.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string PhoneBookName { get; set; }
    }
}
