using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects.Models
{
    public class ScheduleDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
        [ForeignKey("Venue")]
        public int VenueId { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Venue Venue { get; set; }
        public int Type { get; set; }
        public int Ordinal { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Note { get; set; }
    }
}
