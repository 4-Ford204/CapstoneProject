using BusinessObjects;
using DTOs.Repositories.Interfaces;

namespace DTOs.Repositories.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        public int GetSubCategoryNumber(int id)
        {
            using (var _context = new DatabaseContext())
            {
                var subCategoryNumber = _context.SubCategories.Where(x => x.CategoryId == id).Count();
                return subCategoryNumber;
            };
        }

        public int GetVenueNumber(int id)
        {
            using (var _context = new DatabaseContext())
            {
                var venueNumber = _context.VenueSubCategories.Where(x => x.SubCategoryId == id).Count();
                return venueNumber;
            };
        }
    }
}
