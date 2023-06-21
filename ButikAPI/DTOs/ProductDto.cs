namespace ButikAPI.DTOs
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int BranchId { get; set; }
    }
}
