using AutoMapper;
using BusinessObjects;
using DTOs.Models.Account;
using DTOs.Repositories.Interfaces;
using FVenue.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FVenue.API.Controllers
{
    [Route("API/[controller]")]
    [ApiController]
    public class AccountsAPIController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAccountService _accountService;
        private readonly IEmailService _emailService;
        private readonly ITokenService _tokenService;
        private readonly string environment;

        public AccountsAPIController(
            IConfiguration configuration,
            IAccountService accountService,
            IEmailService emailService,
            ITokenService tokenService)
        {
            _accountService = accountService;
            _emailService = emailService;
            _tokenService = tokenService;
            environment = configuration["Environment"];
        }

        [Authorize(Roles = nameof(EnumModel.Role.Administrator))]
        [HttpGet, Route("GetAccountDTOs")]
        public ActionResult<JsonModel> GetAccountDTOs()
        {
            try
            {
                var accounts = _accountService.GetAccounts();
                /// <summary>
                /// Lỗi "Object reference not set to an instance of an object"
                /// </summary>
                // var accountDTOs = _mapper.Map<List<Account>, List<AccountDTO>>(accounts);
                var accountDTOs = accounts.Select(x => new AccountDTO
                {
                    Id = x.Id,
                    Email = x.Email,
                    Image = x.Image,
                    PhoneNumber = x.PhoneNumber,
                    CreateDate = Common.FormatDateTime(x.CreateDate),
                    LastUpdateDate = Common.FormatDateTime(x.LastUpdateDate),
                    Status = x.Status,
                    RoleName = Common.GetRoleName(x.RoleId),
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    FullName = x.FullName,
                    Gender = x.Gender,
                    BirthDay = Common.FormatDateTime(x.BirthDay),
                    LoginMethod = x.LoginMethod,
                    IsEmailConfirmed = x.IsEmailConfirmed
                })
                    .ToList();
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = $"{accounts.Count} accounts",
                    Data = accountDTOs
                };
            }
            catch (Exception ex)
            {
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"{ex.Message}"
                };
            }
        }

        [HttpGet("GetAccountDTO/{id}")]
        public ActionResult<JsonModel> GetAccountDTO([FromRoute] int id)
        {
            try
            {
                var account = _accountService.GetAccount(id);
                /// <summary>
                /// Lỗi "Object reference not set to an instance of an object"
                /// </summary>
                // var accountDTO = _mapper.Map<Account, AccountDTO>(account);
                var accountDTO = new AccountDTO()
                {
                    Id = account.Id,
                    Email = account.Email,
                    Image = account.Image,
                    PhoneNumber = account.PhoneNumber,
                    CreateDate = Common.FormatDateTime(account.CreateDate),
                    LastUpdateDate = Common.FormatDateTime(account.LastUpdateDate),
                    Status = account.Status,
                    RoleName = Common.GetRoleName(account.RoleId),
                    FirstName = account.FirstName,
                    LastName = account.LastName,
                    FullName = account.FullName,
                    Gender = account.Gender,
                    BirthDay = Common.FormatDateTime(account.BirthDay),
                    LoginMethod = account.LoginMethod,
                    IsEmailConfirmed = account.IsEmailConfirmed
                };
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = $"{account.FullName}'s Account",
                    Data = accountDTO
                };
            }
            catch (Exception ex)
            {
                return new JsonModel
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"{ex.Message}"
                };
            }
        }

        [HttpPost, Route("Registration")]
        public ActionResult<JsonModel> Registration([FromBody] AccountInsertDTO accountInsertDTO)
        {
            if (!ModelState.IsValid)
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.BadRequest,
                    Message = $"Registration Error",
                    Data = accountInsertDTO
                };
            var result = _accountService.Registration(accountInsertDTO);
            if (result.Key)
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = $"Registration Success",
                    Data = accountInsertDTO
                };
            else
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = $"Registration Error",
                    Data = result.Value
                };
        }

        [HttpGet, Route("RegisterConfirmation/{toEmail}")]
        public async Task<JsonModel> RegisterConfirmation(string toEmail)
        {
            var result = await _emailService.SendRegisterConfirmationEmail(toEmail);
            if (result.Key)
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = result.Value
                };
            else
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = result.Value
                };
        }

        [HttpGet, Route("RegisterConfirmationHandler/{email}")]
        public JsonModel RegisterConfirmationHandler(string email)
        {
            var result = _emailService.AcceptRegisterConfirmationEmail(email);
            if (result.Key)
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.OK,
                    Message = result.Value
                };
            else
                return new JsonModel()
                {
                    Code = EnumModel.ResultCode.InternalServerError,
                    Message = result.Value
                };
        }

        [HttpGet, Route("GoogleRegistration")]
        public void GoogleRegistration()
        {
            var requestURL = _tokenService.GetGoogleRequestURL();
            if (string.IsNullOrEmpty(requestURL)) return;
            Process.Start(new ProcessStartInfo(requestURL) { UseShellExecute = true });
        }

        [HttpGet, Route("GoogleRegistrationHandler")]
        public async Task<dynamic> GoogleRegistrationHandler([FromQuery] string code)
        {
            var accessToken = await _tokenService.GetGoogleAccessToken(code);
            if (string.IsNullOrEmpty(accessToken))
                if (environment.Equals("Developing"))
                    return new JsonModel()
                    {
                        Code = EnumModel.ResultCode.InternalServerError,
                        Message = $"Access Token Error",
                        Data = code
                    };
                else
                    return "Access Token Error";
            else
            {
                var user = await _tokenService.GetGoogleUser(accessToken);
                if ((object)user != null)
                    if (environment.Equals("Developing"))
                        return new JsonModel()
                        {
                            Code = EnumModel.ResultCode.OK,
                            Message = $"Please close this window and return to application.",
                            Data = user
                        };
                    else
                        return "Please close this window and return to application.";
                else
                {
                    if (environment.Equals("Developing"))
                        return new JsonModel()
                        {
                            Code = EnumModel.ResultCode.InternalServerError,
                            Message = $"User Information Error",
                            Data = accessToken
                        };

                    else
                        return $"User Information Error";
                }
            }
        }

        [HttpPost, Route("Login")]
        public ActionResult<JsonModel> Login(AccountLoginDTO accountLoginDTO)
        {
            var account = _accountService.Login(accountLoginDTO, out string error);
            return new JsonModel
            {
                Code = EnumModel.ResultCode.OK,
                Message = String.IsNullOrEmpty(error) ? "Đăng Nhập Thành Công" : error,
                Data = new AccountTokenDTO
                {
                    Email = account.Email,
                    RoleName = Common.GetRoleName(account.RoleId),
                    FirstName = account.FirstName,
                    LastName = account.LastName,
                    Token = _tokenService.GetTokenAPI(account)
                }
            };
        }
    }
}
