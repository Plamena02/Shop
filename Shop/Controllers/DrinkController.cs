using Shop.Data;
using Shop.Data.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Shop.Controllers
{
    public class DrinkController
    {
        private ShopContext context;
        public List<Drink> GetAllDrinks()
        {
            using (context = new ShopContext())
            {
                return context.Drinks.ToList();
            }
        }

        public Drink GetDrinkByName(string name)
        {
            using (context = new ShopContext())
            {
                return context.Drinks.Find(name);
            }
        }

        public void Add(Drink drink)
        {
            using (context = new ShopContext())
            {
                context.Add(drink);
                context.SaveChanges();
            }
        }

        public void Update(Drink drink)
        {
            using (context = new ShopContext())
            {
                var item = context.Drinks.Find(drink.Id);
                if(item!=null)
                {
                    context.Entry(item).CurrentValues.SetValues(drink);
                    context.SaveChanges();
                }
            }
        }

        public void Delete(Drink drink)
        {
            using (context = new ShopContext())
            {
                var item = context.Drinks.Find(drink.Id);
                if (item != null)
                {
                    context.Drinks.Remove(item);
                    context.SaveChanges();
                }
            }
        }
    }
}
