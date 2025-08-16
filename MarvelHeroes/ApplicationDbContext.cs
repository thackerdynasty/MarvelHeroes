using Microsoft.EntityFrameworkCore;

namespace MarvelHeroes;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Hero> Heroes { get; set; }
}