using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Category;
using DTOs.Repositories.Interfaces;
using FVenue.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FVenue.API.Controllers
{
    public class ViewCategoryController : ControllerBase
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        private readonly IValidationService _validationService;
        public ViewCategoryController(DatabaseContext context, IMapper mapper, IValidationService validationService)
        {
            _context = context;
            _mapper = mapper;
            _validationService = validationService;
        }
        [HttpGet, Route("GetCategoryDTOs/{pageIndex}/{pageSize}")]
        public async Task<ActionResult<JsonModel>> GetCategoryDTOs(int pageIndex, int pageSize)
        {
            try
            {
                var category = await _context.Categories.ToListAsync();
                var categoryDTOs = _mapper.Map<List<Category>, List<CategoryDTO>>(category);
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = $"{category.Count} category",
                    Data = new PaginationModel<CategoryDTO>(categoryDTOs, pageIndex, pageSize)
                };
            }
            catch (Exception ex)
            {
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"{ex.Message}"
                };
            }
        }
    }
}
