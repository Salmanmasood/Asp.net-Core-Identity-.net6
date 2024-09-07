namespace User.Management.Data.Models.Violations
{
    public class BaseEntity
    {
        public int CreatedBy { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedDate { get; set; }


    }
}