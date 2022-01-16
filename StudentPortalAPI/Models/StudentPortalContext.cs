using Microsoft.EntityFrameworkCore;

namespace StudentPortalAPI.Models
{
    public class StudentPortalContext : DbContext 
    {
        public StudentPortalContext(DbContextOptions<StudentPortalContext> options): base(options)
        {
                
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Address> Address { get; set; }

    }
}
