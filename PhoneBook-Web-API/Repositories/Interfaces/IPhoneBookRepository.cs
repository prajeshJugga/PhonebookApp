using Phonebook.Models;
using System.Collections.Generic;

namespace PhoneBook_Web_API.Repositories
{
    public interface IPhoneBookRepository
    {
        PhoneBook CreateNewPhoneBook(PhoneBook phoneBook);
        PhoneBook GetPhoneBookByName(string Name);
        List<string> GetPhoneBookNames();
        int UpdatePhoneBook(PhoneBook phoneBook);
        int DeletePhoneBook(PhoneBook phoneBook);
    }
}
