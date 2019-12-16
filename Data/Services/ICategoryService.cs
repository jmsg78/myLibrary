using System.Collections.Generic;
using MyLibrary.Data;

namespace MyLibrary.Data
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void UpdateCategory(int id, Category newCategory);
        void DeleteCategory(int id);
        void AddCategory(Category newCategory);
    }
}