using DAL.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
   public class ProductRepository:IProductRepository
    {     
        DataContext context;

        public ProductRepository(DataContext _context)
        {
            context = _context;          
        }

        public List<Product> Get()
        {
            return context.Products.ToList();
        }

        public Product FindById(int id)
        {
            return context.Products.Where(u => u.ProductId == id).Single();
        }

        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }      

        public void Update(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = context.Products.SingleOrDefault(p => p.ProductId == id);
            context.Products.Remove(product);
            context.SaveChanges();           
        }
    }
}
