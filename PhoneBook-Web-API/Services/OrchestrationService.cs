using PhoneBook_Web_API.Services.Interfaces;

namespace PhoneBook_Web_API.Services
{
    public class OrchestrationService
    {
        internal IEntryService _entryService;
        internal IPhoneBookService _phoneBookService;

        public OrchestrationService(IEntryService entryService, IPhoneBookService phoneBookService)
        {
            _entryService = entryService;
            _phoneBookService = phoneBookService;
        }
    }
}
