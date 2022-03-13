using Phonebook.Models;
using PhoneBook_Web_API.Context;
using System.Linq;

namespace PhoneBook_Web_API.Repositories
{
    public class EntryRepository : IEntryRepository
    {
        private readonly PhoneBookContext _context;
        public EntryRepository(PhoneBookContext context)
        {
            _context = context;
        }

        public Entry CreateEntry(Entry entry)
        {
            return _context.Entry.Add(entry).Entity;
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
