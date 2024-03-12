namespace DTOs.Models.Payment
{
    public class VNPAYPaymentRequestDTO
    {
        public int UserId { get; set; }
        public float Amount { get; set; }
        public string BankCode { get; set; }
        public string IPAdress { get; set; }
        public string Locale { get; set; }
    }
}
