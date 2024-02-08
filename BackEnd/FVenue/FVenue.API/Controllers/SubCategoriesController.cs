using AutoMapper;
using BusinessObjects;
using DTOs.Models.SubCategory;
using DTOs.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    [AdministratorAuthentication]
    public class SubCategoriesController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoriesController(DatabaseContext context, IMapper mapper, ISubCategoryService subCategoryService)
        {
            _context = context;
            _mapper = mapper;
            _subCategoryService = subCategoryService;
        }

        #region View

        #endregion

        #region Data

        [HttpGet, Route("SubCategories/GetSubCategoryAdminDTOs")]
        public List<SubCategoryAdminDTO> GetSubCategoryAdminDTOs()
        {
            var result = _context.SubCategories.Select(x => new SubCategoryAdminDTO
            {
                Id = x.Id,
                Name = x.Name,
                CategoryId = x.CategoryId,
                VenueNumber = _subCategoryService.GetVenueNumber(x.Id)
            })
                .ToList();
            return result;
        }

        #endregion
    }
}
