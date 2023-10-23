using DineWise.Data.Models;

namespace DineWise.Data.DTO
{
    public class RestaurantTableDto
    {
            public int Id { get; set; }
            public int RestaurantId { get; set; }
            public int Capacity { get; set; }
            public double PricePerHour { get; set; }
            public List<Feature> Features { get; set; }
    }

}
