// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using webappapi.Shared;

namespace webappapi.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
