namespace ButikAPI.DTOs
{
    public class TransactionDto : BaseDto
    {
        public int ProductId { get; set; }
        public int CustommerId { get; set; }
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
