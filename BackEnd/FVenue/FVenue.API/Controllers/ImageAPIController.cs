using DTOs.Repositories.Interfaces;
using DTOs.Repositories.Services;
using Microsoft.AspNetCore.Mvc;

namespace FVenue.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageAPIController : ControllerBase
    {
        private readonly IImageService _imageService;

        public ImageAPIController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [HttpPost, Route("UploadImage")]
        public IActionResult UploadImage([FromForm] IFormFile uFile)
        {
            ResponseModel response = _imageService.UploadImage(uFile);
            return StatusCode((int)response.Code, new { response.Message, response.Data });
        }
    }
}
