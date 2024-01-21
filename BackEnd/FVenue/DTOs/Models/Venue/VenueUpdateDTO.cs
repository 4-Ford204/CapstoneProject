using System.ComponentModel.DataAnnotations;

namespace DTOs.Models.Venue
{
    public class VenueUpdateDTO : VenueInsertDTO
    {
        [Required]
        public int Id { get; set; }
    }
}