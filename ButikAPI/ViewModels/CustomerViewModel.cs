namespace ButikAPI.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public int BranchId { get; set; }
    }
}
