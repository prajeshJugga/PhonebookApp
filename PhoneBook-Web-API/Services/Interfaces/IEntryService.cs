using Phonebook.DTOs;

namespace PhoneBook_Web_API.Services.Interfaces
{
    public interface IEntryService
    {
        Entry CreateEntry(Entry entry, string phoneBookName);
        int UpdateEntry(Entry entry);
        int DeleteEntry(Entry entry);
    }
}
