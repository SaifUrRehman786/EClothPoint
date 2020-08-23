using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EClothPoint.Entities
{
   public class Category : Base
    {
        public List<Product> Products { get; set; }
    }
}
