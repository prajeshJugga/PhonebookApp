using Phonebook.DTOs;
using PhoneBook_Web_API.Context;
using PhoneBook_Web_API.Repositories;
using PhoneBook_Web_API.Services.Interfaces;

namespace PhoneBook_Web_API.Services
{
    public class EntryService : IEntryService
    {
        private readonly PhoneBookContext _context;
        private readonly IEntryRepository _entryRepository;
        public EntryService(PhoneBookContext context, IEntryRepository entryRepository)
        {
            _context = context;
            _entryRepository = entryRepository;
        }

        public Entry CreateEntry(Entry entry, string phoneBookName)
        {
            Phonebook.Models.Entry entry1 = _entryRepository.CreateEntry(new Phonebook.Models.Entry(entry), phoneBookName);
            entry.Id = entry1.Id;
            return entry;
        }

        public int DeleteEntry(Entry entry)
        {
            return _entryRepository.DeleteEntry(new Phonebook.Models.Entry(entry));
        }

        public int UpdateEntry(Entry entry)
        {
            return _entryRepository.UpdateEntry(new Phonebook.Models.Entry(entry));
        }
    }
}
