using Microsoft.EntityFrameworkCore;

namespace project.net.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options) 
        {
        }

    }
}
