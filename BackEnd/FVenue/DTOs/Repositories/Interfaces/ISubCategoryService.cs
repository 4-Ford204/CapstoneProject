using BusinessObjects.Models;

namespace DTOs.Repositories.Interfaces
{
    public interface ISubCategoryService
    {
        List<SubCategory> GetSubCategories();
        SubCategory GetSubCategory(int id);
        int GetSubCategoryActiveNumber(int id);
        int GetSubCategoryInactiveNumber(int id);
        int GetVenueActiveNumber(int id);
        int GetVenueInactiveNumber(int id);
        List<SubCategoryRequest> GetPendingSubCategoryRequests();
        List<String> GetSimilaritySubCategories(string name);
    }
}
