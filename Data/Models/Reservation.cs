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
        public AuditRecords auditRecords { get; set; }

    }
}
