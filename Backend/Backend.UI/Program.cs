using Backend.Application.Extensions;
using Backend.DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services
    .AddApplication()
    .AddDataAccess(x => x.UseSqlite("Data Source=gerofarm.db"));
    

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors();

app.MapControllers();

app.Run();