using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Models
{
    // This is a ViewModel, so we don't need to set the table name
    public class Cart
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public List<CartItem> CartItems { get; set; }
    }
}
