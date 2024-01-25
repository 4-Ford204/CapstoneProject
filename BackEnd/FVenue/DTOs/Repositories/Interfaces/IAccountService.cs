using BusinessObjects.Models;
using DTOs.Models.Account;

namespace DTOs.Repositories.Interfaces
{
    public interface IAccountService
    {
        KeyValuePair<bool, string> Registration(AccountInsertDTO accountInsertDTO);

        Task<List<Account>> GetListAccounts();
    }
}
