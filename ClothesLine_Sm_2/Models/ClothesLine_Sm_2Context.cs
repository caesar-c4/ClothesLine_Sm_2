using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ClothesLine_Sm_2.Models
{
    public class ClothesLine_Sm_2Context : DbContext
    {
        public ClothesLine_Sm_2Context() : base("ClothesLine_Sm_2")
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}