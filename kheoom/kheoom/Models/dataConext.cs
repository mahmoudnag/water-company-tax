using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace kheoom.Models
{
    public class dataContext:DbContext
    {
        public dataContext(DbContextOptions options) : base(options) { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Slice> Slices { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Block> Blocks { get; set; }

        public virtual DbSet<SubScriber> SubScribers { get; set; }

        public virtual DbSet<SubScribption> SubScribptions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
