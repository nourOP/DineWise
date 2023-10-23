namespace DineWise.Data.Models
{
    public class OverwrittenSchedule
    {
        public int Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public ICollection<Schedule> Schedules { get; set;}

    }
}
