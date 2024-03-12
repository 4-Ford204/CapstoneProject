using DTOs.Models.Payment;

namespace DTOs.Repositories.Interfaces
{
    public interface IPaymentService
    {
        string GetVNPAYRequestURL(VNPAYPaymentRequestDTO vnpayPaymentRequestDTO);
    }
}
