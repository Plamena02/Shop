using Shop.Data;
using Shop.Data.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Shop.Controllers
{
    public class NutController
    {
        private ShopContext context;
        public List<Nut> GetAllNuts()
        {
            using (context = new ShopContext())
            {
                return context.Nuts.ToList();
            }
        }

        public Nut GetNutByName(string name)
        {
            using (context = new ShopContext())
            {
                return context.Nuts.Find(name);
            }
        }

        public void Add(Nut nut)
        {
            using (context = new ShopContext())
            {
                context.Add(nut);
                context.SaveChanges();
            }
        }

        public void Update(Nut nut)
        {
            using (context = new ShopContext())
            {
                var item = context.Nuts.Find(nut.Id);
                if(item!=null)
                {
                    context.Entry(item).CurrentValues.SetValues(nut);
                    context.SaveChanges();
                }
            }
        }

        public void Delete(Nut nut)
        {
            using (context = new ShopContext())
            {
                var item = context.Nuts.Find(nut.Id);
                if (item != null)
                {
                    context.Nuts.Remove(item);
                    context.SaveChanges();
                }
            }
        }
    }
}
