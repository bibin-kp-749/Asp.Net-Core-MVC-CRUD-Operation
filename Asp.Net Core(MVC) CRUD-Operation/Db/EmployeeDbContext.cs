using Asp.Net_Core_MVC__CRUD_Operation.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.Net_Core_MVC__CRUD_Operation.Db
{
    public class EmployeeDbContext:DbContext
    {
        private readonly string connectionstring;
        public EmployeeDbContext(IConfiguration configuration)
        {
            this.connectionstring =configuration["ConnectionStrings:connection"];
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionstring);
        }
        public DbSet<Employee>Employees { get; set; }   
    }
}
