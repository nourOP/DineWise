namespace DineWise.Data.Models
{
    public class RestaurantTable
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public double PricePerHour { get; set; }
        public List<Extra>? Extras { get; set; }
        public Restaurant Restaurant { get; set; }
        public ICollection<ReservationRestaurantTable>? ReservationRestaurantTables { get; set; }

    }

}