using Phonebook.DTOs;

namespace PhoneBook_Web_API.Services.Interfaces
{
    public interface IPhoneBookService
    {
        PhoneBook CreateNewPhoneBook(PhoneBook phoneBook);
        int UpdatePhoneBook(PhoneBook phoneBook);
        int DeletePhoneBook(PhoneBook phoneBook);
    }
}
