﻿using EcommerceApplication.DataContext;
using EcommerceApplication.Services.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using EcommerceApplication.Models;


namespace EcommerceApplication.Services.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly MyContext _db;

        public CategoryRepository(MyContext db)
        {
            _db = db;
        }

        public int Count()
        {
            return _db.Category.Count();
        }

        public void Delete(int id)
        {
            var category = GetById(id);
            if (category!=null)
            {
                _db.Category.Remove(category);
            }
        }

        public IEnumerable<Category> GetAll()
        {
            return _db.Category.Select(c => c);
        }

        public Category GetById(int id)
        {
            return _db.Category.FirstOrDefault(c => c.CategoryId == id);
        }

        public void Insert(Category cat)
        {
            _db.Category.Add(cat);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Category cat)
        {
            _db.Category.Update(cat);
        }
    }
}
