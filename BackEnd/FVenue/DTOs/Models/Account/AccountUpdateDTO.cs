using System.ComponentModel;

namespace DTOs.Models.Account
{
    public class AccountUpdateDTO
    {
        public int Id { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }
        public string CreateDate { get; set; }
        public string LastUpdateDate { get; set; }
        public bool Status { get; set; }
        public string RoleName { get; set; }
        [DisplayName("Tên")]
        public string FirstName { get; set; }
        [DisplayName("Họ")]
        public string LastName { get; set; }
        public string FullName { get; set; }
        [DisplayName("Giới tính")]
        public bool? Gender { get; set; }
        [DisplayName("Ngày sinh")]
        public DateTime? BirthDay { get; set; }
        public int LoginMethod { get; set; }
        public bool IsEmailConfirmed { get; set; }
    }
}
