using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductoApi.Models
{
    using System.ComponentModel.DataAnnotations;
    public class product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [Display(Name = "Product Name")]

        public string Name { get; set; }
        public double Price { get; set; }
    }
}