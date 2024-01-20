namespace DTOs.Repositories.Interfaces
{
    public interface IEmailService
    {
        Task<KeyValuePair<bool, string>> SendRegisterConfirmationEmail(string toEmail);
        KeyValuePair<bool, string> AcceptRegisterConfirmationEmail(string email);
    }
}
