using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phonebook.DTOs;
using PhoneBook_Web_API.Services;

namespace PhoneBook_Web_API.Controllers
{
    [ApiController]
    [Route("entry")]
    [Produces("application/json")]
    public class EntryController : ControllerBase
    {
        private readonly OrchestrationService _orchestrationService;
        private readonly ILogger<EntryController> _logger;

        public EntryController(OrchestrationService orchestrationService, ILogger<EntryController> logger)
        {
            _orchestrationService = orchestrationService;
            _logger = logger;
        }

        [HttpPost("create/{phoneBookName}")]
        public Entry CreatePhoneBook([FromBody] Entry entry, string phoneBookName)
        {
            return _orchestrationService._entryService.CreateEntry(entry, phoneBookName);
        }
    }
}
