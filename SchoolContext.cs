using Microsoft.EntityFrameworkCore;

namespace CodeFirstStudentApp
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=StudentDB;Trusted_Connection=True;");
        }
    }
}
