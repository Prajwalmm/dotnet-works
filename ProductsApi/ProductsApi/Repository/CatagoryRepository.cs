using Microsoft.EntityFrameworkCore;
using ProductsApi.Data;
using ProductsApi.Models;

namespace ProductsApi.Repository
{
    public class CatagoryRepository : ICatagoryRepository
    {
        private readonly ProductContext _dbContext;

        public CatagoryRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
               }
        public void DeleteCategory(int CategoryId)
        {
            var Category = _dbContext.Products.Find(CategoryId);
            _dbContext.Products.Remove(Category);
            Save();

        }

        public Category GetCategoryByID(int CategoryId)
        {
            return _dbContext.Categories.Find(CategoryId);
        }

        public IEnumerable<Category> GetCategory()
        {
            return _dbContext.Categories.ToList();
               }
         public void InsertCategory(Category Category)
        {
            _dbContext.Add(Category);
                  Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _dbContext.Entry(category).State = EntityState.Modified;

            Save();

        }

    }
}
