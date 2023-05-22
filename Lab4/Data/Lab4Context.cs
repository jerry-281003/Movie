using Microsoft.EntityFrameworkCore;

namespace Lab4.Data
{
    public class Lab4Context : DbContext
    {
        public Lab4Context(DbContextOptions<Lab4Context> options)
            : base(options)
        {
        }

        public DbSet<lab4Models.Movie> Movie { get; set; } = default!;
    }
}
