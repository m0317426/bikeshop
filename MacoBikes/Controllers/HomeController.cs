using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace MacoBikes.Controllers
{
    public class HomeController : Controller
    {
        public static int shoppingBagId = 0;

        IUserService service;

        public HomeController(IUserService _service)
        {
            service = _service;
        }
        public IActionResult Index()
        {
            //List<User> users = service.GetAllUsers();
            //ViewData["users"] = users;

            //index hyperlink image random
            Random r = new Random();
            int number = r.Next(1, 9);
            ViewData["ImageNumber"] = number;

            return View();
        }
    }
}