using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Repositories.Interfaces;

namespace DTOs.Repositories.Services
{
    public class CategoryService : ICategoryService
    {
        public List<Category> GetCategories()
        {
            using (var _context = new DatabaseContext())
            {

                var categories = _context.Categories.ToList();
                return categories;
            }
        }
    }
}
