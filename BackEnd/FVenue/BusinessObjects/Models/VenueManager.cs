using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects.Models
{
    public class VenueManager
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public bool Status { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public int IsAuthenticated { get; set; }
        public string Name { get; set; }
        [ForeignKey("Venue")]
        public int VenueId { get; set; }
        public Venue Venue { get; set; }
    }
}