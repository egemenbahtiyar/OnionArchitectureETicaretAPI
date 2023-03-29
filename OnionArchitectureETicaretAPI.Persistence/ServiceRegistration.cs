using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureETicaretAPI.Persistence.Contexts;

namespace OnionArchitectureETicaretAPI.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<ETicaretAPIDbContext>(options => options.UseSqlServer("Data Source=.\\SQLEXPRESS;database=ETicaretAPI_DB; integrated security=SSPI"));
    }
}