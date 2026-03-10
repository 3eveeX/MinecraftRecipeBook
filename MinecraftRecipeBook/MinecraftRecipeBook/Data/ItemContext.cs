using Microsoft.EntityFrameworkCore;
using MinecraftRecipeBook.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace MinecraftRecipeBook.Data
{
    public class ItemContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
             => options.UseSqlite("Data Source=items.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
                .Property(r => r.Ingredients)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null),
                    v => JsonSerializer.Deserialize<int[]>(v, (JsonSerializerOptions)null)
                );
        }

        public IEnumerable<Item> GetAllItems()
        {
            return Items;
        }
    }
}