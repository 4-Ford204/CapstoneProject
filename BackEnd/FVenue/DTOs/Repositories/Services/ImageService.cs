using DTOs.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;

namespace DTOs.Repositories.Services
{
    public class ImageService : IImageService
    {
        private readonly string _imagePath = Environment.CurrentDirectory + @"Data\Image\Venues";

        public async Task<bool> UploadImage(IFormFile ufile)
        {
            try
            {
                if (ufile != null && ufile.Length > 0)
                {
                    var fileName = Path.GetFileName(ufile.FileName);
                    var filePath = Path.Combine(_imagePath, fileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Open))
                    {
                        await ufile.CopyToAsync(fileStream);
                    }
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
