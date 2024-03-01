using BusinessObjects.Models;

namespace DTOs.Repositories.Interfaces
{
    public interface ISubCategoryService
    {
        List<SubCategory> GetSubCategories();
        SubCategory GetSubCategory(int id);
        int GetSubCategoryNumber(int id);
        int GetVenueNumber(int id);
        List<SubCategoryRequest> GetPendingSubCategoryRequests();
    }
}
