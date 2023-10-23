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
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid LastUpdateBy { get; set; }
        public DateTime LastUpdateAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }


    }

}
