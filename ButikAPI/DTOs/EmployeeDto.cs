namespace ButikAPI.DTOs
{
    public class EmployeeDto : BaseDto
    {
        public string Name { get; set; }
        public int NIK { get; set; }
        public int BranchId { get; set; }
    }
}
