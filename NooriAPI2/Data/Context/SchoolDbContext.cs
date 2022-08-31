using Microsoft.EntityFrameworkCore;
using NooriAPI2.Data.Entity;

namespace NooriAPI2.Data.Context
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Noori_Students { get; set; }
        public DbSet<Course> Noori_Courses { get; set; }
    }
}
