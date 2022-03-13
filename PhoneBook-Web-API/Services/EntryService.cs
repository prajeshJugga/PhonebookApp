using Phonebook.DTOs;
using PhoneBook_Web_API.Context;
using PhoneBook_Web_API.Services.Interfaces;

namespace PhoneBook_Web_API.Services
{
    public class EntryService : IEntryService
    {
        private readonly PhoneBookContext _context;
        public EntryService(PhoneBookContext context)
        {
            _context = context;
        }

        public Entry CreateEntry(Entry entry)
        {
            throw new System.NotImplementedException();
        }

        public int DeleteEntry(Entry entry)
        {
            throw new System.NotImplementedException();
        }

        public int UpdateEntry(Entry entry)
        {
            throw new System.NotImplementedException();
        }
    }
}
