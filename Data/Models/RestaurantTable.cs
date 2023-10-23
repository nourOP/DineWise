namespace DineWise.Data.Models
{
    public class RestaurantTable
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public double PricePerHour { get; set; }
        public Restaurant Restaurant { get; set; }
        public ICollection<Join_RestaurantTableFeature>? RestaurantTableFeatures { get; set; }
        public ICollection<Join_ReservationRestaurantTable>? ReservationRestaurantTables { get; set; }
        public AuditRecords auditRecords { get; set; }

    }

}