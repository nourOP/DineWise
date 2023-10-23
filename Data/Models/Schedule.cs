﻿namespace DineWise.Data.Models
{
    
    public class Schedule
    {
        public int Id { get; set; }

        //entries per day for now, will later on be enhanced in a separate table
        public DayOfWeek WeekDay { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
