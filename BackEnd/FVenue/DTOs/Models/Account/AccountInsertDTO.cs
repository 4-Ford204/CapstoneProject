using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DTOs.Models.Account
{
    public class AccountInsertDTO
    {
        [DisplayName("Email")]
        [Required]
        public string Email { get; set; }
        [DisplayName("Mật khẩu")]
        [Required]
        public string Password { get; set; }
        [DisplayName("Ảnh")]
        public IFormFile Image { get; set; }
        [DisplayName("Đường Dẫn Của Ảnh")]
        public string ImageURL { get; set; }
        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("Vai trò")]
        public int RoleId { get; set; }
        [DisplayName("Tên")]
        public string FirstName { get; set; }
        [DisplayName("Họ")]
        public string LastName { get; set; }
        public string FullName { get; set; }
        [DisplayName("Giới tính")]
        public bool? Gender { get; set; }
        [DisplayName("Ngày sinh")]
        public DateTime? BirthDay { get; set; }
        public int? LoginMethod { get; set; }
        public bool IsEmailConfirmed { get; set; }
    }
}
