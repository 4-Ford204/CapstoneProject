namespace DTOs.Models.Account
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool Status { get; set; }
        public string RoleName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool? Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public int LoginVia { get; set; }
        public bool IsEmailConfirmed { get; set; }
    }
}
