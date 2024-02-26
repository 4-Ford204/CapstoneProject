using DTOs.Repositories.Interfaces;
using System.Net.Mail;
using System.Net;
using Microsoft.Extensions.Configuration;
using System.Text;
using BusinessObjects;
using System.Diagnostics;

namespace DTOs.Repositories.Services
{
    public class EmailService : IEmailService
    {
        private readonly string host;
        private readonly string server;
        private readonly int port;
        private readonly string emailHost;
        private readonly string appPassword;
        private readonly string userHost;
        private readonly string routeRegisterConfirmationEmailSuccess;
        private readonly string routeRegisterConfirmationEmailError;

        public EmailService(IConfiguration configuration)
        {
            host = configuration["Host"];
            server = configuration["Email:Server"];
            port = Int32.Parse(configuration["Email:Port"]);
            emailHost = configuration["Email:Host"];
            appPassword = configuration["Email:AppPassword"];
            userHost = configuration["UserSite:UserHost"];
            routeRegisterConfirmationEmailSuccess = configuration["UserSite:RouteRegisterConfirmationEmailSuccess"];
            routeRegisterConfirmationEmailError = configuration["UserSite:RouteRegisterConfirmationEmailError"];
        }

        public async Task<KeyValuePair<bool, string>> SendRegisterConfirmationEmail(string toEmail)
        {
            try
            {
                bool result = false;
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(emailHost);
                    mailMessage.To.Add(toEmail);
                    mailMessage.Subject = "Xác Nhận Gmail Đăng Nhập";
                    mailMessage.SubjectEncoding = Encoding.UTF8;
                    string redirectURL = $"{host}/API/AccountsAPI/RegisterConfirmationHandler/{toEmail}";
                    mailMessage.Body = Common.GetEmailConfirmation(redirectURL);
                    mailMessage.BodyEncoding = Encoding.UTF8;
                    mailMessage.IsBodyHtml = true;

                    using (SmtpClient smtpClient = new SmtpClient(server, port))
                    {
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new NetworkCredential(emailHost, appPassword);
                        smtpClient.EnableSsl = true;
                        smtpClient.SendCompleted += (sender, e) =>
                        {
                            smtpClient.Dispose();
                            mailMessage.Dispose();
                            result = true;
                        };
                        await smtpClient.SendMailAsync(mailMessage);
                    }
                }
                if (result)
                    return new KeyValuePair<bool, string>(true, "Email Sent");
                else
                    return new KeyValuePair<bool, string>(false, "Email Sent Error");
            }
            catch (Exception ex)
            {
                return new KeyValuePair<bool, string>(false, ex.Message);
            }
        }

        public KeyValuePair<bool, string> AcceptRegisterConfirmationEmail(string email)
        {
            try
            {
                using (var _context = new DatabaseContext())
                {
                    var account = _context.Accounts.FirstOrDefault(x => x.Email == email);
                    if (account == null)
                        throw new Exception("Account Not Found");
                    account.IsEmailConfirmed = true;
                    _context.Entry(account).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    if (_context.SaveChanges() != 1)
                        throw new Exception("Save Changes Error");
                    Process.Start(new ProcessStartInfo($"{userHost}/{routeRegisterConfirmationEmailSuccess}") { UseShellExecute = true });
                    return new KeyValuePair<bool, string>(true, $"{email} Was Confirmed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Process.Start(new ProcessStartInfo($"{userHost}/{routeRegisterConfirmationEmailError}") { UseShellExecute = true });
                return new KeyValuePair<bool, string>(false, ex.Message);
            }
        }
    }
}
