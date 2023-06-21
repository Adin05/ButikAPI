namespace ButikAPI.DTOs
{
    public class FilterDto
    {
        public bool IsHigh { get; set; }
        public bool IsOld { get; set; }
        public int BranchId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
