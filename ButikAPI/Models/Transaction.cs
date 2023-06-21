namespace ButikAPI.Models
{
    public class Transaction:BaseEntity
    {
        public int ProductId { get; set; }
        public int CustommerId { get; set; }
        public int EmployeeId { get; set; }
        public double TotalPrice { get; set; }
    }
}
