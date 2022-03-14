using Phonebook.DTOs;
using System.Collections.Generic;

namespace PhoneBook_Web_API.Services.Interfaces
{
    public interface IPhoneBookService
    {
        PhoneBook CreateNewPhoneBook(PhoneBook phoneBook);
        PhoneBook GetPhoneBookByName(string Name);
        List<string> GetPhoneBookNames();
        int UpdatePhoneBook(PhoneBook phoneBook);
        int DeletePhoneBook(PhoneBook phoneBook);
    }
}
