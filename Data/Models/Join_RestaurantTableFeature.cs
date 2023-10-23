namespace DineWise.Data.Models
{
    public class Join_RestaurantTableFeature
    {
        public int RestaurantTableId { get; set; }
        public int FeatureId { get; set; }
        public RestaurantTable RestaurantTable { get; set; }
        public Feature Feature { get; set; }
    }
}
