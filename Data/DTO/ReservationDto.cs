using DineWise.Data.Models;

namespace DineWise.Data.DTO
{
    public class ReservationDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int RestaurantId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int NumberOfGuests { get; set; }
        public string Notes { get; set; }

        public List<RestaurantTableDto> RestaurantTables { get; set; }
    }
}