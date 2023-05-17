using System.Text;
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
        Seed();
    }

    public DbSet<Post> Posts { get; private set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PostConfiguration());
    }

    private void Seed()
    {
        if (Posts.Any()) 
            return;
        
        for (int i = 0; i < 500; i++)
        {
            Posts.Add(new Post(CreateTitle()));
        }

        SaveChanges();
    }

    private string CreateTitle()
    {
        Random random = new Random();
        int length = random.Next(5, 11);
        
        string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder builder = new StringBuilder();
        
        for (int i = 0; i < length; i++)
        {
            int index = random.Next(chars.Length);
            builder.Append(chars[index]);
        }

        return builder.ToString();
    }
}