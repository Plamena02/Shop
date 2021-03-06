﻿using System.Collections.Generic;
using System.Linq;

namespace ShopVisual.Controllers
{
    /// <summary>
    /// Providers the link between the database and UI.
    /// </summary>
    public class DrinkController
    {
        private ShopContext context;

        /// <summary>
        /// Gives all Drinks in the database.
        /// </summary>
        /// <returns>all drinks from the database</returns>
        public List<Drink> GetAllDrinks()
        {
            using (context = new ShopContext())
            {
                return context.Drinks.ToList();
            }
        }

        /// <summary>
        /// Gives s drink with wanted id. 
        /// </summary>
        /// <param name="id">id of the wanted drink</param>
        /// <returns>a drink with wanted id</returns>
        public Drink GetDrinkById(int id)
        {
            using (context = new ShopContext())
            {

                return context.Drinks.FirstOrDefault(m => m.Id == id);
            }
        }

        /// <summary>
        /// Adds a drink in database.
        /// </summary>
        /// <param name="drink">the drink that will be added</param>
        public void Add(Drink drink)
        {
            using (context = new ShopContext())
            {
                context.Drinks.Add(drink);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates a drink.
        /// </summary>
        /// <param name="drink">the drink that will be updated</param>
        public void Update(Drink drink)
        {
            using (context = new ShopContext())
            {
                var item = context.Drinks.Find(drink.Id);
                if (item != null)
                {
                    context.Entry(item).CurrentValues.SetValues(drink);
                    context.SaveChanges();
                }
            }
        }
        /// <summary>
        /// Deletes a dring with wanted id.
        /// </summary>
        /// <param name="id">id of the wanted drink</param>
        public void Delete(int id)
        {
            using (context = new ShopContext())
            {
                var item = context.Drinks.FirstOrDefault(m => m.Id == id);
                if (item != null)
                {
                    context.Drinks.Remove(item);
                    context.SaveChanges();
                }
                
            }
        }
    }
}