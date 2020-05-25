using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.interfaces
{
    public interface IShoppingBagRepository
    {
        List<ShoppingBag> Get();

        ShoppingBag FindById(int id);

        void Add(ShoppingBag shoppingbag);

        void Update (ShoppingBag shoppingbag);

        void Delete(int id);

        int LastId();

    }
}
