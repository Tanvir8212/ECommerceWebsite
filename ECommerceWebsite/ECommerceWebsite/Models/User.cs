﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.Models
{
    public class User
    {
        [Key]
        [Display(Name ="Phone Number")]
        public long PhoneNumber { get; set; }

        public String Password { get; set; }

        public UserType UserType { get; set; }

    }
}