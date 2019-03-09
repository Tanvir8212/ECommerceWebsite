using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.Models
{
    public class Cart
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public List<Item> Items { get; set; }
        public DateTime CartCreatedOn { get; set; }
    }
}