using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.Models
{
    public class Item
    {
        public int Id { get; set; }

        public Product Product { get; set; }

        public double Quantity { get; set; }

        public QuantityType QuantityType { get; set; }


    }
}