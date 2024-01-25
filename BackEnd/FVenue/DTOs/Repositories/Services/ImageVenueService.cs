using DTOs.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;


namespace DTOs.Repositories.Services
{
    public class ImageVenueService : IImageVenueService
    {
        public async Task<bool> UploadImange (IFormFile ufile)
        {
            if (ufile != null && ufile.Length > 0)
            {
                var fileName = Path.GetFileName(ufile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Image\Venues", fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ufile.CopyToAsync(fileStream);
                }
                return true;
            }
            return false;
        }
    }
}
