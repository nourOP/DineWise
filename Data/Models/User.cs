﻿namespace DineWise.Data.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; } 
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public List<Join_UserRole> UserRoles { get; set; }
    }
}
