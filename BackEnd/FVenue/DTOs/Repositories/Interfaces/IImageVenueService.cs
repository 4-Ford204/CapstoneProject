using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Repositories.Interfaces
{
    public interface  IImageVenueService
    {
     Task<bool> UploadImange(IFormFile ufile);
    }
}
