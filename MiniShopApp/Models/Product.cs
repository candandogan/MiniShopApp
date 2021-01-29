using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ImageAdress { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }
        public double Discount { get; set; }
        public string ProductInfos { get; set; }

        
        //each product has a category
        public Category Category { get; set; }

        //for use as fereignKey
        public int CategoryId { get; set; }

        //each product has a brand
        public Brand Brands { get; set; }

        //for use as fereignKey
        public int BrandsId { get; set; }
    }

}
