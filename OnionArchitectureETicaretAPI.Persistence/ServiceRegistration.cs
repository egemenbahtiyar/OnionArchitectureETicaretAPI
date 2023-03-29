using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureETicaretAPI.Application.Repositories.Customer;
using OnionArchitectureETicaretAPI.Application.Repositories.Order;
using OnionArchitectureETicaretAPI.Application.Repositories.Product;
using OnionArchitectureETicaretAPI.Persistence.Contexts;
using OnionArchitectureETicaretAPI.Persistence.Repositories.Customer;
using OnionArchitectureETicaretAPI.Persistence.Repositories.Order;
using OnionArchitectureETicaretAPI.Persistence.Repositories.Product;

namespace OnionArchitectureETicaretAPI.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    { 
        services.AddDbContext<ETicaretAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
        services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
        services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        services.AddScoped<IProductReadRepository, ProductReadRepository>();
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
    }
}