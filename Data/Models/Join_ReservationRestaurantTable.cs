namespace DineWise.Data.Models
{
    public class Join_ReservationRestaurantTable
    {
        public int Id { get; set; }
        public Guid ReservationId { get; set; }
        public int RestaurantTableId { get; set; }
        public Reservation Reservation { get; set; }
        public RestaurantTable RestaurantTable { get; set; }

    }
}
