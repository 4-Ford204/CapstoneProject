using BusinessObjects;
using BusinessObjects.Models;
using DTOs.Models.Account;
using DTOs.Repositories.Interfaces;

namespace DTOs.Repositories.Services
{
    public class AccountService : IAccountService
    {
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
                    CreatDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now,
                    Status = true,
                    RoleId = accountInsertDTO.RoleId,
                    FirstName = accountInsertDTO.FirstName,
                    LastName = accountInsertDTO.LastName,
                    Gender = accountInsertDTO.Gender,
                    BirthDay = accountInsertDTO.BirthDay,
                    LoginVia = (int)EnumModel.LoginVia.Email
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
