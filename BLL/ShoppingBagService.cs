using BLL.interfaces;
using DAL.interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class ShoppingBagService : IShoppingBagService
    {
        IShoppingBagRepository repository;

        public ShoppingBagService(IShoppingBagRepository _repository)
        {
            repository = _repository;
        }

        public List<ShoppingBag> GetAllShoppingBags()
        {
            return repository.Get();
        }

        public void Add(ShoppingBag shoppingbag)
        {
            repository.Add(shoppingbag);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public ShoppingBag FindById(int id)
        {
            return repository.FindById(id);
        }

        public void Update(ShoppingBag shoppingbag)
        {
            repository.Update(shoppingbag);
        }

        public int LastId()
        {
            return repository.LastId();
        }
    }
}
