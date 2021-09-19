using CasualEmployee.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CasualEmployee.API.Data
{
    public class CEContext : DbContext
    {
        public CEContext(DbContextOptions<CEContext> options) : base(options)
        {

        }

        public DbSet<Roles> Roles { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<CEmployee> Employees { get; set; }
        public DbSet<Employee_Task> EmployeeTasks { get; set; }
        public DbSet<Assign_Task> Assign_Tasks { get; set; }
        public DbSet<Hours_Worked> HoursWorked { get; set; }
    }
}
