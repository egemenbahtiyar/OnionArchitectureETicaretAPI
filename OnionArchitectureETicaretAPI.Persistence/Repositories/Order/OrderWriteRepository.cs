using OnionArchitectureETicaretAPI.Application.Repositories.Order;
using OnionArchitectureETicaretAPI.Persistence.Contexts;

namespace OnionArchitectureETicaretAPI.Persistence.Repositories.Order;

public class OrderWriteRepository : WriteRepository<Domain.Entities.Order>, IOrderWriteRepository
{
    public OrderWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
        
    }
    
}