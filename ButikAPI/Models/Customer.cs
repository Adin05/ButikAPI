namespace ButikAPI.Models
{
    public class Customer: BaseEntity
    {
        public string Name { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public int BranchId { get; set; }
    }
}
