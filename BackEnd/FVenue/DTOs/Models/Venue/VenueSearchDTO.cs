namespace DTOs.Models.Venue
{
    public class VenueSearchDTO
    {
        public int PageIndex { get; set; } = 0;
        public int PageSize { get; set; } = 0;
        public string GeoLocation { get; set; }
        public float? LowerPrice { get; set; }
        public float? UpperPrice { get; set; }
    }
}
