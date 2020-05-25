using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Model
{
    public class ShoppingItem
    {
        public int ShoppingItemId { get; set; }
        public int Quantity { get; set; }

        //Foreign key voor ShoppingBag
        [DisplayName("Shoppingbag")]
        public int ShoppingBagId { get; set; }
        public ShoppingBag ShoppingBag { get; set; }

        //Foreign key voor Product
        [DisplayName("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
