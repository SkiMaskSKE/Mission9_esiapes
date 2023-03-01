using Microsoft.AspNetCore.Mvc;
using Mission9_esiapes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9_esiapes.Controllers
{
    public class HomeController : Controller
    {

        private IBookstoreRepository repo;

        public HomeController (IBookstoreRepository temp)// Initializes the HomeController
        {
            repo = temp;
        }
        public IActionResult Index()
        {
            var blah = repo.Books.ToList();

            return View(blah);
        }
    }
}
