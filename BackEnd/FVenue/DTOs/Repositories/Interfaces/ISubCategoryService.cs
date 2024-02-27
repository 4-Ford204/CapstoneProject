using BusinessObjects.Models;

namespace DTOs.Repositories.Interfaces
{
    public interface ISubCategoryService
    {
        int GetSubCategoryNumber(int id);
        int GetVenueNumber(int id);
        List<SubCategoryRequest> GetPendingSubCategoryRequests();
    }
}
