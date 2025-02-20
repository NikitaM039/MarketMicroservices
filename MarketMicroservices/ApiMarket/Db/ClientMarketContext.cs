﻿using MarketMicroservices.ApiMarket.Db;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ApiClientMarket.Db
{
    public class ClientMarketContext : DbContext
    {
        private string? connectionString;
        public DbSet<ClientProduct> ClientProducts { get; set; }

        public ClientMarketContext(DbContextOptions<ClientMarketContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientProduct>(entity =>
            {
                entity.HasKey(p => p.Id).HasName("order_pkey");
                entity.ToTable("client_products");

                entity.Property(e => e.ClientId).HasColumnName("client_id");
                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}