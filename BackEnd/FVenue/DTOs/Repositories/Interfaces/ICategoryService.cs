using BusinessObjects.Models;

namespace DTOs.Repositories.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category GetCategory(int id);
        int GetVenueActiveNumber(int id);
        int GetVenueInactiveNumber(int id);
        string GetCategoryName(int id);
    }
}
