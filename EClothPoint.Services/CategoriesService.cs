using EClothPoint.Context;
using EClothPoint.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EClothPoint.Services
{
   public class CategoriesService
    {
        public Category GetCategory(int ID)
        {
            using (var context = new Context.ECPContext())
            {
                return context.Categories.Find(ID);
            }
        }
        public List<Category> GetAllCategories()
        {
            using (var context = new ECPContext())
            {
                return context.Categories.ToList();
            }
        }
        public void SaveCategory(Category category)
        {
            using (var context = new ECPContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }

        }
        public void UpdateCategory(Category category)
        {
            using (var context = new ECPContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteCategory(int ID)
        {
            using (var context = new ECPContext())
            {
                var category = context.Categories.Find(ID);
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
