using DTOs.Models;
using Microsoft.AspNetCore.Http;

namespace DTOs.Repositories.Interfaces
{
    public interface IImageService
    {
        string GetImagePath(IFormFile uFile);
        ResponseInfo UploadImage(IFormFile uFile);
    }
}
