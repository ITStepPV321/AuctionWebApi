﻿using AuctionWebApi.Core.Entities;
using AuctionWebApi.Core.Initializers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionWebApi.Core.Data
{
    public class AuctionDbContext : IdentityDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<BetHistory> BetHistories { get; set; }

        public AuctionDbContext(DbContextOptions<AuctionDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            EntityTypeBuilder<User> userTypeBuilder = modelBuilder.Entity<User>();
            EntityTypeBuilder<Auction> auctionTypeBuilder = modelBuilder.Entity<Auction>();
            EntityTypeBuilder<Invoice> invoiceTypeBuilder = modelBuilder.Entity<Invoice>();

            UserInitializer.Initialize(userTypeBuilder);
            AuctionInitializer.Initialize(auctionTypeBuilder);
            InvoiceInitializer.Initialize(invoiceTypeBuilder);
        }
    }
}