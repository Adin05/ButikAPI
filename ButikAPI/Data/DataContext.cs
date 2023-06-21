using ButikAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ButikAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions opt) : base(opt)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
