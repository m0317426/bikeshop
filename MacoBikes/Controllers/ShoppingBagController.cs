using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace MacoBikes.Controllers
{
    public class ShoppingBagController : Controller
    {
        IShoppingBagService serviceShoppingBag;
        IShoppingItemService serviceShoppingItem;

        public ShoppingBagController(IShoppingBagService _serviceShoppingBag, IShoppingItemService _serviceShoppingItem)
        {
            serviceShoppingBag = _serviceShoppingBag;
            serviceShoppingItem = _serviceShoppingItem;
        }

        public IActionResult Index()
        {
            List<ShoppingBag> shoppingBags = serviceShoppingBag.GetAllShoppingBags();
            return View(shoppingBags);
        }

        public IActionResult Create(int customerId, int productId, int quantity)
        {
            //create new ShoppingBag
            if (HomeController.shoppingBagId == 0)
            {
                ShoppingBag shoppingBag = new ShoppingBag();
                shoppingBag.CustomerId = customerId;
                shoppingBag.Date = DateTime.Now.Date;

                serviceShoppingBag.Add(shoppingBag);

                int shoppingBagId = serviceShoppingBag.LastId();
                HomeController.shoppingBagId = shoppingBagId;
            }
            //Add product to ShoppingItem
            ShoppingItem shoppingItem = new ShoppingItem();

            shoppingItem.ShoppingBagId = HomeController.shoppingBagId;
            shoppingItem.ProductId = productId;
            shoppingItem.Quantity = quantity;

            serviceShoppingItem.Add(shoppingItem);


            //Redirect to Edit
            return RedirectToAction("Edit", new { HomeController.shoppingBagId });
        }

        public IActionResult Edit(int shoppingBagId)
        {
            if (shoppingBagId > 0)
            {
                ShoppingBag shoppingBag = serviceShoppingBag.FindById(shoppingBagId);
                return View(shoppingBag);
            }
            else if (HomeController.shoppingBagId > 0)
            {
                ShoppingBag shoppingBag = serviceShoppingBag.FindById(HomeController.shoppingBagId);
                return View(shoppingBag);
            }

            return RedirectToAction("Index");

            //ShoppingBag shoppingBag = service.FindById(shoppingBagId);
            //return View(shoppingBag);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int ShoppingBagId, [Bind("CustomerId, Date")] ShoppingBag shoppingBag)
        {
            if (ModelState.IsValid)
            {
                serviceShoppingBag.Add(shoppingBag);
                return RedirectToAction("Index");
            }
            return View(shoppingBag);
        }
    }
}