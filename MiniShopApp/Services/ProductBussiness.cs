using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniShopApp.Models;
using MiniShopApp.Data;

namespace MiniShopApp.Services
{
    class ProductBussiness
    {
        miniShopDbContext db = new miniShopDbContext();
        public List<Product> GetProduct()
        {
            return db.Product.ToList();
        }

        public Product GetProductById(int Id)
        {
            return db.Product.Find(Id);
        }
        public void Add(Product product)
        {
            db.Product.Add(product);
            db.SaveChanges();
        }

        public void Remove(Product product)
        {
            db.Product.Remove(product);
            db.SaveChanges();
        }
        public void Edit(Product product)
        {
            db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
