﻿namespace DineWise.Data.Models
{
    public class Join_UserRole
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
