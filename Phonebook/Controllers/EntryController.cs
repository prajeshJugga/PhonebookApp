using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Models;
using System;
using System.Collections.Generic;

namespace Phonebook.Controllers
{
    public class EntryController : Controller
    {
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
        public ActionResult Create()
        {
            ViewBag.PhoneBookNames = new List<string>(); // GetPhoneBookNames();
            return View("Create");
        }

        [NonAction]
        private List<string> GetPhoneBookNames()
        {
            return new List<string>
            {
                "Home",
                "Work",
                "Friends"
            };
        }

        // POST: EntryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Entry entry)
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
