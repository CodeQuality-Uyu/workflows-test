using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Test.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ConcreteDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("Test")).LogTo(Console.WriteLine, LogLevel.Information));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();

[ExcludeFromCodeCoverage]
public partial class Program
{
}
