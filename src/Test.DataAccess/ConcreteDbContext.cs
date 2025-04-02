using Microsoft.EntityFrameworkCore;

namespace Test.DataAccess;

public sealed class ConcreteDbContext(DbContextOptions options)
    : DbContext(options)
{
}
