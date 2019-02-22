using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.Models
{
    public class SubCatagory
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Catagory Catagory { get; set; }

    }
}