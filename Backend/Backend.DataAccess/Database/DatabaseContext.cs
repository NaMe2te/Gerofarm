using Backend.DataAccess.EntityConfigurations;
using Backend.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.DataAccess.Database;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public DbSet<Post> Posts { get; private set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PostConfiguration());

        if (Posts.Any())
        {
            new DatabaseInitializer(modelBuilder).Seed();
        }
    }
}