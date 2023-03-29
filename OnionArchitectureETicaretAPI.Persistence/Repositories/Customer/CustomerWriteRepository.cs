using OnionArchitectureETicaretAPI.Application.Repositories.Customer;
using OnionArchitectureETicaretAPI.Persistence.Contexts;

namespace OnionArchitectureETicaretAPI.Persistence.Repositories.Customer;

public class CustomerWriteRepository : WriteRepository<Domain.Entities.Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}