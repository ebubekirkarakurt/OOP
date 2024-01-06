using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class RepositoryContext : DbContext
{
    public DbSet<Books> Books { get; set; }
    public DbSet<Authors> Authors { get; set; }

    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder
        .Entity<Books>()
        .HasMany(b => b.Authors)
        .WithMany(b => b.Books);
    }
}