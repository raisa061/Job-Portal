using FinalProjetct.Data;
using FinalProjetct.Models;
using FinalProjetct.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjetct.Controllers
{
    public class UserController : Controller
    {
        private UserRepository repository;
        private UserContext context;

        public UserController(UserContext _context)
        {
            context = _context;
            repository = new UserRepository(context);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            int id = repository.AddUser(user);
            ViewBag.Id = id;

            return View("UserAdded");
        }

        public IActionResult ViewUser()
        {
           var users=  repository.GetAllUser();
            return View(users);
        }
    }
}
