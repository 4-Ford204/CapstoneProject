using Microsoft.AspNetCore.Http;

namespace DTOs.Repositories.Interfaces
{
    public interface IImageService
    {
        string GetImagePath(IFormFile uFile);
        bool UploadImage(IFormFile uFile, string filePath);
    }
}
