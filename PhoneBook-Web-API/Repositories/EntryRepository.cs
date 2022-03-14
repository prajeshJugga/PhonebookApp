using Phonebook.Models;
using PhoneBook_Web_API.Context;
using System.Linq;

namespace PhoneBook_Web_API.Repositories
{
    public class EntryRepository : IEntryRepository
    {
        private readonly PhoneBookContext _context;
        private readonly IPhoneBookRepository _phonebookRepository;
        public EntryRepository(PhoneBookContext context, IPhoneBookRepository phonebookRepository)
        {
            _context = context;
            _phonebookRepository = phonebookRepository;
        }

        public Entry CreateEntry(Entry entry, string phoneBookName)
        {
            PhoneBook phoneBook = _phonebookRepository.GetPhoneBookByName(phoneBookName);
            phoneBook.Entries.Add(entry);
            _context.SaveChanges();
            return entry;
        }

        public int DeleteEntry(Entry entry)
        {
            _context.Entry.Remove(entry);
            return _context.SaveChanges();
        }

        public int UpdateEntry(Entry entry)
        {
            Entry existingEntry = _context.Entry.Where(en => en.Id == entry.Id).SingleOrDefault();
            existingEntry.Name = entry.Name;
            existingEntry.Number = entry.Number;
            return _context.SaveChanges();
        }
    }
}
