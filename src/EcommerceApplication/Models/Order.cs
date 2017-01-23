using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Models
{
    [Table("Order")]
    public class Order
    {
        public Order()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal? OrderTotal { get; set; }
        
        // Set foreign key to other tables
        public int CustomerId { get; set; }
        public virtual Customer Customers { get; set; }

        // Get collection from other models
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
