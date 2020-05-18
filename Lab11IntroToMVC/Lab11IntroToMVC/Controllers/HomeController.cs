using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab11IntroToMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab11IntroToMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int firstYear, int lastYear)
        {
            return RedirectToAction("Ranger", new { firstYear, lastYear });
        }

        public IActionResult Ranger(RangerViewModel viewModel)
        {
            return View(viewModel);
        }

        public IActionResult Welcome()
        {
            return View();
        }
    }
}