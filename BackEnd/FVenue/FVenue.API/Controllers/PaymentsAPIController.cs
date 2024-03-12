using DTOs.Models.Payment;
using DTOs.Repositories.Interfaces;
using FVenue.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FVenue.API.Controllers
{
    [Route("API/[controller]")]
    [ApiController]
    public class PaymentsAPIController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentsAPIController(IConfiguration configuration, IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost, Route("PaymentTransaction")]
        public void PaymentTransaction([FromBody] VNPAYPaymentRequestDTO vnpayPaymentRequestDTO)
        {
            if (String.IsNullOrEmpty(vnpayPaymentRequestDTO.IPAdress))
                vnpayPaymentRequestDTO.IPAdress = HttpContext.Connection.RemoteIpAddress.ToString();
            string vnpayRequestURL = _paymentService.GetVNPAYRequestURL(vnpayPaymentRequestDTO);
            Process.Start(new ProcessStartInfo(vnpayRequestURL) { UseShellExecute = true });
        }

        [HttpGet, Route("PaymentTransactionHandler")]
        public JsonModel PaymentTransactionHandler()
        {
            return new JsonModel()
            {
                Code = BusinessObjects.EnumModel.ResultCode.OK,
                Message = "",
                Data = Request.QueryString
            };
        }
    }
}
