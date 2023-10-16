using DineWise.Data.Models;
namespace DineWise.Data.DTO
{
    public class RestaurantDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string? Description { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<RestaurantTable> RestaurantTables { get; set; }

    }

}
