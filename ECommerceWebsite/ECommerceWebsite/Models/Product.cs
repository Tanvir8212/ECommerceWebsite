using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Display(Name = "Selling Price")]
        public double SellingPrice { get; set; }

        [Display(Name = "Sub Catagory")]
        public SubCatagory SubCatagory { get; set; }

        public double Quantity { get; set; }

        public QuantityType QuantityType { get; set; } // KG, Litter, MiliLitter, Poa, Hali



    }
}