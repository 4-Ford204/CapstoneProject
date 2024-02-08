using AutoMapper;
using BusinessObjects;
using DTOs.Models.Category;
using DTOs.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    [AdministratorAuthentication]
    public class CategoriesController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;

        public CategoriesController(
            DatabaseContext context,
            IMapper mapper,
            ICategoryService categoryService,
            ISubCategoryService subCategoryService)
        {
            _context = context;
            _mapper = mapper;
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
        }

        #region View

        public IActionResult Index() => View();

        #endregion

        #region Data

        [HttpGet, Route("Categories/GetCategoryAdminDTOs")]
        public List<CategoryAdminDTO> GetCategoryAdminDTOs()
        {
            var result = _context.Categories.Select(x => new CategoryAdminDTO
            {
                Id = x.Id,
                Name = x.Name,
                SubCategoryNumber = _subCategoryService.GetSubCategoryNumber(x.Id),
                VenueNumber = _categoryService.GetVenueNumber(x.Id)
            })
                .ToList();
            return result;
        }

        #endregion
    }
}
