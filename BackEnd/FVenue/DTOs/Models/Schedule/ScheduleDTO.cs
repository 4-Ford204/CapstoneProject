namespace DTOs.Models.Schedule
{
    public class ScheduleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string AccountName { get; set; }
        public bool IsPublic { get; set; }
        public bool Status { get; set; }
    }
}
