using DTOs.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;

namespace DTOs.Repositories.Services
{
    public class ImageService : IImageService
    {
        private readonly string _imagePath = @"Data\Images\Venues";

        public string GetImagePath(IFormFile uFile)
            => Path.Combine(_imagePath, uFile.FileName);

        public bool UploadImage(IFormFile uFile, string filePath)
        {
            try
            {
                using var fileStream = new FileStream(Path.Combine(Environment.CurrentDirectory, filePath), FileMode.Create);
                uFile.CopyTo(fileStream);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
