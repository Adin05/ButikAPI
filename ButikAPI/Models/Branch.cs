namespace ButikAPI.Models
{
    public class Branch:BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }
    }
}
