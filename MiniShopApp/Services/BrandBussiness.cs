using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniShopApp.Models;
using MiniShopApp.Data;

namespace MiniShopApp.Services
{
    public class BrandBussiness
    {
        miniShopDbContext db = new miniShopDbContext();
        public List<Brand> GetBrands()
        {
            return db.Brands.ToList();
        }
        public Brand GetBrandById(int Id)
        {
            return db.Brands.Find(Id);
        }
        public void Add(Brand brand)
        {
            db.Brands.Add(brand);
            db.SaveChanges();
        }
        public void Remove(Brand brand)
        {
            db.Brands.Remove(brand);
            db.SaveChanges();
        }
        public void Edit(Brand brand)
        {
            db.Entry(brand).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
