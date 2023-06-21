namespace ButikAPI.ViewModels
{
    public class TransactionViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustommerId { get; set; }
        public int EmployeeId { get; set; }
        public double TotalPrice { get; set; }
    }
}
