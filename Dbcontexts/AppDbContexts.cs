using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopIP.Entities;
using WebShopIP.Models;

namespace WebShopIP.Dbcontexts
{
    public class AppDbContexts : IdentityDbContext<ApplicationUser>
    {
        public AppDbContexts()
        {

        }
        public AppDbContexts(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<InfoCustomer> InfoCustomers { get; set; }

        //Info for Account
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}