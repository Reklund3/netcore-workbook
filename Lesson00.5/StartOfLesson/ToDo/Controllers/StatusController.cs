using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class StatusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
    
}