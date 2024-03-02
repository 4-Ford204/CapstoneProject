using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.SubCategory;
using DTOs.Models.SubCategoryRequest;
using DTOs.Repositories.Interfaces;
using FVenue.API.Models;
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

        [HttpGet, Route("SubCategories/SubCategoryRequestTable/{page}")]
        public PartialViewResult SubCategoryRequestTable([FromRoute] int page)
        {
            // Số Lượng SubCategoryRequest Trong 1 Trang
            var size = 5;
            var paginationModel = new PaginationModel<SubCategoryRequestDTO>(_mapper.Map<List<SubCategoryRequest>, List<SubCategoryRequestDTO>>(_subCategoryService.GetPendingSubCategoryRequests()), page, size);
            SubCategoryRequestPaginationModel subCategoryRequestPaginationModel = new SubCategoryRequestPaginationModel()
            {
                FirstPage = Common.GetFirstPageInPagination(paginationModel.PageIndex, paginationModel.TotalPages < 4 ? paginationModel.TotalPages : 4, paginationModel.TotalPages),
                PageIndex = paginationModel.PageIndex,
                PageSize = paginationModel.PageSize,
                TotalPages = paginationModel.TotalPages,
                PaginationPage = paginationModel.TotalPages < 4 ? paginationModel.TotalPages : 4,
                SubCategoryRequestDTOs = paginationModel.Result
            };
            return PartialView("_SubCategoryRequestPartial", subCategoryRequestPaginationModel);
        }

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

        [HttpPost, Route("SubCategories/UpdateSubCategoryRequestStatus")]
        public List<SubCategoryRequestDTO> UpdateSubCategoryRequestStatus([FromBody] int[] ids, string status)
        {
            return new List<SubCategoryRequestDTO>();
        }

        #endregion
    }
}
