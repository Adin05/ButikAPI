namespace ButikAPI.Models
{
    public class Customer: BaseEntity
    {
        public string Name { get; set; }
        public DateTime? dateTime { get; set; }
        public int BranchId { get; set; }
    }
}
