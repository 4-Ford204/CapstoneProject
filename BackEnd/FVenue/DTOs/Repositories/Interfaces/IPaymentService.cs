using DTOs.Models.Payment;
using Microsoft.Extensions.Primitives;

namespace DTOs.Repositories.Interfaces
{
    public interface IPaymentService
    {
        string GetVNPAYRequestURL(VNPAYPaymentRequestDTO vnpayPaymentRequestDTO);
        string UpdateVNPAYPayment(List<KeyValuePair<string, StringValues>> responseParameters);
    }
}
