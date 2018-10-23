using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        
        private static List<ToDo> list = new List<ToDo>()
        {
            new ToDo {Id = 1, Title = "Item one", Description = "the very first item", Status = Status.Statuses[1]}
        };
        public IActionResult Index()
        {
            return View(list);
        }
    }
}