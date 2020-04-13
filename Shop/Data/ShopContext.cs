using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class ShopContext:DbContext
    {
        public ShopContext():base()
        {

        }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Nut> Nuts { get; set; }
        public DbSet<FruitAndVegetable> FruitsAndVegetables { get; set; }
        public DbSet<Pastry> Pastries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .\\SQLEXPRESS; Database = Shop; Integrate Security = true");
        }
    }
}
