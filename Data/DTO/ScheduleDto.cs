namespace DineWise.Data.DTO
{
    public class ScheduleDto
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public List<DayOfWeek> WeekDays { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
