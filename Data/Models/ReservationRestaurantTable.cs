namespace DineWise.Data.Models
{
    public class ReservationRestaurantTable
    {
        public Guid ReservationId { get; set; }
        public int RestaurantTableId { get; set; }
        public Reservation Reservation { get; set; }
        public RestaurantTable RestaurantTable { get; set; }
    }
}
