using Backend.Application.Extensions;
using Backend.DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var configuration = app.Configuration;

builder.Services.AddControllers();

builder.Services
    .AddApplication()
    .AddDataAccess(x => x.UseLazyLoadingProxies().UseSqlite("Data Source=gerofarm.db"));
    

app.UseHttpsRedirection();

app.UseCors();

app.MapControllers();

app.Run();