﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.Models
{
    public class Cart
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }

        public List<Product> Products { get; set; }
        public List<int> Quantities { get; set; }

        public DateTime CartCreatedOn { get; set; }

        public Boolean Confirm { get; set; } // If cart is added to customerOrder then it will be true.. Otherwise false
    }
}