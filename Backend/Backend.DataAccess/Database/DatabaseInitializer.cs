using System.Text;
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

    
}