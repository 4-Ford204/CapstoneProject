using BusinessObjects.Models;

namespace DTOs.Repositories.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategory(int id);
        int GetVenueNumber(int id);
        string GetCategoryName(int id);
    }
}
