using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.Models
{
    [Table("SubCategory")]
    public class SubCategory
    {
        public int SubCategoryId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="SubCategory Name")]
        public string SubCategoryName { get; set; }

        // Set foreign key to other tables
        public int CategoryId { get; set; }
        public virtual Category Categories { get; set; }
    }
}
