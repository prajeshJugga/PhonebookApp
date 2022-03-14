using Phonebook.Models;
using PhoneBook_Web_API.Context;
using System.Collections.Generic;
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
            _context.PhoneBook.Add(phoneBook);
            _context.SaveChanges();
            return phoneBook;
        }

        public int DeletePhoneBook(PhoneBook phoneBook)
        {
            _context.PhoneBook.Remove(phoneBook);
            return _context.SaveChanges();
        }

        public PhoneBook GetPhoneBookByName(string Name)
        {
            return _context.PhoneBook.Where(i => i.Name.Equals(Name)).ToList().SingleOrDefault();
        }

        public List<string> GetPhoneBookNames()
        {
            var phoneBookNames = _context.PhoneBook.Select(i => i.Name);
            if (!phoneBookNames.Any())
            {
                return new List<string>();
            }
            return phoneBookNames.ToList();
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
