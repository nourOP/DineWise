namespace DineWise.Data.Models
{
    
    public class Schedule
    {
        public int Id { get; set; }
        public List<DayOfWeek> WeekDays { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
