using ProductsApi.Models;

namespace ProductsApi.Repository
{
    public interface ICatagoryRepository
    {
        IEnumerable<Category> GetCategory();

        Category GetCategoryByID(int Category);

        void InsertCategory(Category Category);

        void DeleteCategory(int CategoryId);

        void UpdateCategory(Category Category);

        void Save();
    }
}
