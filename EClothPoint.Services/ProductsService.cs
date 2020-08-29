using EClothPoint.Context;
using EClothPoint.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EClothPoint.Services
{
    public class ProductsService
    {
        public Product GetProduct(int ID)
        {
            using (var context = new ECPContext())
            {
                return context.Products.Find(ID);
            }
        }
        public List<Product> GetAllProducts()
        {
            using (var context = new ECPContext())
            {
                return context.Products.ToList();
            }
        }
        public void SaveProduct(Product product)
        {
            using (var context = new ECPContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }

        }
        public void UpdateProduct(Product product)
        {
            using (var context = new ECPContext())
            {
                context.Entry(product).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteProduct(int ID)
        {
            using (var context = new ECPContext())
            {
                var product = context.Products.Find(ID);
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
