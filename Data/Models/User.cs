namespace DineWise.Data.Models
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
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid LastUpdateBy { get; set; }
        public DateTime LastUpdateAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }


    }
}
