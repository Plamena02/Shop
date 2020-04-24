using DataVisual;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace DataVisual
{
    /// <summary>
    /// Context to connect to the database.
    /// </summary>
    public class ShopContext : DbContext
    {
        public ShopContext() : base()
        {

        }

        public virtual DbSet<FruitAndVegetable> FruitsAndVegetables { get; set; }
        public virtual DbSet<Nut> Nuts { get; set; }
        public virtual DbSet<Pastry> Pastries { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }

    }
}

