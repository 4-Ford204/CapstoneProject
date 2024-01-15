namespace DTOs.Models.Account
{
    public class AccountInsertDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        //public string Image { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDay { get; set; }
    }
}
