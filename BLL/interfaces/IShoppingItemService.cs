using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.interfaces
{
    public interface IShoppingItemService
    {
        List<ShoppingItem> GetAllShoppingItems();

        ShoppingItem FindById(int id);

        void Update(ShoppingItem shoppingitem);

        void Add(ShoppingItem shoppingitem);

        void Remove(int id);
    }
}