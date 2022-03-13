using Phonebook.DTOs;
using PhoneBook_Web_API.Context;
using PhoneBook_Web_API.Services.Interfaces;

namespace PhoneBook_Web_API.Services
{
    public class PhoneBookService : IPhoneBookService
    {
        private readonly PhoneBookContext _context;
        public PhoneBookService(PhoneBookContext context)
        {
            _context = context;
        }

        public PhoneBook CreateNewPhoneBook(PhoneBook phoneBook)
        {
            throw new System.NotImplementedException();
        }

        public int DeletePhoneBook(PhoneBook phoneBook)
        {
            throw new System.NotImplementedException();
        }

        public int UpdatePhoneBook(PhoneBook phoneBook)
        {
            throw new System.NotImplementedException();
        }
    }
}
