﻿using EcommerceApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApplication.DataContext
{
    public class MyContext : DbContext // Inherent from Microsoft.EntityFrameworkCore;
    {
        public MyContext(DbContextOptions<MyContext> options):base(options)
        {
            
        }

        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderLine> OrderLine { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        
    }
}
