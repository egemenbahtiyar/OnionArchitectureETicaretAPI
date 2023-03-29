using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OnionArchitectureETicaretAPI.Persistence.Contexts;

namespace OnionArchitectureETicaretAPI.Persistence;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretAPIDbContext>
{
    public ETicaretAPIDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ETicaretAPIDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;database=ETicaretAPI_DB; integrated security=SSPI");
        return new ETicaretAPIDbContext(dbContextOptionsBuilder.Options);
    }
}