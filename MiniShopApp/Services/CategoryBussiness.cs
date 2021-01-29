using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniShopApp.Models;
using MiniShopApp.Data;


namespace MiniShopApp.Services
{
    public class CategoryBussiness
    {
        miniShopDbContext db = new miniShopDbContext();
        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public Category GetCategoryById(int Id)
        {
            return db.Categories.Find(Id);
        }
        public void Add(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void Remove(Category category)
        {
            db.Categories.Remove(category);
            db.SaveChanges();
        }
        public void Edit(Category category)
        {
            db.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
