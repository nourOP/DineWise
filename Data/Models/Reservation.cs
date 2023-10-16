﻿namespace DineWise.Data.Models
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public int RestaurantId { get; set; }
        public List<RestaurantTable> RestaurantTables { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int NumberOfGuests { get; set; }
        public string? Notes { get; set; }
    }
}
