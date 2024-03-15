using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Payment;
using DTOs.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace DTOs.Repositories.Services
{
    public class PaymentService : IPaymentService
    {
        /*
         * VNP_URL: URL thanh toán của VNPAY.
         * VNP_Version: Phiên bản API của VNPAY mà merchant kết nối.
         * VNP_TmnCode: Mã website của merchant trên hệ thống của VNPAY. Ví dụ: 2QXUI4J4.
         * VNP_ReturnURL: URL nhận kết quả trả về từ VNPAY khi kết thúc thanh toán. Ví dụ: https://domain.vn/VnPayReturn .
         * VNP_HashSecret: Chuỗi bí mật giữa VNPAY và merchant.
         */
        private readonly string VNP_URL;
        private readonly string VNP_Version;
        private readonly string VNP_Command;
        private readonly string VNP_TmnCode;
        private readonly string VNP_ReturnURL;
        private readonly string VNP_HashSecret;

        public PaymentService(IConfiguration configuration)
        {
            VNP_URL = configuration["VNPAY:VNP_URL"];
            VNP_Version = configuration["VNPAY:VNP_Version"];
            VNP_Command = configuration["VNPAY:VNP_Command"];
            VNP_TmnCode = configuration["VNPAY:VNP_TmnCode"];
            VNP_ReturnURL = configuration["VNPAY:VNP_ReturnURL"];
            VNP_HashSecret = configuration["VNPAY:VNP_HashSecret"];
        }

        public string GetVNPAYRequestURL(VNPAYPaymentRequestDTO vnpayPaymentRequestDTO)
        {
            DateTime transactionDate = DateTime.Now;
            VNPAYPaymentDTO vnpayPaymentDTO = new VNPAYPaymentDTO()
            {
                UserId = vnpayPaymentRequestDTO.UserId,
                PaymentId = transactionDate.Ticks,
                Amount = vnpayPaymentRequestDTO.Amount,
                BankCode = vnpayPaymentRequestDTO.BankCode,
                Content = vnpayPaymentRequestDTO.Content,
                Status = (int)EnumModel.PaymentStatus.Pending,
                CreateDate = DateTime.Now,
                IPAdress = vnpayPaymentRequestDTO.IPAdress,
                Locale = vnpayPaymentRequestDTO.Locale
            };
            using (var _context = new DatabaseContext())
            {
                try
                {
                    _context.VNPAYPayments.Add(new VNPAYPayment()
                    {
                        UserId = vnpayPaymentDTO.UserId,
                        PaymentId = vnpayPaymentDTO.PaymentId,
                        Amount = vnpayPaymentRequestDTO.Amount,
                        Content = vnpayPaymentRequestDTO.Content,
                        Status = vnpayPaymentDTO.Status,
                        CreateDate = vnpayPaymentDTO.CreateDate
                    });
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            // Build VNPAY's URL
            VNPAYLibrary vnpay = new VNPAYLibrary();
            vnpay.AddRequestParameter("vnp_Version", VNP_Version);
            vnpay.AddRequestParameter("vnp_Command", VNP_Command);
            vnpay.AddRequestParameter("vnp_TmnCode", VNP_TmnCode);
            vnpay.AddRequestParameter("vnp_Amount", (vnpayPaymentDTO.Amount * 100).ToString());
            //vnpay.AddRequestParameter("vnp_BankCode", vnpayPaymentDTO.BankCode);
            vnpay.AddRequestParameter("vnp_CreateDate", vnpayPaymentDTO.CreateDate.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestParameter("vnp_CurrCode", "VND");
            vnpay.AddRequestParameter("vnp_IpAddr", vnpayPaymentDTO.IPAdress);
            vnpay.AddRequestParameter("vnp_Locale", vnpayPaymentDTO.Locale);
            vnpay.AddRequestParameter("vnp_OrderInfo", vnpayPaymentDTO.Content);
            //vnpay.AddRequestParameter("vnp_OrderInfo", $"Người dùng {vnpayPaymentDTO.UserId} thanh toán {vnpayPaymentDTO.Amount}VND vào {Common.FormatDateTime(transactionDate)}");
            vnpay.AddRequestParameter("vnp_OrderType", "other");
            vnpay.AddRequestParameter("vnp_ReturnUrl", VNP_ReturnURL);
            vnpay.AddRequestParameter("vnp_TxnRef", vnpayPaymentDTO.PaymentId.ToString());
            return vnpay.GetVNPAYRequestURL(VNP_URL, VNP_HashSecret);
        }

        public string UpdateVNPAYPayment(List<KeyValuePair<string, StringValues>> responseParameters)
        {
            try
            {
                VNPAYLibrary vnpay = new VNPAYLibrary();
                foreach (var responseParameter in responseParameters)
                    vnpay.AddResponseParameter(responseParameter.Key, responseParameter.Value);
                using (var _context = new DatabaseContext())
                {
                    var vnpayPayment = _context.VNPAYPayments
                        .FirstOrDefault(x => x.PaymentId == Convert.ToInt64(vnpay.GetResponseParameter("vnp_TxnRef")));
                    if (vnpayPayment == null)
                        throw new Exception("VNPAYPayment Not Found");
                    if (vnpay.ValidateSignature(vnpay.GetResponseParameter("vnp_SecureHash"), VNP_HashSecret))
                    {
                        if (vnpay.GetResponseParameter("vnp_ResponseCode") == "00" && vnpay.GetResponseParameter("vnp_TransactionStatus") == "00")
                        {
                            vnpayPayment.Status = (int)EnumModel.PaymentStatus.Success;
                            if (_context.SaveChanges() != 1)
                                throw new Exception("Save Changes Error");
                            return "Giao Dịch Thành Công";
                        }
                        else
                        {
                            vnpayPayment.Status = (int)EnumModel.PaymentStatus.Failure;
                            if (_context.SaveChanges() != 1)
                                throw new Exception("Save Changes Error");
                            return Common.GetVNP_Response(vnpay.GetResponseParameter("vnp_ResponseCode"));
                        }
                    }
                    else
                        throw new Exception("Invalid Signature");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
