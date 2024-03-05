using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Repositories.Interfaces;

namespace DTOs.Repositories.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        public List<SubCategory> GetSubCategories()
        {
            using (var _context = new DatabaseContext())
            {
                var subcategories = _context.SubCategories.ToList();
                return subcategories;
            }
        }

        public SubCategory GetSubCategory(int id)
        {
            using (var _context = new DatabaseContext())
            {
                var subcategory = _context.SubCategories.Find(id);
                return subcategory;
            }
        }

        public int GetSubCategoryActiveNumber(int id)
        {
            using (var _context = new DatabaseContext())
            {
                var subCategoryNumber = _context.SubCategories.Where(x => x.CategoryId == id && x.Status).Count();
                return subCategoryNumber;
            };
        }

        public int GetSubCategoryInactiveNumber(int id)
        {
            using (var _context = new DatabaseContext())
            {
                var subCategoryNumber = _context.SubCategories.Where(x => x.CategoryId == id && !x.Status).Count();
                return subCategoryNumber;
            };
        }

        public int GetVenueActiveNumber(int id)
        {
            using (var _context = new DatabaseContext())
            {
                var venueNumber = _context.VenueSubCategories.Where(x => x.SubCategoryId == id && x.Status).Count();
                return venueNumber;
            };
        }

        public int GetVenueInactiveNumber(int id)
        {
            using (var _context = new DatabaseContext())
            {
                var venueNumber = _context.VenueSubCategories.Where(x => x.SubCategoryId == id && !x.Status).Count();
                return venueNumber;
            };
        }

        /// <summary>
        /// Đưa ra danh sách các yêu cầu tạo mới phân loại phụ chưa được duyệt
        /// </summary>
        /// <returns></returns>
        public List<SubCategoryRequest> GetPendingSubCategoryRequests()
        {
            using (var _context = new DatabaseContext())
            {
                var subCategoryRequests = _context.SubCategoryRequests
                    .OrderBy(x => x.CreateDate)
                    .Where(x => x.AdministratorId == 0 && x.Status == (int)EnumModel.SubCategoryRequestStatus.Pending)
                    .ToList();
                return subCategoryRequests;
            };
        }
    }
}
