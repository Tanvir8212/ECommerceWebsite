using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        public CustomerOrder CustomerOrder { get; set; }

        public User DeliveryMan { get; set; }

        public DateTime DateTime { get; set; }

    }
}