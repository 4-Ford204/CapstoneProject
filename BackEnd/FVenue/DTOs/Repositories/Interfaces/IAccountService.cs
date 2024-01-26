using BusinessObjects.Models;
using DTOs.Models.Account;

namespace DTOs.Repositories.Interfaces
{
    public interface IAccountService
    {
        List<Account> GetAccounts();
        public List<Account> GetAdministrators();
        string GetAccountName(int id);
        KeyValuePair<bool, string> Registration(AccountInsertDTO accountInsertDTO);
    }
}
