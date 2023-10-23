namespace DineWise.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string? Description { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<OverwrittenSchedule> OverwrittenSchedules { get; set; }
        public ICollection<RestaurantTable> RestaurantTables { get; set; }
        public AuditRecords auditRecords { get; set; }

    }

}
