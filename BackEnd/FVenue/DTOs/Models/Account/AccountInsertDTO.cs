using System.ComponentModel.DataAnnotations;

namespace DTOs.Models.Account
{
    public class AccountInsertDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Image { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public int? LoginMethod { get; set; }
        public bool IsEmailConfirmed { get; set; }
    }
}
