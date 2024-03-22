using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects.Models
{
    public class ScheduleDetail
    {
        public int Id { get; set; }
        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        [ForeignKey("Venue")]
        public int VenueId { get; set; }
        public Venue Venue { get; set; }
        public int Day { get; set; }
        public int Ordinal { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Note { get; set; }
    }
}
