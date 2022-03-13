using Phonebook.Models;
using PhoneBook_Web_API.Context;
using System.Linq;

namespace PhoneBook_Web_API.Repositories
{
    public class PhoneBookRepository : IPhoneBookRepository
    {
        private readonly PhoneBookContext _context;
        public PhoneBookRepository(PhoneBookContext context)
        {
            _context = context;
        }

        public PhoneBook CreateNewPhoneBook(PhoneBook phoneBook)
        {
            return _context.PhoneBook.Add(phoneBook).Entity;
        }

        public int DeletePhoneBook(PhoneBook phoneBook)
        {
            _context.PhoneBook.Remove(phoneBook);
            return _context.SaveChanges();
        }

        public PhoneBook GetPhoneBookByName(string Name)
        {
            return _context.PhoneBook.Where(i => i.Name.Equals(Name, System.StringComparison.OrdinalIgnoreCase)).SingleOrDefault();
        }

        public int UpdatePhoneBook(PhoneBook phoneBook)
        {
            PhoneBook existingPhoneBook = _context.PhoneBook.Where(pb => pb.Id == phoneBook.Id).SingleOrDefault();
            existingPhoneBook.Name = phoneBook.Name;
            existingPhoneBook.Entries = phoneBook.Entries;
            return _context.SaveChanges();
        }
    }
}
