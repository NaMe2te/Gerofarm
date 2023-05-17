using Backend.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.DataAccess.Database;

public class DatabaseInitializer
{
    private readonly ModelBuilder _modelBuilder;

    public DatabaseInitializer(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        var posts = new List<Post>();
        for (int i = 0; i < 500; i++)
            posts.Add(new Post(default, ""));
        
        _modelBuilder.Entity<Post>().HasData(posts);
    }
}