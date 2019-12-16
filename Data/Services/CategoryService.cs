using System.Collections.Generic;
using System.Linq;

namespace MyLibrary.Data
{
    public class CategoryService : ICategoryService
    {
        public void AddCategory(Category newCategory)
        {
            Data.Categories.Add(newCategory);
        }

        public void DeleteCategory(int id)
        {
            var category = Data.Categories.FirstOrDefault(n => n.Id == id);
            Data.Categories.Remove(category);
        }

        public List<Category> GetAllCategories()
        {
            return Data.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return Data.Categories.FirstOrDefault(n => n.Id == id);
        }

        public void UpdateCategory(int id, Category newCategory)
        {
            var oldCategory = Data.Categories.FirstOrDefault(n => n.Id == id);
            if(oldCategory != null)
            {
                oldCategory.Name = newCategory.Name;
                oldCategory.Description = newCategory.Description;
            }
        }
  }
}