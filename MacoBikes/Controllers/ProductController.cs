using BLL.interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;

namespace MacoBikes.Controllers
{
    public class ProductController : Controller
    {
        IProductService service;

        public ProductController(IProductService _service)
        {
            service = _service;
        }
        public IActionResult Index()
        {
            List<Product> products = service.GetAllProducts();
            return View(products);
        }

        //GET: Product/create
        public  IActionResult Create()
        {
            return View();
        }

        //POST: Product/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ProductId, Name,Price")] Product product)
        {
            if (ModelState.IsValid)
	        {
                service.Add(product);
                return RedirectToAction("Index");
	        }       
            return View(product);
        }

        //GET: Product/edit
        public  IActionResult Edit(int productid)
        {
            Product product = service.FindById(productid);
            return View(product);
        }
        //POST:Product/edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,[Bind("ProductId, Name,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    service.Update(product);
                }
                catch (Exception)
                {

                    throw;
                }
                return RedirectToAction("Index");
            }
            return View(product);
        }

        //GET: Product/delete
        public  IActionResult Delete (int productId)
        {
            service.Delete(productId);
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int productId)
        {
            Product product = service.FindById(productId);
            return View(product);
        }
    }
}