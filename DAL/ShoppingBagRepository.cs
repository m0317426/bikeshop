using DAL.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ShoppingBagRepository:IShoppingBagRepository
    {
        DataContext context;

        public ShoppingBagRepository(DataContext _context)
        {
            context = _context;
        }

        public List<ShoppingBag> Get()
        {
            return context.ShoppingBags.ToList();
        }

        public ShoppingBag FindById(int id)
        {
            return context.ShoppingBags.Where(u => u.ShoppingBagId == id).Single();
        }

        public void Update(ShoppingBag shoppingbag)
        {
            context.ShoppingBags.Update(shoppingbag);
            context.SaveChanges();
        }

        public void Add(ShoppingBag shoppingbag)
        {
            context.ShoppingBags.Add(shoppingbag);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shoppingbag = context.ShoppingBags.SingleOrDefault(p => p.ShoppingBagId == id);
            context.ShoppingBags.Remove(shoppingbag);
            context.SaveChanges();
        }

        public int LastId()
        {
            return context.ShoppingBags.Max(u => u.ShoppingBagId);
        }
    }
}
