using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace MacoBikes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIProductController : ControllerBase
    {
        IProductService service;

        public APIProductController(IProductService _service)
        {
            service = _service;
        }
     
        public APIProductController()
        {
            List<Product> producten = service.GetAllProducts();
            //producten.Add(new Product() { ProductId = 100, Name="Fiets100", Price=500 });
            //producten.Add(new Product() { ProductId = 101, Name = "Fiets101", Price =600 });

        }

        [HttpGet]
        public IActionResult GetAlleproducten()
        {
            return Ok(producten);
        }

        /// <summary>
        /// Get request: http://localhost:1111/tom/2
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            //trycatch werken om id buiten scope te vangen
            try
            {
                return Ok(producten.Where(p => p.ProductId == id).Single());
            }
            catch (Exception)
            {
                return NotFound();
            }

        }

        [HttpPost]
        public IActionResult Create(Product Product)
        {
            producten.Add(Product);
            return Ok(Product);
        }
    }
}
