using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using DTOs.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using DTOs.Models;
using System.Net;

namespace DTOs.Repositories.Services
{
    public class ImageService : IImageService
    {
        private readonly string _imagePath = @"Data\Images\Venues";
        private readonly IConfiguration configuration;
        private readonly Account account;

        public ImageService(IConfiguration configuration)
        {
            this.configuration = configuration;
            account = new Account(
                 configuration.GetSection("Cloudinary")["CloudName"],
                 configuration.GetSection("Cloudinary")["ApiKey"],
                 configuration.GetSection("Cloudinary")["ApiSerect"]
                );
        }



        public string GetImagePath(IFormFile uFile)
            => Path.Combine(_imagePath, uFile.FileName);

        //public bool UploadImage(IFormFile uFile, string filePath)
        //{
        //    try
        //    {
        //        using var fileStream = new FileStream(Path.Combine(Environment.CurrentDirectory, filePath), FileMode.Create);
        //        uFile.CopyTo(fileStream);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return false;
        //    }
        //}
        public ResponseInfo UploadImage(IFormFile uFile)
        {
            
            
                var client = new Cloudinary(account);
                var imageuploadParams = new ImageUploadParams()
                {
                    File = new FileDescription(uFile.FileName, uFile.OpenReadStream()),
                    DisplayName = uFile.FileName
                };
                var uploadResult = client.Upload(imageuploadParams);
                if (uploadResult.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    return new ResponseInfo()
                    {
                        Code = (int)uploadResult.StatusCode,
                        Message = uploadResult.Error.Message
                    };
                }
                if (uploadResult == null)
                {
                    return new ResponseInfo()
                    {
                        Code = (int)HttpStatusCode.InternalServerError,
                        Message = "Loi khong xac dinh"
                    };
                }
                return new ResponseInfo()
                {
                    Code = (int)HttpStatusCode.OK,
                    Message = "Upload thanh cong",
                    Data = uploadResult.SecureUrl.ToString()
                };


        }
    }
}
