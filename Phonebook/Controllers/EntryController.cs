using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Client;
using Phonebook.Models;
using Phonebook.Requesters;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Phonebook.Controllers
{
    public class EntryController : Controller
    {
        private string uri = "http://localhost:8384";
        // GET: EntryController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EntryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EntryController/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.PhoneBookNames = await GetPhoneBookNames();
            return View("Create");
        }

        [NonAction]
        private async Task<List<string>> GetPhoneBookNames()
        {
            HttpClient httpClient = ApiClient.GetHttpClient(uri);
            return await PhoneBookRequester.GetPhoneBookNames(httpClient);
        }

        // POST: EntryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection, Entry entry)
        {
            try
            {
                HttpClient httpClient = ApiClient.GetHttpClient(uri);

                await EntryRequester.CreateEntry(httpClient, entry);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction("Shared", "Error", new ErrorViewModel { RequestId = "Unable to create Phonebook Entry." });
            }
        }

        // GET: EntryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EntryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: EntryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EntryController/Delete/5
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
    }
}
