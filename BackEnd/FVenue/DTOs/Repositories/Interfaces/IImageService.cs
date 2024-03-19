using DTOs.Repositories.Services;
using Microsoft.AspNetCore.Http;

namespace DTOs.Repositories.Interfaces
{
    public interface IImageService
    {
        ResponseModel UploadImage(IFormFile uFile);
    }
}
