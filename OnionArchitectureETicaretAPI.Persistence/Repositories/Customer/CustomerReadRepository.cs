using OnionArchitectureETicaretAPI.Application.Repositories.Customer;
using OnionArchitectureETicaretAPI.Persistence.Contexts;

namespace OnionArchitectureETicaretAPI.Persistence.Repositories.Customer;

public class CustomerReadRepository : ReadRepository<Domain.Entities.Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}