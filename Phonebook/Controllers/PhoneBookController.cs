﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Models;
using System.Collections.Generic;

namespace Phonebook.Controllers
{
    public class PhoneBookController : Controller
    {
        // GET: PhoneBookController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PhoneBookController/Details/5
        public ActionResult Details(int id)
        {
            return View("View");
        }

        // GET: PhoneBookController/Create
        public ActionResult Create()
        {
            return View("Create");
        }

        // POST: PhoneBookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, PhoneBook phoneBook)
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
    }
}
