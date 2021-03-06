using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Client;
using Phonebook.Models;
using Phonebook.Requesters;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Phonebook.Controllers
{
    public class PhoneBookController : Controller
    {
        private string uri = "http://localhost:8384";
        // GET: PhoneBookController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PhoneBookController/Details/5
        public async Task<ActionResult> Search()
        {
            ViewBag.PhoneBookNames = await GetPhoneBookNames();
            return View("Search");
        }

        // GET: PhoneBookController/Details/5
        public async Task<ActionResult> Details(IFormCollection collection, PhoneBook phoneBookInput)
        {
            HttpClient httpClient = ApiClient.GetHttpClient(uri);
            PhoneBook phoneBook = await PhoneBookRequester.GetPhoneBookByName(httpClient, phoneBookInput.Name);
            return View("View", phoneBook);
        }

        // GET: PhoneBookController/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: PhoneBookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection, PhoneBook phoneBook)
        {
            try
            {
                HttpClient httpClient = ApiClient.GetHttpClient(uri);

                await PhoneBookRequester.CreatePhoneBook(httpClient, phoneBook);
                return RedirectToAction("Home", "Index");
            }
            catch
            {
                return RedirectToAction("Shared", "Error", new ErrorViewModel { RequestId = "Unable to create Phonebook." });
            }
        }

        // GET: PhoneBookController/Edit/5
        public ActionResult Edit(int id)
        {
            PhoneBook phonebook = new PhoneBook()
            {
                Name = "Home Book",
                Entries = new List<Entry> 
                { 
                    new Entry() { Name = "Bob", Number = "0211545454" },
                    new Entry() { Name = "Joe", Number = "0119896562" }
                }
            };
            return View("Edit", phonebook);
        }

        // POST: PhoneBookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(IFormCollection collection, PhoneBook phoneBook)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PhoneBookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhoneBookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        private async Task<List<string>> GetPhoneBookNames()
        {
            HttpClient httpClient = ApiClient.GetHttpClient(uri);
            return await PhoneBookRequester.GetPhoneBookNames(httpClient);
        }
    }
}
