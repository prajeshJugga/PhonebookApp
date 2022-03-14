using Phonebook.Models;

namespace PhoneBook_Web_API.Repositories
{
    public interface IEntryRepository
    {
        Entry CreateEntry(Entry entry, string phoneBookName);
        int UpdateEntry(Entry entry);
        int DeleteEntry(Entry entry);
    }
}
