namespace DineWise.Data.Models
{
    public class AuditRecords
    {
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid LastUpdateBy { get; set; }
        public DateTime LastUpdateAt { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public Guid? DeletedBy { get; set; }
        public DateTime? DeletedAt { get; set; }


    }
}
