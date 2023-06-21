namespace ButikAPI.Models
{
    public class Employee:BaseEntity
    {
        public int NIK { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
    }
}
