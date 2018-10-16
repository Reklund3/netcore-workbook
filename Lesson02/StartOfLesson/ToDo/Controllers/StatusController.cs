using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.Services;

namespace ToDoApp.Controllers
{
    public class StatusController : Controller
    {
        public IActionResult Index()
        {
            return View(Services.Repository.Statuses);
        }
        // GET: Status/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Status/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Status collection)
        {
            try
            {
                // STATUS: Add insert logic here
                Repository.Statuses.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        // GET: Status/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Repository.Statuses.FirstOrDefault(x => x.Id == id));
        }
        // POST: Status/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Status collection)
        {
            try
            {
                // STATUS: Add update logic here
                Repository.Statuses.Remove(Repository.Statuses.FirstOrDefault(x => x.Id == id));
                Repository.Statuses.Add(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}