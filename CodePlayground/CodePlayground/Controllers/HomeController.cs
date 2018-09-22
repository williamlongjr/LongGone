using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodePlayground.Models;

namespace CodePlayground.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult EmmaArt()
        {
            ViewData["Message"] = "Emma's Art page.";

            return View();
        }

        public IActionResult AudreyArt()
        {
            ViewData["Message"] = "Audrey's Art page.";

            return View();
        }

        public IActionResult LillianArt()
        {
            ViewData["Message"] = "Lillian's Art page.";

            return View();
        }

        public IActionResult Todo()
        {
            ViewData["Message"] = "Todo list";

            return View();
        }

        public IActionResult Garden()
        {
            ViewData["Message"] = "Garden Bot";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
