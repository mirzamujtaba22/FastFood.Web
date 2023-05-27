using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastFood.Models;

namespace FastFood.Repository
{
    internal class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Coupon> Coupons { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<OrderHeader> OrderHeader { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

    }
}
