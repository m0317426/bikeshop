using DAL.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL
{
    public class ShoppingItemRepository : IShoppingItemRepository
    {

        DataContext context;

        public ShoppingItemRepository(DataContext _context)
        {
            context = _context;
        }

        public List<ShoppingItem> Get()
        {
            return context.ShoppingItems.ToList();
        }

        public ShoppingItem FindById(int id)
        {
            return context.ShoppingItems.Where(u => u.ShoppingItemId == id).Single();
        }

        public void Add (ShoppingItem shoppingitem)
        {
            context.ShoppingItems.Add(shoppingitem);
            context.SaveChanges();
        }

        public void Update(ShoppingItem shoppingitem)
        {
            context.ShoppingItems.Update(shoppingitem);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var shoppingItem = context.ShoppingItems.SingleOrDefault(p => p.ShoppingItemId == id);
            context.ShoppingItems.Remove(shoppingItem);
            context.SaveChanges();
        }
    }
}

   