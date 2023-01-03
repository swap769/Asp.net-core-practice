using Microsoft.EntityFrameworkCore;

namespace MyFirstWeb.Models
{
    public class EmpoyleeContext : DbContext
    {
        public EmpoyleeContext(DbContextOptions<EmpoyleeContext>options) : base(options) { 

        }
        public DbSet<EmployeeDatabase> Employees { get; set; }


    }
} 
