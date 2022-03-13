using Phonebook.DTOs;

namespace PhoneBook_Web_API.Services.Interfaces
{
    public interface IEntryService
    {
        Entry CreateEntry(Entry entry);
        int UpdateEntry(Entry entry);
        int DeleteEntry(Entry entry);
    }
}
