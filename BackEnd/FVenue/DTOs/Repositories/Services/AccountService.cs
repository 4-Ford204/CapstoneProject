using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Account;
using DTOs.Repositories.Interfaces;

namespace DTOs.Repositories.Services
{
    public class AccountService : IAccountService
    {
        public Account Login(AccountLoginDTO accountLoginDTO, out string error)
        {
            error = string.Empty;
            using (var _context = new DatabaseContext())
            {
                var account = _context.Accounts.FirstOrDefault(x => x.Email == accountLoginDTO.Email);
                if (account == null)
                    error = "Tài khoản không tồn tại";
                else
                {
                    if (Common.VerifyPassword(accountLoginDTO.Password, account.HashPassword, account.SaltPassword))
                        return account;
                    else
                        error = "Tài khoản hoặc mật khẩu không chính xác";
                }
            }
            return null;
        }

        public List<Account> GetAccounts()
        {
            using (var _context = new DatabaseContext())
            {
                var accounts = _context.Accounts.ToList();
                return accounts;
            }
        }

        public List<Account> GetAdministrators()
        {
            using (var _context = new DatabaseContext())
            {
                var accounts = _context.Accounts.Where(x => x.RoleId == (int)EnumModel.Role.Administrator).ToList();
                return accounts;
            }
        }

        public string GetAccountName(int id)
        {
            try
            {
                using (var _context = new DatabaseContext())
                {
                    var name = _context.Accounts.Where(x => x.Id == id).Select(x => $"{x.FirstName} {x.LastName}").FirstOrDefault();
                    return name;
                }
            }
            catch (Exception ex)
            {
                return $"{ex.Message}";
            }
        }

        public KeyValuePair<bool, string> Registration(AccountInsertDTO accountInsertDTO)
        {
            try
            {
                byte[] saltPassword;
                string hashPassword = Common.HashPassword(accountInsertDTO.Password, out saltPassword);
                var account = new Account
                {
                    Email = accountInsertDTO.Email,
                    SaltPassword = saltPassword,
                    HashPassword = hashPassword,
                    PhoneNumber = accountInsertDTO.PhoneNumber,
                    CreateDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    Status = true,
                    RoleId = accountInsertDTO.RoleId,
                    FirstName = accountInsertDTO.FirstName,
                    LastName = accountInsertDTO.LastName,
                    Gender = accountInsertDTO.Gender,
                    BirthDay = accountInsertDTO.BirthDay,
                    LoginMethod = (int)EnumModel.LoginMethod.Email,
                    IsEmailConfirmed = false
                };

                using (var _context = new DatabaseContext())
                {
                    _context.Accounts.Add(account);
                    if (_context.SaveChanges() != 1)
                        throw new Exception("Save Changes Error");
                    else
                        return new KeyValuePair<bool, string>(true, String.Empty);
                }
            }
            catch (Exception ex)
            {
                return new KeyValuePair<bool, string>(false, ex.Message);
            }
        }
    }
}
