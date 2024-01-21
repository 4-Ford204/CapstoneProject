using System.ComponentModel.DataAnnotations;

namespace DTOs.Models.Venue
{
    public class VenueInsertDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int WardId { get; set; }
        [Required]
        public string GeoLocation { get; set; }
        [Required]
        public string OpenTime { get; set; }
        [Required]
        public string CloseTime { get; set; }
        [Required]
        public float LowerPrice { get; set; }
        [Required]
        public float UpperPrice { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
