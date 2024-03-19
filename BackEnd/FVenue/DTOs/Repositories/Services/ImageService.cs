using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using DTOs.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net;
using BusinessObjects;

namespace DTOs.Repositories.Services
{
    public class ImageService : IImageService
    {
        private readonly Account account;

        public ImageService(IConfiguration configuration)
        {
            account = new Account(
                 configuration.GetSection("Cloudinary")["CloudName"],
                 configuration.GetSection("Cloudinary")["ApiKey"],
                 configuration.GetSection("Cloudinary")["ApiSerect"]
                );
        }

        public ResponseModel UploadImage(IFormFile uFile)
        {
            try
            {
                var imageUploadResult = new Cloudinary(account).Upload(new ImageUploadParams()
                {
                    File = new FileDescription(uFile.FileName, uFile.OpenReadStream()),
                    DisplayName = uFile.FileName
                }) ?? throw new Exception("Lỗi không xác định! Không thể nhận được kết quả từ Cloudinary");
                return new ResponseModel
                {
                    Code = (int)imageUploadResult.StatusCode,
                    Message = imageUploadResult.StatusCode != HttpStatusCode.OK ? imageUploadResult.Error.Message : "Tệp Tải Lên Thành Công",
                    Data = imageUploadResult.SecureUrl.ToString()
                };
            }
            catch (Exception ex)
            {
                return new ResponseModel
                {
                    Code = (int)EnumModel.ResultCode.InternalServerError,
                    Message = ex.Message,
                    Data = String.Empty
                };
            }
        }
    }

    public class ResponseModel
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
    }
}
