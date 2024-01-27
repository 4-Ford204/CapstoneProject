using DTOs.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;

namespace DTOs.Repositories.Services
{
    public class ImageService : IImageService
    {
        private readonly string _imagePath = Environment.CurrentDirectory + @"\Data\Images\Venues";

        public string GetImagePath(IFormFile uFile)
            => _imagePath;

        public bool UploadImage(IFormFile uFile, string filePath)
        {
            //try
            //{
            using var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Write);
            uFile.CopyTo(fileStream);
            return true;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return false;
            //}
        }
    }
}
