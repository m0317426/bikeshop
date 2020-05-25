using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.interfaces
{
   public interface IShoppingBagService
    {
        List<ShoppingBag> GetAllShoppingBags();

        ShoppingBag FindById(int id);

        void Add(ShoppingBag shoppingbag);

        void Update(ShoppingBag shoppingbag);

        void Delete(int id);

        int LastId();
    }
}
