using AutoMapper;
using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Category;
using FVenue.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FVenue.API.Controllers
{
    [Route("API/[controller]")]
    [ApiController]
    public class CategoriesAPIController : ControllerBase
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public CategoriesAPIController(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet, Route("GetCategoryDTOs")]
        public async Task<ActionResult<JsonModel>> GetCategoryDTOs()
        {
            try
            {
                var category = await _context.Categories.ToListAsync();
                var categoryDTOs = _mapper.Map<List<Category>, List<CategoryDTO>>(category);
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = $"{category.Count} categories",
                    Data = categoryDTOs
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
