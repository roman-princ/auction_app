using auction_app.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auction_app.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Auction> Auctions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source= auctions_app.sqlite");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Auction>().HasKey(x => x.Id);
            builder.Entity<User>().HasKey(x => x.Id);
            builder.Entity<Auction>().HasOne(x => x.Creator).WithMany(x => x.MyAuctions);
        }



    }
}
