using Microsoft.AspNetCore.Http;

namespace DTOs.Repositories.Interfaces
{
    public interface IImageService
    {
        Task<bool> UploadImage(IFormFile ufile);
    }
}
