using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class ShoppingBag
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ShoppingBagId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //Foreign key naar Customer
        [DisplayName("Customer")]
        public  int CustomerId { get; set; }
        public Customer Customer { get; set; }


        //Foreign key naar ShoppingItem
        [DisplayName("Item")]
        [DisplayFormat(NullDisplayText = "No item")]
        public int? ShoppingItemId { get; set; }
        public ICollection<ShoppingItem> ShoppingItems { get; set; }

    }
}
