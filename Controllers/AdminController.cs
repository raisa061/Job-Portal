using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjetct.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EditDetails(int id)
        {
            return View();
        }

        public IActionResult GetCV()
        {
            return View();
        }
    }
}
