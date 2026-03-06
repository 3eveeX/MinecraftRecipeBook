using Microsoft.EntityFrameworkCore;
using MinecraftRecipeBook.Models;
using System.Collections.Generic;

namespace MinecraftRecipeBook.Data
{
    public class RecipeContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
             => options.UseSqlite("Data Source=recipes.db");
    }
}
