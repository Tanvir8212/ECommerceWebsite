using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.Models
{
    public class CustomerOrder
    {

        [Key]
        public int Id { get; set; }

        public List<Item> Items { get; set; }

        public double TotalPrice { get; set; }

        public User Customer { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }
}