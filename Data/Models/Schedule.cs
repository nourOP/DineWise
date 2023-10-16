namespace DineWise.Data.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public DayOfWeek WeekDay { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
