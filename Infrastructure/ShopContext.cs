﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Database=ShopDb; Server=DESKTOP-I9OGOOT; " +
                                      "Trusted_Connection=True; Connection Timeout = 10000";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stock>()
                .HasOne(x => x.Product);
            modelBuilder.Entity<OrderItem>()
                .HasOne(x => x.Product);

            modelBuilder.Entity<OrderItem>()
                .HasOne(x => x.Purchase)
                .WithMany(x => x.OrderedItems)
                .HasForeignKey(x => x.PurchaseId);

            modelBuilder.Entity<OrderItem>()
                .Property(x => x.DateTime)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Purchase>()
                .Property(x => x.DateTime)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Product>()
                .Property(x => x.Name)
                .HasMaxLength(50);
            modelBuilder.Entity<Product>()
                .Property(x => x.Type)
                .HasMaxLength(50);
        }
    }
}
