using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerceWebsite.Models
{
    public class MyDbContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<PurchaseLot> PurchaseLots { get; set; }
        public DbSet<QuantityType> QuantityTypes { get; set; }

        public DbSet<SubCatagory> SubCatagories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }


        public MyDbContext()
        {

        }
    }
}