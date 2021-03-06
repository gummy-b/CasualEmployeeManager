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
    }
}
