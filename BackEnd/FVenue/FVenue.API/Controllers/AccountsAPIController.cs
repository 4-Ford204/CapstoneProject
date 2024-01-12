using DTOs.Repositories.Interfaces;
using FVenue.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FVenue.API.Controllers
{
    [Route("API/[controller]")]
    [ApiController]
    public class AccountsAPIController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public AccountsAPIController(IConfiguration configuration, ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpGet, Route("GoogleRegistration")]
        public void GoogleRegistration()
        {
            var requestURL = _tokenService.GetGoogleRequestURL();
            if (string.IsNullOrEmpty(requestURL)) return;
            Process.Start(new ProcessStartInfo(requestURL) { UseShellExecute = true });
        }

        [HttpGet, Route("GoogleRegistrationHandler")]
        public async Task<JsonModel> GoogleRegistrationHandler([FromQuery] string code)
        {
            var accessToken = await _tokenService.GetGoogleAccessToken(code);
            if (string.IsNullOrEmpty(accessToken))
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"Access Token Error",
                    Data = code
                };
            else
            {
                var user = await _tokenService.GetGoogleUser(accessToken);
                if (user != null)
                    return new JsonModel()
                    {
                        Code = EnumModel.ResultCode.OK,
                        Message = $"Please close this window and return to application.",
                        Data = user
                    };
                else
                    return new JsonModel()
                    {
                        Code = EnumModel.ResultCode.InternalServerError,
                        Message = $"User Information Error",
                        Data = accessToken
                    };
            }
        }
    }
}
