using Microsoft.EntityFrameworkCore;
using Test.Services;

namespace Test.DataAccess;

public sealed class ConcreteDbContext(DbContextOptions options)
    : DbContext(options)
{
    public DbSet<Movie> Movies { get; set; }
}
