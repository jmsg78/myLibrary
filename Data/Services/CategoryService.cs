using System.Collections.Generic;
using System.Linq;

namespace MyLibrary.Data
{
    public class CategoryService : LibraryContext, ICategoryService
    {
        LibraryContext ctx = new LibraryContext();
        public void AddCategory(Category newCategory)
        {
            //Data.Categories.Add(newCategory);

            ctx.Categories.Add(newCategory);
            ctx.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            var category = ctx.Categories.FirstOrDefault(n => n.Id == id);
            ctx.Categories.Remove(category);
            ctx.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            return ctx.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return ctx.Categories.FirstOrDefault(n => n.Id == id);
        }

        public void UpdateCategory(int id, Category newCategory)
        {
            var oldCategory = ctx.Categories.FirstOrDefault(n => n.Id == id);
            if(oldCategory != null)
            {
                oldCategory.Name = newCategory.Name;
                oldCategory.Description = newCategory.Description;
            }
            ctx.SaveChanges();
        }
  }
}