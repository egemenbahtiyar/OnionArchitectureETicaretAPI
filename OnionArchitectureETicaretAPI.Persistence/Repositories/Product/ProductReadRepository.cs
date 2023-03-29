using OnionArchitectureETicaretAPI.Application.Repositories.Product;
using OnionArchitectureETicaretAPI.Persistence.Contexts;

namespace OnionArchitectureETicaretAPI.Persistence.Repositories.Product;

public class ProductReadRepository : ReadRepository<Domain.Entities.Product>, IProductReadRepository
{
    public ProductReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}