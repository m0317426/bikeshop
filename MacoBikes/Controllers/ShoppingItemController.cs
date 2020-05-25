using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace MacoBikes.Controllers
{
    public class ShoppingItemController : Controller
    {
        IShoppingItemService service;

        public ShoppingItemController(IShoppingItemService _service)
        {
            service = _service;
        }
        public IActionResult Index()
        {
            List<ShoppingItem> customers = service.GetAllShoppingItems();
            return View(customers);
        }

        //GET: Customer/create
        public IActionResult Create()
        {
            return View();
        }
    }
}