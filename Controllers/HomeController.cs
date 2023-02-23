using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProgressBar() { 

            return View();
        }
        public IActionResult Accordion()
        {
            return View();
        }

        public IActionResult ProductList()
        {
            return View();
        }

        public IActionResult ShopList() {

            return View();
        }

        public IActionResult Tab() { 
            return View();
        }




    }
}