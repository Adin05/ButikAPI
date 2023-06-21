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
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Branch> Branches{ get; set; }
    }
}
