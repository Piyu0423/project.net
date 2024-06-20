using Microsoft.EntityFrameworkCore;
using project.net.Models.Entities;

namespace project.net.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options) 
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}
