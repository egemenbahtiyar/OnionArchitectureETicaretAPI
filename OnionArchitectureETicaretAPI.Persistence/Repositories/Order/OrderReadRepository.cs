using OnionArchitectureETicaretAPI.Application.Repositories.Order;
using OnionArchitectureETicaretAPI.Persistence.Contexts;

namespace OnionArchitectureETicaretAPI.Persistence.Repositories.Order;

public class OrderReadRepository: ReadRepository<Domain.Entities.Order>, IOrderReadRepository
{
    public OrderReadRepository(ETicaretAPIDbContext context) : base(context)
    {
        
    }
}