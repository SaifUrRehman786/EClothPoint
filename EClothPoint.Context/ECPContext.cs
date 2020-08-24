using EClothPoint.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EClothPoint.Context
{
   public class ECPContext : DbContext
    {
        public ECPContext() : base("EClothPointConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
