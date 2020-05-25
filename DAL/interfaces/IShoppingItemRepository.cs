using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.interfaces
{
    public interface IShoppingItemRepository
    {

        List<ShoppingItem> Get();

        ShoppingItem FindById(int id);

        void Update(ShoppingItem shoppingitem);

        void Add(ShoppingItem shoppingitem);

        void Remove(int id);
    }
}
