using BLL.interfaces;
using DAL.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ShoppingItemService : IShoppingItemService
    {
        IShoppingItemRepository repository;

        public ShoppingItemService(IShoppingItemRepository _repository)
        {
            repository = _repository;
        }
        public List<ShoppingItem> GetAllShoppingItems()
        {
            return repository.Get();
        }

        public void Add(ShoppingItem shoppingitem)
        {
            repository.Add(shoppingitem);
        }

        public ShoppingItem FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            repository.Remove(id);
        }

        public void Update(ShoppingItem shoppingitem)
        {
            repository.Update(shoppingitem);
        }
    }
}
