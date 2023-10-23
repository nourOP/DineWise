namespace DineWise.Data.Models
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ICollection<Join_RestaurantTableFeature>? RestaurantTableFeatures { get; set; }

    }
}
