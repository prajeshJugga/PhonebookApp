using Phonebook.Models;

namespace PhoneBook_Web_API.Repositories
{
    public interface IPhoneBookRepository
    {
        PhoneBook CreateNewPhoneBook(PhoneBook phoneBook);
        PhoneBook GetPhoneBookByName(string Name);  
        int UpdatePhoneBook(PhoneBook phoneBook);
        int DeletePhoneBook(PhoneBook phoneBook);
    }
}
