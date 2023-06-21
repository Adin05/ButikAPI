namespace ButikAPI.DTOs
{
    public class CustomerDto : BaseDto
    {
        public string Name { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public int BranchId { get; set; }
    }
}
