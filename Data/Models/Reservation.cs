namespace DineWise.Data.Models
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int NumberOfGuests { get; set; }
        public string? Notes { get; set; }
        public User User { get; set; }
        public Restaurant Restaurant { get; set; }
        public ICollection<Join_ReservationRestaurantTable> ReservationRestaurantTables { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid LastUpdateBy { get; set; }
        public DateTime LastUpdateAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }


    }
}
