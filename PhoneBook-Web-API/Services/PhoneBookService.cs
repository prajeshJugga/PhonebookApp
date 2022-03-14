using Phonebook.DTOs;
using PhoneBook_Web_API.Context;
using PhoneBook_Web_API.Repositories;
using PhoneBook_Web_API.Services.Interfaces;
using System.Collections.Generic;

namespace PhoneBook_Web_API.Services
{
    public class PhoneBookService : IPhoneBookService
    {
        private readonly PhoneBookContext _context;
        private readonly IPhoneBookRepository _phoneBookRepository;
        public PhoneBookService(PhoneBookContext context, IPhoneBookRepository phoneBookRepository)
        {
            _context = context;
            _phoneBookRepository = phoneBookRepository;
        }

        public PhoneBook CreateNewPhoneBook(PhoneBook phoneBook)
        {
            Phonebook.Models.PhoneBook phoneBookModel = _phoneBookRepository.CreateNewPhoneBook(new Phonebook.Models.PhoneBook(phoneBook));
            phoneBook.Id = phoneBookModel.Id;
            return phoneBook;
        }

        public int DeletePhoneBook(PhoneBook phoneBook)
        {
            return _phoneBookRepository.DeletePhoneBook(new Phonebook.Models.PhoneBook(phoneBook));
        }

        public PhoneBook GetPhoneBookByName(string Name)
        {
            Phonebook.Models.PhoneBook phoneBookModel = _phoneBookRepository.GetPhoneBookByName(Name);
            return new PhoneBook(phoneBookModel);
        }

        public List<string> GetPhoneBookNames()
        {
            return _phoneBookRepository.GetPhoneBookNames();
        }

        public int UpdatePhoneBook(PhoneBook phoneBook)
        {
            return _phoneBookRepository.UpdatePhoneBook(new Phonebook.Models.PhoneBook(phoneBook));
        }
    }
}
