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

        /// <summary>
        /// Đưa ra danh sách các yêu cầu tạo mới phân loại phụ chưa được duyệt
        /// </summary>
        /// <returns></returns>
        public List<SubCategoryRequest> GetPendingSubCategoryRequests()
        {
            //using (var _context = new DatabaseContext())
            //{
            //    var subCategoryRequests = _context.SubCategoryRequests.OrderBy().Where(x => x.Status == ).ToList();
            //    return subCategoryRequests;
            //};
            return new List<SubCategoryRequest>()
            {
                new SubCategoryRequest()
                {
                    Id = 1,
                    Name = "Quán điện tử",
                    RequestUserId = 1,
                    CategoryId = 1,
                    AdministratorId = 0,
                    CreateDate = DateTime.Now.Subtract(TimeSpan.FromDays(2)),
                    LastUpdateDate = DateTime.Now,
                    Status = 1
                },
                new SubCategoryRequest()
                {
                    Id = 2,
                    Name = "Lounge",
                    RequestUserId = 4,
                    CategoryId = 4,
                    AdministratorId = 0,
                    CreateDate = DateTime.Now.Subtract(TimeSpan.FromDays(7)),
                    LastUpdateDate = DateTime.Now,
                    Status = 1
                },
                new SubCategoryRequest()
                {
                    Id = 3,
                    Name = "Sushi",
                    RequestUserId = 1,
                    CategoryId = 2,
                    AdministratorId = 1,
                    CreateDate = DateTime.Now.Subtract(TimeSpan.FromHours(5)),
                    LastUpdateDate = DateTime.Now,
                    Status = 1
                },
                new SubCategoryRequest()
                {
                    Id = 4,
                    Name = "Nước dừa",
                    RequestUserId = 1,
                    CategoryId = 3,
                    AdministratorId = 1,
                    CreateDate = DateTime.Now.Subtract(TimeSpan.FromDays(4)),
                    LastUpdateDate = DateTime.Now,
                    Status = 1
                },
                new SubCategoryRequest()
                {
                    Id = 5,
                    Name = "Đồ Bim nấu",
                    RequestUserId = 1,
                    CategoryId = 2,
                    AdministratorId = 1,
                    CreateDate = DateTime.Now.Subtract(TimeSpan.FromHours(2)),
                    LastUpdateDate = DateTime.Now,
                    Status = 1
                },
                new SubCategoryRequest()
                {
                    Id = 6,
                    Name = "Đồ Bim làm",
                    RequestUserId = 1,
                    CategoryId = 4,
                    AdministratorId = 1,
                    CreateDate = DateTime.Now.Subtract(TimeSpan.FromHours(2)),
                    LastUpdateDate = DateTime.Now,
                    Status = 1
                }
            };
        }
    }
}
