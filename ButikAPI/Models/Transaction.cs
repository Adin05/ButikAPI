namespace ButikAPI.Models
{
    public class Transaction:BaseEntity
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int BranchId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
