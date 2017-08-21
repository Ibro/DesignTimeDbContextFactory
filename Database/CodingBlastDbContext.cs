using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class CodingBlastDbContext: DbContext
    {
        public CodingBlastDbContext(DbContextOptions<CodingBlastDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
