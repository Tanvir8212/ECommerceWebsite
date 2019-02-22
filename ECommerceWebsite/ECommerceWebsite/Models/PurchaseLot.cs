using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.Models
{
    public class PurchaseLot
    {
        [Key]
        public int Id { get; set; }

        public Product Product { get; set; }
        public double BuyingPrice { get; set; }
        public double Quantity { get; set; }
        public QuantityType QuantityType { get; set; }

        public DateTime DateTime { get; set; }

    }
}