using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phonebook.DTOs;
using PhoneBook_Web_API.Services;
using System.Collections.Generic;

namespace PhoneBook_Web_API.Controllers
{
    [ApiController]
    [Route("phonebook")]
    [Produces("application/json")]

    public class PhoneBookController : ControllerBase
    {
        private readonly OrchestrationService _orchestrationService;
        private readonly ILogger<PhoneBookController> _logger;

        public PhoneBookController(OrchestrationService orchestrationService, ILogger<PhoneBookController> logger)
        {
            _orchestrationService = orchestrationService;
            _logger = logger;
        }

        [HttpPost("create")]
        public PhoneBook CreatePhoneBook([FromBody] PhoneBook phoneBook)
        {
            return _orchestrationService._phoneBookService.CreateNewPhoneBook(phoneBook);
        }

        [HttpGet("get/{phoneBookName}")]
        public PhoneBook GetPhoneBookByName(string phoneBookName)
        {
            return _orchestrationService._phoneBookService.GetPhoneBookByName(phoneBookName);
        }

        [HttpGet("get/phonebookNames")]
        public List<string> GetPhoneBookNames()
        {
            return _orchestrationService._phoneBookService.GetPhoneBookNames();
        }
    }
}
