using Firstproject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Firstproject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PriceOfProducts()
        {
            return View();
        }


    }
}