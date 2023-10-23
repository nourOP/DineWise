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
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid LastUpdateBy { get; set; }
        public DateTime LastUpdateAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }


    }

}